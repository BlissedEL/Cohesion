using Cohesion.Abstractions.Cohesion;

namespace Cohesion
{
    class Program
    {
        public static bool Synkronisity = true;

        public static async Task Main(string[] args)
        {
            Task monitorKeyPressTask = Abstractions.Method.MonitorKeyPressAsync();
            // Pressed keys are registered from here...

            Depend.Interject();

            // ...to here.
            await monitorKeyPressTask;
        }
    }
}