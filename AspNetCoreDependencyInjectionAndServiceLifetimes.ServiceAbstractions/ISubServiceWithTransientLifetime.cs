namespace AspNetCoreDependencyInjectionAndServiceLifetimes.ServiceAbstractions
{
    public interface ISubServiceWithTransientLifetime
    {
        public string Value { get; set; }
    }
}
