# P3k.FeaturesDependencyInstaller

A simple abstraction for feature-based dependency injection registration. This package provides interfaces and base classes for creating modular feature installers.

## Installation

Add via git url in Unity Package Manager or add manually to your Unity project's `manifest.json`:

```json
{
  "dependencies": {
    "com.p3k.featuresdependencyinstaller": "https://github.com/p3k22/FeaturesDependencyInstaller.git"
  }
}
```

**Option 2:** Copy the runtime folder into your project. If you're using assembly definitions, add a reference to the package asmdef. If not using asmdefs, delete the included asmdef file.


## Usage

Create a feature installer by inheriting from `FeatureInstallerBase`:

```csharp
public class UserManagementInstaller : FeatureInstallerBase
{
    public override void Install(IFeatureServicesRegistrar registrar)
    {
        registrar.RegisterTransient<IUserService, UserService>();
        registrar.RegisterSingleton<IUserRepository, UserRepository>();
    }
}
```

## Available Registration Methods

- `RegisterSingleton<TService, TImplementation>()` - Single instance for app lifetime
- `RegisterSingleton<TService>(instance)` - Pre-created instance
- `RegisterSingleton<TService>(factory)` - Factory-created singleton
- `RegisterTransient<TService, TImplementation>()` - New instance each time
- `RegisterTransient<TService>(factory)` - Factory-created transient

## Key Interfaces

- `IFeatureInstaller` - Contract for feature installers
- `IFeatureServicesRegistrar` - Abstraction for service registration

This package is designed to work with P3k.FeaturesDependencyInjector (https://github.com/p3k22/FeaturesDependencyInjector.git) that will discover and execute feature installers automatically.