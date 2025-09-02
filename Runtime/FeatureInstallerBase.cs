namespace P3k.FeaturesDependencyInstaller
{
   using System.Linq;

   /// <summary>
   ///    Base class for feature-specific dependency injection installers.
   ///    Inherit from this class to create installers that register all services
   ///    and dependencies required by a specific feature or module.
   /// </summary>
   /*
   To use:
       1. Create a class that inherits from FeatureInstallerBase
       2. Override Install() method
       3. Use the provided registrar to register your feature's services
       4. The P3k Features Dependency Injector will automatically discover
          and execute your installer during application startup

    Example:
    public class UserManagementInstaller : FeatureInstallerBase
    {
        public override void Install(IFeatureServicesRegistrar registrar)
        {
            registrar.RegisterTransient;IUserService, UserService&gt;();
            registrar.RegisterSingleton<IUserRepository, UserRepository>();
        }
    }
    */
   public abstract class FeatureInstallerBase : IFeatureInstaller
   {
      /// <summary>
      ///    Register your feature's services and dependencies for dependency injection.
      /// </summary>
      /// <param name="registrar">
      ///    Service registrar that provides methods to register
      ///    singleton and transient services with the dependency injection container.
      /// </param>
      public abstract void Install(IFeatureServicesRegistrar registrar);
   }
}
