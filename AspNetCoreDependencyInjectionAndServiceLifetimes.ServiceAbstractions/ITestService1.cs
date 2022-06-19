namespace AspNetCoreDependencyInjectionAndServiceLifetimes.ServiceAbstractions
{
    public interface ITestService1
    {
        public string Get_TestService1_SubServiceWithScopedLifetime_Value();
        public string Get_TestService1_SubServiceWithSingletonLifetime_Value();
        public string Get_TestService1_SubServiceWithTransientLifetime_Value();
        public string Get_TestService1_SubTestService2_SubServiceWithScopedLifetime_Value();
        public string Get_TestService1_SubTestService2_SubServiceWithSingletonLifetime_Value();
        public string Get_TestService1_SubTestService2_SubServiceWithTransientLifetime_Value();

    }
}