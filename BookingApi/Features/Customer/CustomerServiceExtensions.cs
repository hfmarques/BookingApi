using BookingApi.Features.Customer.Commands;
using BookingApi.Features.Customer.Queries;

namespace BookingApi.Features.Customer
{
    public static class CustomerServiceExtensions
    {
        public static IServiceCollection AddServicesFromCustomer(this IServiceCollection services)
        {
            services.AddTransient<GetCustomers>();
            services.AddTransient<GetCustomerById>();
            services.AddTransient<CreateCustomer>();
            return services;
        }
    }
}