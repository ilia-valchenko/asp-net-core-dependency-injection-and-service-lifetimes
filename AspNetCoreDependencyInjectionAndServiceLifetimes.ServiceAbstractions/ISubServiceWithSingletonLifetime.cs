namespace AspNetCoreDependencyInjectionAndServiceLifetimes.ServiceAbstractions
{
    public interface ISubServiceWithSingletonLifetime
    {
        public string Value { get; set; }
    }
}
