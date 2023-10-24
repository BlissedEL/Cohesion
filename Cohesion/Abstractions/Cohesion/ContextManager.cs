using Cohesion.Abstractions.Cohesion;

public class ContextManager
{
    private readonly Dictionary<string, IDepend> _actions;

    public ContextManager(Dictionary<string, IDepend> actions)
    {
        _actions = actions;
    }

    public void ExecuteAction(string context)
    {
        if (_actions.ContainsKey(context))
        {
            _actions[context].Execute();
        }
        else
        {
            Console.WriteLine("Context not found");
        }
    }
}