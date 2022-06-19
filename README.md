# asp-net-core-dependency-injection-and-service-lifetimes

## Singleton
A DI container will hold only one instance. It will be the same instance until the application stops.

## Transient
A new instance will be created each time it's invoked.

## Scoped
The same instance will be used across the current request.