namespace AspNetCoreDependencyInjectionAndServiceLifetimes.ServiceAbstractions
{
    public interface ITestService2
    {
        public string Get_SubServiceWithScopedLifetime_Value();
        public string Get_SubServiceWithSingletonLifetime_Value();
        public string Get_SubServiceWithTransientLifetime_Value();
    }
}
