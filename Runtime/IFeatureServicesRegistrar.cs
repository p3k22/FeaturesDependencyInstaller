namespace P3k.FeaturesDependencyInstaller
{
   using System;
   using System.Linq;

   /// <summary>
   ///    Abstraction over dependency registration for features.
   ///    Provides limited methods for declaring dependencies
   ///    without exposing the underlying container implementation.
   /// </summary>
   public interface IFeatureServicesRegistrar
   {
      /// <summary>
      ///    Registers a singleton service where the service type is the same as the implementation type.
      ///    The same instance will be shared across the application lifetime.
      /// </summary>
      /// <param name="serviceType">The type to register as both service and implementation.</param>
      void RegisterSingleton(Type serviceType);

      /// <summary>
      ///    Registers a singleton service mapping.
      ///    The same instance will be shared across the application lifetime.
      /// </summary>
      void RegisterSingleton<TService, TImplementation>()
         where TService : class where TImplementation : class, TService;

      /// <summary>
      ///    Registers a pre-created singleton instance.
      /// </summary>
      void RegisterSingleton<TService>(TService instance)
         where TService : class;

      /// <summary>
      ///    Registers a singleton service using a factory delegate.
      /// </summary>
      void RegisterSingleton<TService>(Func<IServiceProvider, TService> factory)
         where TService : class;

      /// <summary>
      ///    Registers a transient service where the service type is the same as the implementation type.
      ///    A new instance will be created every time it is requested.
      /// </summary>
      /// <param name="serviceType">The type to register as both service and implementation.</param>
      void RegisterTransient(Type serviceType);

      /// <summary>
      ///    Registers a transient service mapping.
      ///    A new instance will be created every time it is requested.
      /// </summary>
      void RegisterTransient<TService, TImplementation>()
         where TService : class where TImplementation : class, TService;

      /// <summary>
      ///    Registers a transient service mapping using a factory delegate.
      /// </summary>
      void RegisterTransient<TService>(Func<IServiceProvider, TService> factory)
         where TService : class;
   }
}