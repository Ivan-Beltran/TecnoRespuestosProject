use TecnoRepuestosDB

CREATE OR ALTER PROCEDURE LoginUser
    @UserName VARCHAR(50),
    @Password VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        u.Id AS Id,
        u.UserName AS UserName,
        u.Name as FullName,
        u.RoleId AS RoleId
    FROM Users u
    WHERE u.UserName = @UserName
      AND u.Password = @Password;
END
GO



CREATE PROCEDURE sp_InsertSupplier
    @SupplierName   VARCHAR(45),
    @ContacName     VARCHAR(45),
    @NIT            VARCHAR(20),
    @NRC            VARCHAR(20) = NULL,
    @Telephone      VARCHAR(20),
    @Email          VARCHAR(45),
    @Address        VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Suppliers
    (
        SupplierName,
        ContacName,
        NIT,
        NRC,
        Telephone,
        Email,
        Address,
        IsTaxPayer
    )
    VALUES
    (
        @SupplierName,
        @ContacName,
        @NIT,
        @NRC,
        @Telephone,
        @Email,
        @Address,
        1 -- siempre 1 como lo pediste
    );
END
GO

--ver proveedores--
CREATE OR ALTER PROCEDURE sp_GetSuppliers
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Id,
        SupplierName as nombre,
        ContacName as contacto,
        NIT,
        NRC,
        Telephone as telefono,
        Email,
        Address as direccion,
        IsTaxPayer,
        CASE 
            WHEN IsTaxPayer = 1 THEN 'Contribuyente'
            ELSE 'No contribuyente'
        END AS tipo
    FROM Suppliers;
END
GO

--consultar categorias--
CREATE or alter PROCEDURE GetCategoryProducts
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Id,
        CategoryName
    FROM CategoryProducts
    ORDER BY CategoryName;
END

--consultar productos--
CREATE or alter PROCEDURE sp_GetProducts
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.Id,
        p.Code AS codigo,
        p.Brand AS marca,
        p.ProductName AS nombre,
        p.Model AS modelo,
        p.UnitCost AS 'precio unitario',
        p.UnitPrice AS 'costo unitario',
        p.Quantity AS Cantidad,

        CASE 
            WHEN p.IsAvailable = 1 THEN 'Sí'
            ELSE 'No'
        END AS disponibilidad,

        c.CategoryName AS Category
    FROM Products p
    INNER JOIN CategoryProducts c ON p.CategoryId = c.Id
    ORDER BY p.Id DESC;
END
GO


--insertar productos--
CREATE PROCEDURE sp_InsertProduct
    @CategoryId INT,
    @Code VARCHAR(45),
    @Brand VARCHAR(45),
    @ProductName VARCHAR(45),
    @Model VARCHAR(45)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Products (
        CategoryId,
        Code,
        Brand,
        ProductName,
        Model,
        UnitCost,
        UnitPrice,
        Quantity,
        IsAvailable,
        ImgPath
    )
    VALUES (
        @CategoryId,
        @Code,
        @Brand,
        @ProductName,
        @Model,
        0.00,     -- UnitCost
        0.00,     -- UnitPrice
        0,        -- Quantity
        0,        -- IsAvailable
        NULL      -- ImgPath
    );
END
GO


--ver clientes--

CREATE PROCEDURE sp_GetCustomers
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Id,
        Name AS nombre,
        LastName AS apellido,
        Address AS direccion,
        DUI AS dui,
        Email AS correo,
        Telephone AS telefono,
        NRC AS nrc,
        CustomerType AS tipoCliente
    FROM Customers
    ORDER BY Name, LastName;
END
GO

--insert para clientes --
CREATE or alter PROCEDURE InsertCustomer
    @Name VARCHAR(45),
    @LastName VARCHAR(45),
    @Address VARCHAR(50),
    @DUI VARCHAR(10),
    @Email VARCHAR(45),
    @Telephone VARCHAR(20),
    @NRC VARCHAR(20) = NULL
AS
BEGIN
    INSERT INTO Customers (Name, LastName, Address, DUI, Email, Telephone, NRC, CustomerType)
    VALUES (@Name, @LastName, @Address, @DUI, @Email, @Telephone, @NRC, 'Contribuidor');
END


--proceso de compras--
CREATE OR ALTER PROCEDURE sp_RegisterPurchase
(
    @SupplierId INT,
    @InvoiceNumber VARCHAR(45),
    @PurchaseType VARCHAR(45),
    @PaymentType VARCHAR(45),
    @CreditEndDate DATE = NULL,       -- ← NUEVO PARÁMETRO
    @Items PurchaseItemType READONLY
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        --------------------------------------------------------------------
        -- 1. Insert Purchases
        --------------------------------------------------------------------
        INSERT INTO Purchases (SupplierId, Date, InvoiceNumber, PurchaseType, PaymentType)
        VALUES (@SupplierId, GETDATE(), @InvoiceNumber, @PurchaseType, @PaymentType);

        DECLARE @PurchaseId INT = SCOPE_IDENTITY();


        --------------------------------------------------------------------
        -- 2. Insert PurchaseDetails + Update Products
        --------------------------------------------------------------------
        INSERT INTO PurchaseDetails (PurchaseId, ProductId, Quantity, UnitCost, SubTotal, IVA, Total)
        SELECT 
            @PurchaseId,
            ProductId,
            Quantity,
            UnitCost,
            Quantity * UnitCost,
            (Quantity * UnitCost) * 0.13,
            (Quantity * UnitCost) * 1.13
        FROM @Items;

        UPDATE p
           SET p.Quantity = p.Quantity + i.Quantity,
               p.UnitCost = i.UnitCost,
               p.UnitPrice = i.UnitPrice
        FROM Products p
        INNER JOIN @Items i ON p.Id = i.ProductId;


        --------------------------------------------------------------------
        -- 3. Totales para asiento contable
        --------------------------------------------------------------------
        DECLARE @SubTotal DECIMAL(18,2) = 0;
        DECLARE @IVACredito DECIMAL(18,2) = 0;

        SELECT
            @SubTotal += Quantity * UnitCost,
            @IVACredito += (Quantity * UnitCost) * 0.13
        FROM @Items;

        DECLARE @GrandTotal DECIMAL(18,2) = @SubTotal + @IVACredito;


        --------------------------------------------------------------------
        -- 4. Insert JournalEntries con BatchNumber secuencial
        --------------------------------------------------------------------
        DECLARE @BatchNumber INT = NEXT VALUE FOR Seq_BatchNumber;

        INSERT INTO JournalEntries (EntryDate, Description, BatchNumber)
        VALUES (GETDATE(), 'Compra a contribuyente', @BatchNumber);

        DECLARE @JournalId INT = SCOPE_IDENTITY();


        --------------------------------------------------------------------
        -- 5. JournalEntrieDetails
        --------------------------------------------------------------------
        -- Inventario
        INSERT INTO JournalEntrieDetails (JournalEntrieId, AccountCatalogId, Debit, Credit)
        VALUES (@JournalId, 3, @SubTotal, 0);

        -- IVA crédito
        INSERT INTO JournalEntrieDetails (JournalEntrieId, AccountCatalogId, Debit, Credit)
        VALUES (@JournalId, 6, @IVACredito, 0);

        -- Método de pago
        DECLARE @Account INT = CASE
                                 WHEN @PaymentType = 'Efectivo' THEN 1
                                 WHEN @PaymentType = 'Tarjeta' THEN 1
                                 WHEN @PaymentType = 'Credito' THEN 8
                               END;

        INSERT INTO JournalEntrieDetails (JournalEntrieId, AccountCatalogId, Debit, Credit)
        VALUES (@JournalId, @Account, 0, @GrandTotal);


        --------------------------------------------------------------------
        -- 6. Insertar en Cuentas por Pagar SOLO si es crédito
        --------------------------------------------------------------------
        IF (@PaymentType = 'Credito')
        BEGIN
            INSERT INTO AccountPaybles
            (
                PurchaseId,
                StartDate,
                EndDate,
                TotalAmount,
                PaidAmount,
                Status,
                UpdateAt
            )
            VALUES
            (
                @PurchaseId,
                GETDATE(),         -- fecha de inicio
                @CreditEndDate,    -- FECHA FINAL QUE ENVIAS
                @GrandTotal,
                0,                 -- aun no se paga nada
                'Pendiente',
                GETDATE()
            );
        END


        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END
GO


CREATE  SEQUENCE Seq_BatchNumber
    AS INT
    START WITH 1
    INCREMENT BY 1;
GO

--trigger para cambiar disponibilidad--
CREATE TRIGGER trg_UpdateAvailability
ON Products
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE p
   0ET p.IsAvailable = CASE 
                            WHEN i.Quantity > 0 THEN 1 
                            ELSE 0 
                        END
    FROM Products p
    INNER JOIN inserted i ON p.Id = i.Id;
END;
GO





CREATE PROCEDURE sp_GetPendingAccounts
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        ap.Id AS AccountId,
        p.Id AS PurchaseId,
        s.SupplierName as proveedor,
        p.InvoiceNumber as factura,
        p.Date AS 'fecha compra',
        ap.StartDate as inicio,
        ap.EndDate as finalizacion,
        ap.TotalAmount as 'monto total',
        ap.PaidAmount as 'monto pagado',
        ap.Status as estado
    FROM AccountPaybles ap
    INNER JOIN Purchases p ON ap.PurchaseId = p.Id
    INNER JOIN Suppliers s ON p.SupplierId = s.Id
    WHERE ap.Status = 'Pendiente'
    ORDER BY ap.EndDate ASC;
END
GO


--cuentas pagadas--
CREATE or alter PROCEDURE sp_GetPaidAccounts
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        ap.Id AS AccountId,
        p.Id AS PurchaseId,
        s.SupplierName as proveedor,
        p.InvoiceNumber as factura,
        p.Date AS 'fecha compra',
        ap.StartDate as inicio,
        ap.EndDate as finalizacion,
        ap.TotalAmount as 'monto total',
        ap.PaidAmount as 'monto pagado',
        ap.Status as estado
    FROM AccountPaybles ap
    INNER JOIN Purchases p ON ap.PurchaseId = p.Id
    INNER JOIN Suppliers s ON p.SupplierId = s.Id
    WHERE ap.Status = 'Pagado'
    ORDER BY ap.UpdateAt DESC;
END
GO


--pago de cuentas por pagar --
CREATE OR ALTER PROCEDURE sp_PayAccount
(
    @AccountId INT,
    @Amount DECIMAL(12,2)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        --------------------------------------------------------------------
        -- 1. Obtener datos actuales de la cuenta por pagar
        --------------------------------------------------------------------
        DECLARE @TotalAmount DECIMAL(12,2),
                @PaidAmount DECIMAL(12,2),
                @Remaining DECIMAL(12,2),
                @PurchaseId INT;

        SELECT 
            @TotalAmount = TotalAmount,
            @PaidAmount = PaidAmount,
            @PurchaseId = PurchaseId
        FROM AccountPaybles
        WHERE Id = @AccountId;

        IF (@TotalAmount IS NULL)
        BEGIN
            THROW 51000, 'La cuenta por pagar no existe.', 1;
        END

        --------------------------------------------------------------------
        -- 2. Validar que no se pague más de lo que se debe
        --------------------------------------------------------------------
        SET @Remaining = @TotalAmount - @PaidAmount;

        IF (@Amount > @Remaining)
        BEGIN
            THROW 51000, 'No puede abonar más del saldo pendiente.', 1;
        END


        --------------------------------------------------------------------
        -- 3. Actualizar abono
        --------------------------------------------------------------------
        DECLARE @NewPaid DECIMAL(12,2) = @PaidAmount + @Amount;

        UPDATE AccountPaybles
        SET 
            PaidAmount = @NewPaid,
            Status = CASE WHEN @NewPaid >= @TotalAmount THEN 'Pagado' ELSE 'Pendiente' END,
            UpdateAt = GETDATE()
        WHERE Id = @AccountId;


        --------------------------------------------------------------------
        -- 4. Registrar asiento contable (Encabezado)
        --------------------------------------------------------------------
        DECLARE @BatchNumber INT = NEXT VALUE FOR Seq_BatchNumber;
        DECLARE @JournalId INT;

        INSERT INTO JournalEntries (EntryDate, Description, BatchNumber)
        VALUES 
        (
            GETDATE(),
            'Abono a Cuenta por Pagar. Cuenta ID ' + CAST(@AccountId AS VARCHAR),
            @BatchNumber
        );

        SET @JournalId = SCOPE_IDENTITY();


        --------------------------------------------------------------------
        -- 5. Registrar asiento contable (Detalle)
        --    Cuentas por pagar (DEBE) → disminuye deuda
        --    Caja (HABER) → sale dinero
        --------------------------------------------------------------------
        -- Cuentas por pagar
        INSERT INTO JournalEntrieDetails (JournalEntrieId, AccountCatalogId, Debit, Credit)
        VALUES (@JournalId, 8, @Amount, 0);  -- CUENTAS POR PAGAR (ID 8 en tu SP)

        -- Caja
        INSERT INTO JournalEntrieDetails (JournalEntrieId, AccountCatalogId, Debit, Credit)
        VALUES (@JournalId, 1, 0, @Amount);  -- CAJA (ID 1 en tu SP)


        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END
GO

CREATE TYPE SaleItemType AS TABLE
(
    ProductId INT,
    Quantity INT,
    UnitPrice DECIMAL(12,2),
    UnitCost  DECIMAL(12,2)   -- ← IMPORTANTE para costo de ventas
);
GO


select* from AccountCatalog

--proceso de ventas--
CREATE OR ALTER PROCEDURE sp_RegisterSale
(
    @UserId INT,
    @CompanyDataId INT,
    @CustomerId INT,
    @PaymentMethod VARCHAR(50),     -- Efectivo | Tarjeta | Credito
    @CreditEndDate DATE = NULL,     -- si es crédito
    @Items SaleItemType READONLY
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        --------------------------------------------------------------------
        -- 1. Insertar Venta
        --------------------------------------------------------------------
        INSERT INTO Sales
        (
            UserId, CompanyDataId, CustomerId,
            SaleDate, PaymentMethod, Status, UpdateAt
        )
        VALUES
        (
            @UserId, '1', @CustomerId,
            GETDATE(), @PaymentMethod, 'Completada', GETDATE()
        );

        DECLARE @SaleId INT = SCOPE_IDENTITY();


        --------------------------------------------------------------------
        -- 2. Insertar Detalles + Calcular totales
        --------------------------------------------------------------------
        INSERT INTO SaleDetails
        (SaleId, ProductId, Quantity, UnitPrice, SubTotal, IVA, Total)
        SELECT
            @SaleId,
            ProductId,
            Quantity,
            UnitPrice,
            Quantity * UnitPrice,
            (Quantity * UnitPrice) * 0.13,
            (Quantity * UnitPrice) * 1.13
        FROM @Items;

        --------------------------------------------------------------------
        -- Descontar inventario
        --------------------------------------------------------------------
        UPDATE p
           SET p.Quantity = p.Quantity - i.Quantity
        FROM Products p
        INNER JOIN @Items i ON p.Id = i.ProductId;


        --------------------------------------------------------------------
        -- 3. Totales contables
        --------------------------------------------------------------------
        DECLARE @SubTotal DECIMAL(12,2) = 0;
        DECLARE @DebitoFiscal DECIMAL(12,2) = 0;
        DECLARE @TotalVenta DECIMAL(12,2) = 0;
        DECLARE @CostoVenta DECIMAL(12,2) = 0;

        SELECT 
            @SubTotal += Quantity * UnitPrice,
            @DebitoFiscal += (Quantity * UnitPrice) * 0.13,
            @TotalVenta += (Quantity * UnitPrice) * 1.13,
            @CostoVenta += Quantity * UnitCost
        FROM @Items;


        --------------------------------------------------------------------
        -- 4. Insertar asiento contable
        --------------------------------------------------------------------
        DECLARE @BatchNumber INT = NEXT VALUE FOR Seq_BatchNumber;

        INSERT INTO JournalEntries (EntryDate, Description, BatchNumber)
        VALUES (GETDATE(), 'Venta a cliente', @BatchNumber);

        DECLARE @JournalId INT = SCOPE_IDENTITY();


        --------------------------------------------------------------------
        -- 5. Asientos contables
        --------------------------------------------------------------------

        -- EFECTIVO O CUENTAS POR COBRAR (DEBE)
        DECLARE @CuentaDebe INT =
            CASE 
                WHEN @PaymentMethod = 'Efectivo' THEN 1   -- efectivo
                WHEN @PaymentMethod = 'Tarjeta' THEN 1    -- lo manejas igual
                WHEN @PaymentMethod = 'Credito' THEN 9    -- CxC
            END;

        INSERT INTO JournalEntrieDetails
        (JournalEntrieId, AccountCatalogId, Debit, Credit)
        VALUES (@JournalId, @CuentaDebe, @TotalVenta, 0);


        -- VENTAS (HABER)
        INSERT INTO JournalEntrieDetails
        (JournalEntrieId, AccountCatalogId, Debit, Credit)
        VALUES (@JournalId, 2, 0, @SubTotal);

        -- DEBITO FISCAL (HABER)
        INSERT INTO JournalEntrieDetails
        (JournalEntrieId, AccountCatalogId, Debit, Credit)
        VALUES (@JournalId, 7, 0, @DebitoFiscal);


        -- COSTO DE VENTAS (DEBE)
        INSERT INTO JournalEntrieDetails
        (JournalEntrieId, AccountCatalogId, Debit, Credit)
        VALUES (@JournalId, 5, @CostoVenta, 0);

        -- INVENTARIO (HABER)
        INSERT INTO JournalEntrieDetails
        (JournalEntrieId, AccountCatalogId, Debit, Credit)
        VALUES (@JournalId, 3, 0, @CostoVenta);


        --------------------------------------------------------------------
        -- 6. CUENTAS POR COBRAR SOLO SI ES CRÉDITO
        --------------------------------------------------------------------
        IF (@PaymentMethod = 'Credito')
        BEGIN
            INSERT INTO AccountsReceivable
            (
                SaleId, CustomerId, StartDate, EndDate,
                TotalAmount, PaidAmount, Status, UpdateAt
            )
            VALUES
            (
                @SaleId,
                @CustomerId,
                GETDATE(),
                @CreditEndDate,
                @TotalVenta,
                0,
                'Pendiente',
                GETDATE()
            );
        END


        --------------------------------------------------------------------
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END
GO


 
 --obtener siguiente numero de venta--
CREATE OR ALTER PROCEDURE GetNextSaleNumber
AS
BEGIN
    SELECT CONVERT(INT, current_value) + 1 AS NextSaleNumber
    FROM sys.sequences
    WHERE name = 'SaleNumberSequence';
END
GO


