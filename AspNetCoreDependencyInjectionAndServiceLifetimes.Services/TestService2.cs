using AspNetCoreDependencyInjectionAndServiceLifetimes.ServiceAbstractions;

namespace AspNetCoreDependencyInjectionAndServiceLifetimes.Services
{
    public class TestService2 : ITestService2
    {
        private readonly ISubServiceWithScopedLifetime subServiceWithScopedLifetime;
        private readonly ISubServiceWithSingletonLifetime subServiceWithSingletonLifetime;
        private readonly ISubServiceWithTransientLifetime subServiceWithTransientLifetime;

        public TestService2(
            ISubServiceWithScopedLifetime subServiceWithScopedLifetime,
            ISubServiceWithSingletonLifetime subServiceWithSingletonLifetime,
            ISubServiceWithTransientLifetime subServiceWithTransientLifetime)
        {
            this.subServiceWithScopedLifetime = subServiceWithScopedLifetime;
            this.subServiceWithSingletonLifetime = subServiceWithSingletonLifetime;
            this.subServiceWithTransientLifetime = subServiceWithTransientLifetime;
        }

        public string Get_SubServiceWithScopedLifetime_Value()
        {
            return subServiceWithScopedLifetime.Value;
        }

        public string Get_SubServiceWithSingletonLifetime_Value()
        {
            return subServiceWithSingletonLifetime.Value;
        }

        public string Get_SubServiceWithTransientLifetime_Value()
        {
            return subServiceWithTransientLifetime.Value;
        }
    }
}