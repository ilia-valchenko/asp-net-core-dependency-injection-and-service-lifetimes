using AspNetCoreDependencyInjectionAndServiceLifetimes.ServiceAbstractions;

namespace AspNetCoreDependencyInjectionAndServiceLifetimes.Services
{
    public class SubServiceWithTransientLifetime : ISubServiceWithTransientLifetime
    {
        public string Value { get; set; } = $"SubServiceWithTransientLifetime_{Guid.NewGuid().ToString()}";
    }
}
