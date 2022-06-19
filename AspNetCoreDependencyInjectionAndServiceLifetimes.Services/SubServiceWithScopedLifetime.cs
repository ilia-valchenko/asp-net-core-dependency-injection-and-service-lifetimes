using AspNetCoreDependencyInjectionAndServiceLifetimes.ServiceAbstractions;

namespace AspNetCoreDependencyInjectionAndServiceLifetimes.Services
{
    public class SubServiceWithScopedLifetime : ISubServiceWithScopedLifetime
    {
        public string Value { get; set; } = $"SubServiceWithScopedLifetime_{Guid.NewGuid().ToString()}";
    }
}
