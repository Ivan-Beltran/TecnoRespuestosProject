use TecnoRepuestosDB

INSERT INTO Role (RoleType)
VALUES 
('Admin'),
('Cajero'),
('Supervisor')

INSERT INTO Users (RoleId,Name,LastName,UserName,Password,Email,Telephone,DUI)
VALUES (1,'ivan','beltran','ivanbel','1234','ivanbeltran@example.com','7123-4567','01234567-8');

INSERT INTO Users (RoleId,Name,LastName,UserName,Password,Email,Telephone,DUI)
VALUES (1,'steven','gomes','teven','1234','ivanbeltran@example.com','7123-4567','01234567-8');


--insert de categorias --
INSERT INTO CategoryProducts (CategoryName) VALUES ('Frenos');
INSERT INTO CategoryProducts (CategoryName) VALUES ('Suspensión');
INSERT INTO CategoryProducts (CategoryName) VALUES ('Motor');
INSERT INTO CategoryProducts (CategoryName) VALUES ('Eléctrico');
INSERT INTO CategoryProducts (CategoryName) VALUES ('Transmisión');
INSERT INTO CategornyProducts (CategoryName) VALUES ('Filtros');


--insert into cuentas--

INSERT INTO AccountCatalog (AccountName, TypeAccount) 
VALUES
    ('efectivo y equivalente', 'Activo'),
    ('ventas', 'Activo'),
    ('inventario', 'Activo'),
    ('planta y equipo', 'Activo'),
    ('costo de ventas', 'capital'),
    ('iva credito', 'activo'),
    ('iva debito', 'pasivo'),
    ('cuentas por pagar', 'pasivo'),
    ('cuentas por cobrar', 'activo')
 
   --insert de subcuentas--
   INSERT INTO SubAccountsCatalog(AccountCatalogId,SubAccountName,Amount)
   VALUES
    (1,'caja',0),
    (1,'bancos',0)

    insert into CompanyData(Name,Address,BusinessName,TypeBusiness,NRC,NIT,Telephone,Email)
    VALUES
        ('Tecno Respuestos','Avenida Roosevelt San miguel casa 4','Tecno Repuestos','venta de respuestos','366392-4','1217-1804004-102-0','79461274','tecnorepuesto@gmail.com')

    select * from CompanyData