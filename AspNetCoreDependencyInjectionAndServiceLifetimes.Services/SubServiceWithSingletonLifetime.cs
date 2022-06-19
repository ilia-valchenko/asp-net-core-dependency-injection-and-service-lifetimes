using AspNetCoreDependencyInjectionAndServiceLifetimes.ServiceAbstractions;

namespace AspNetCoreDependencyInjectionAndServiceLifetimes.Services
{
    public class SubServiceWithSingletonLifetime : ISubServiceWithSingletonLifetime
    {
        public string Value { get; set; } = $"SubServiceWithSingletonLifetime_{Guid.NewGuid().ToString()}";
    }
}
