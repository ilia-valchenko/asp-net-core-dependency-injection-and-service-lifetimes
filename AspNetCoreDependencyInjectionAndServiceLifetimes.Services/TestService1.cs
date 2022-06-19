using AspNetCoreDependencyInjectionAndServiceLifetimes.ServiceAbstractions;

namespace AspNetCoreDependencyInjectionAndServiceLifetimes.Services
{
    public class TestService1 : ITestService1
    {
        private readonly ITestService2 testService2;
        private readonly ISubServiceWithScopedLifetime subServiceWithScopedLifetime;
        private readonly ISubServiceWithSingletonLifetime subServiceWithSingletonLifetime;
        private readonly ISubServiceWithTransientLifetime subServiceWithTransientLifetime;

        public TestService1(
            ITestService2 testService2,
            ISubServiceWithScopedLifetime subServiceWithScopedLifetime,
            ISubServiceWithSingletonLifetime subServiceWithSingletonLifetime,
            ISubServiceWithTransientLifetime subServiceWithTransientLifetime)
        {
            this.testService2 = testService2;
            this.subServiceWithScopedLifetime = subServiceWithScopedLifetime;
            this.subServiceWithSingletonLifetime = subServiceWithSingletonLifetime;
            this.subServiceWithTransientLifetime = subServiceWithTransientLifetime;
        }

        public string Get_TestService1_SubServiceWithScopedLifetime_Value()
        {
            return subServiceWithScopedLifetime.Value;
        }

        public string Get_TestService1_SubServiceWithSingletonLifetime_Value()
        {
            return subServiceWithSingletonLifetime.Value;
        }

        public string Get_TestService1_SubServiceWithTransientLifetime_Value()
        {
            return subServiceWithTransientLifetime.Value;
        }

        #region SubTestService2
        public string Get_TestService1_SubTestService2_SubServiceWithScopedLifetime_Value()
        {
            return testService2.Get_SubServiceWithScopedLifetime_Value();
        }

        public string Get_TestService1_SubTestService2_SubServiceWithSingletonLifetime_Value()
        {
            return testService2.Get_SubServiceWithSingletonLifetime_Value();
        }

        public string Get_TestService1_SubTestService2_SubServiceWithTransientLifetime_Value()
        {
            return testService2.Get_SubServiceWithTransientLifetime_Value();
        } 
        #endregion
    }
}
