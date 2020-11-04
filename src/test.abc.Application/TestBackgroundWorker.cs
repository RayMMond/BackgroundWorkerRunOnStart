using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Threading;

namespace test.abc
{
    public class TestBackgroundWorker : AsyncPeriodicBackgroundWorkerBase
    {
        public TestBackgroundWorker(AbpTimer timer, IServiceScopeFactory serviceScopeFactory) : base(timer, serviceScopeFactory)
        {
            Timer.RunOnStart = true;
        }

        protected override async Task DoWorkAsync(PeriodicBackgroundWorkerContext workerContext)
        {
            Debug.WriteLine($"Doing some work here");
            await Task.Delay(5000);
        }
    }
}