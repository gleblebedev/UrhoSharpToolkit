using System;
using System.Reactive.Concurrency;
using System.Threading.Tasks;

namespace UrhoSharp.Rx
{
    public static class ExtensionMethods
    {
        public static Task<T> RunAsync<T>(this IScheduler scheduler, Func<T> action)
        {
            var tcs = new TaskCompletionSource<T>();
            scheduler.Schedule(() =>
            {
                var result = action();
                Task.Factory.StartNew(() => tcs.SetResult(result));
            });
            return tcs.Task;
        }

        public static Task RunAsync(this IScheduler scheduler, Action action)
        {
            var tcs = new TaskCompletionSource<bool>();
            scheduler.Schedule(() =>
            {
                action();
                Task.Factory.StartNew(() => tcs.SetResult(true));
            });
            return tcs.Task;
        }
    }
}