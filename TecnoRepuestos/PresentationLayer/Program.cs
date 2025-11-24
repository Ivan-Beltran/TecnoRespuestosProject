using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PresentationLayer.Forms;
using BusinessLayer.Services.ServiceForLogin;
using CommonLayer.Entities;
using DataAccesLayer.Repositories.LoginRepo;
using DataAccesLayer.dbConnect;
using DataAccesLayer.Repositories;
using DataAccesLayer.Repositories.SuppliersRepo;
using BusinessLayer.Services;
using DataAccesLayer.Repositories.ProductsRepo;
using BusinessLayer.Services.ServiceForProduct;
using DataAccesLayer.Repositories.CustomersRepo;
using BusinessLayer.Services.ServiceForCustomer;
using DataAccesLayer.Repositories.AccountsRepo;
using BusinessLayer.Services.ServeceForAccounts;
using DataAccesLayer.Repositories.SalesRepo;
using BusinessLayer.Services.ServiceForSales;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        Application.Run(ServiceProvider.GetRequiredService<Login>());
    }

    public static IServiceProvider ServiceProvider { get; private set; }

    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                // FORMULARIOS
                services.AddTransient<Login>();
                services.AddTransient<Dashboard>();

                // REPOSITORIOS
                services.AddScoped<LoginRepository>();
                services.AddScoped<SuppliersRepository>();
                services.AddScoped<ProductsRepository>();
                services.AddScoped<CustomersRepository>();
                services.AddScoped<AccountsRepository>();
                services.AddScoped<SalesRepository>();


                // SERVICIOS
                services.AddScoped<LoginService>();
                services.AddScoped<SupplierService>();
                services.AddScoped<ProductService>();
                services.AddScoped<CustomerService>();
                services.AddScoped<AccountService>();
                services.AddScoped<SaleServices>();
                // CONEXIÓN
                services.AddSingleton<SqlConnect>();
            });
    }
}
