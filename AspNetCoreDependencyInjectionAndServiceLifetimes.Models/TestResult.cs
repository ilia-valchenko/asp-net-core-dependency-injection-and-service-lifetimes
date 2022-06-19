namespace AspNetCoreDependencyInjectionAndServiceLifetimes.Models
{
    public class TestResult
    {
        public string TestService1_SubServiceWithScopedLifetime_Value { get; set; }
        public string TestService1_SubServiceWithSingletonLifetime_Value { get; set; }
        public string TestService1_SubServiceWithTransientLifetime_Value { get; set; }


        public string TestService1_SubTestService2_SubServiceWithScopedLifetime_Value { get; set; }
        public string TestService1_SubTestService2_SubServiceWithSingletonLifetime_Value { get; set; }
        public string TestService1_SubTestService2_SubServiceWithTransientLifetime_Value { get; set; }
    }
}