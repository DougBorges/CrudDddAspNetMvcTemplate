using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DI;

public static class Initializer
{
    public static void Configure(this IServiceCollection services, string conection)
    {
        services.AddDbContext<AppDbContext>(options => options.UseSqlite(conection));

        services.AddScoped<IRepository<Contact>, ContactRepository>();
        services.AddScoped<IContactService, ContactService>();
    }
}