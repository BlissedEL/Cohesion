using static Cohesion.Abstractions.Cohesion.Interjections;

namespace Cohesion.Abstractions.Cohesion
{
    internal class Depend
    {
        static internal void Interject()
        {
            // DI Container setup
            var actions = new Dictionary<string, IDepend>
            {
                { "Sol", new SolActivation() },
                { "Eloquence", new OutputEloquence() },
                { "Grace", new OutputEloquence() },
                { "Bless", new OutputEloquence() },
                { "Exit", new OutputEloquence() },
                { "DeleteAPIkey", new OutputEloquence() },
                { "ResetDiscourse", new OutputEloquence() }
            };

            var contextManager = new ContextManager(actions);

            // Dynamic switching examples based on context
            contextManager.ExecuteAction("Eloquence"); // Output: "Executing Action A"
            contextManager.ExecuteAction("Grace"); // Output: "Executing Action B"
        }
    }
}
