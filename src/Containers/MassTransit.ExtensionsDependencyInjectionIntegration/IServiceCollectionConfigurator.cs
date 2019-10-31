namespace MassTransit.ExtensionsDependencyInjectionIntegration
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    //AMBAR Git TEST 10/30/2019
    public interface IServiceCollectionConfigurator :
        IRegistrationConfigurator
    {
        IServiceCollection Collection { get; }

        /// <summary>
        /// Add the bus to the container, configured properly
        /// </summary>
        /// <param name="busFactory"></param>
        void AddBus(Func<IServiceProvider, IBusControl> busFactory);
    }
}
