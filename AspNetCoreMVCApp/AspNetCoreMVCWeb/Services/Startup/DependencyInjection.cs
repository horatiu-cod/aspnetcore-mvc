namespace AspNetCoreMVCWeb.Services.Startup;

public static class DependencyInjection
{
    public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllersWithViews();

        return builder;
    }
}
