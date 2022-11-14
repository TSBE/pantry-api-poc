﻿using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pantry.Features.WebFeature.Commands;
using Pantry.Features.WebFeature.Configuration;
using Pantry.Features.WebFeature.Queries;
using Pantry.Features.WebFeature.V1.Controllers;
using Silverback.Messaging.Configuration;

namespace Pantry.Features.WebFeature;

/// <summary>
///     Registers the WebFeature.
///     - Offer a REST-API for the entity.
///     - Use Queries and Commands to provide the entity CRUD functionality.
///     - Use Entity Framework to persist the entity.
/// </summary>
public static class Registrar
{
    public static void AddWebFeature(this IServiceCollection services, IConfiguration configuration)
    {
        // Controllers
        services.AddScoped<DeviceController>();

        // Other requirements
        services.AddFluentValidationAutoValidation(_ =>
        {
            ValidatorOptions.Global.LanguageManager.Enabled = false;
        }).AddFluentValidationClientsideAdapters();
        services.AddValidatorsFromAssembly(typeof(Registrar).Assembly, ServiceLifetime.Scoped);
        services.Configure<WebFeatureConfiguration>(configuration.GetRequiredSection(WebFeatureConfiguration.Name));
        //services.AddTransient<IAuthorizationHandler, FlowidAuthorizationHandler>();

        ISilverbackBuilder silverbackBuilder = services.ConfigureSilverback();

        // CommandHandlers
        silverbackBuilder
            .AddScopedSubscriber<CreateDeviceCommandHandler>()
            ;

        // QueryHandlers
        silverbackBuilder
            .AddScopedSubscriber<DeviceByIdQueryHandler>()
            .AddScopedSubscriber<DeviceListQueryHandler>()
            ;
    }
}
