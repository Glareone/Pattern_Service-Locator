using System;
using System.Collections.Generic;

namespace ServiceLocator
{
    public static class ServiceLocator
    {
        /// <summary>
        /// The services
        /// </summary>
        public static readonly Dictionary<Type, Type> services = new Dictionary<Type, Type>();

        /// <summary>
        /// Registers the service.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="service">The service.</param>
        public static void RegisterService<T>(Type service)
        {
            services[typeof(T)] = service;
        }

        /// <summary>
        /// Resolves this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {
            return (T)Activator.CreateInstance(services[typeof(T)]);
        }
    }

}
