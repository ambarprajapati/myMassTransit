namespace MassTransit.NinjectIntegration
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using Saga;

    //AMBAR Git TEST 10/30/2019
    public class SagaRegistry :
        ISagaRegistry
    {
        readonly ConcurrentDictionary<Type, ICachedConfigurator> _configurators = new ConcurrentDictionary<Type, ICachedConfigurator>();

        public ICachedConfigurator Add<T>()
            where T : class, ISaga
        {
            return _configurators.GetOrAdd(typeof(T), _ => new SagaCachedConfigurator<T>());
        }

        public ICachedConfigurator Add(Type sagaType)
        {
            return _configurators.GetOrAdd(sagaType,
                _ => (ICachedConfigurator)Activator.CreateInstance(typeof(SagaCachedConfigurator<>).MakeGenericType(sagaType)));
        }

        public IEnumerable<ICachedConfigurator> GetConfigurators()
        {
            return _configurators.Values.ToList();
        }
    }
}
