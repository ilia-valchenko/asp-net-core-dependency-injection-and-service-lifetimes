using AspNetCoreDependencyInjectionAndServiceLifetimes.Models;
using AspNetCoreDependencyInjectionAndServiceLifetimes.ServiceAbstractions;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDependencyInjectionAndServiceLifetimes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ITestService1 testService1;
        private readonly ILogger<TestController> _logger;

        public TestController(
            ITestService1 testService1,
            ILogger<TestController> logger)
        {
            this.testService1 = testService1;
            _logger = logger;
        }

        [HttpGet("Get1")]
        public TestResult Get1()
        {
            return new TestResult
            {
                TestService1_SubServiceWithScopedLifetime_Value = this.testService1.Get_TestService1_SubServiceWithScopedLifetime_Value(),
                TestService1_SubServiceWithSingletonLifetime_Value = this.testService1.Get_TestService1_SubServiceWithSingletonLifetime_Value(),
                TestService1_SubServiceWithTransientLifetime_Value = this.testService1.Get_TestService1_SubServiceWithTransientLifetime_Value(),
                TestService1_SubTestService2_SubServiceWithScopedLifetime_Value = this.testService1.Get_TestService1_SubTestService2_SubServiceWithScopedLifetime_Value(),
                TestService1_SubTestService2_SubServiceWithSingletonLifetime_Value = this.testService1.Get_TestService1_SubTestService2_SubServiceWithSingletonLifetime_Value(),
                TestService1_SubTestService2_SubServiceWithTransientLifetime_Value = this.testService1.Get_TestService1_SubTestService2_SubServiceWithTransientLifetime_Value()
            };
        }

        [HttpGet("Get2")]
        public TestResult Get2()
        {
            return new TestResult
            {
                TestService1_SubServiceWithScopedLifetime_Value = this.testService1.Get_TestService1_SubServiceWithScopedLifetime_Value(),
                TestService1_SubServiceWithSingletonLifetime_Value = this.testService1.Get_TestService1_SubServiceWithSingletonLifetime_Value(),
                TestService1_SubServiceWithTransientLifetime_Value = this.testService1.Get_TestService1_SubServiceWithTransientLifetime_Value(),
                TestService1_SubTestService2_SubServiceWithScopedLifetime_Value = this.testService1.Get_TestService1_SubTestService2_SubServiceWithScopedLifetime_Value(),
                TestService1_SubTestService2_SubServiceWithSingletonLifetime_Value = this.testService1.Get_TestService1_SubTestService2_SubServiceWithSingletonLifetime_Value(),
                TestService1_SubTestService2_SubServiceWithTransientLifetime_Value = this.testService1.Get_TestService1_SubTestService2_SubServiceWithTransientLifetime_Value()
            };
        }
    }
}