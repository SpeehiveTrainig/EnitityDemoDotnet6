using EnitityDemo.Utils;

namespace EnitityDemo
{
    public static class ServiceRegister
    {
        public static void Register(WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton<IHelper, Helper>();
            builder.Services.AddTransient<IHelper, Helper>();
        }

    }
}
