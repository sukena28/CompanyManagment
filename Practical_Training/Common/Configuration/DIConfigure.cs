using Practical_Training.Repositories;
using Practical_Training.Service;
using Practical_Training.Service.Notification.Concrete;
using Practical_Training.Services;

namespace Practical_Training.Configuration
{
    public static class DIConfigure
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //Register services
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderService, OrderService>();

            //Register List
            services.AddScoped<INotificationService, EmailNotificationService>();
            services.AddScoped<INotificationService, TextNotificationService>();
            services.AddScoped<INotificationService, CloudNotificationService>();


            return services;
        }
    }
}
