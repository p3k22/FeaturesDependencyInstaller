namespace P3k.FeaturesDependencyInstaller
{
   using System.Linq;

   /// <summary>
   /// Defines a contract for feature modules that can register their dependencies
   /// with the application's dependency injection system.
   /// </summary>
   public interface IFeatureInstaller
   {
      /// <summary>
      /// Called during application startup to register feature services.
      /// </summary>
      /// <param name="registrar">The service registrar used to register dependencies.</param>
      void Install(IFeatureServicesRegistrar registrar);
   }
}
