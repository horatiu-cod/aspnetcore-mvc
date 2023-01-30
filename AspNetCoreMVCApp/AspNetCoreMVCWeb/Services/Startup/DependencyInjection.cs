using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMVCWeb.Services.Startup;

public static class DependencyInjection
{
    public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(
            builder.Configuration.GetConnectionString("DefaultConnetion")
            ));
        builder.Services.AddRazorPages();

        return builder;
    }
}
