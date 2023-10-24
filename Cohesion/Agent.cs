using System;

namespace Cohesion
{
    public class Agent
    {
        public event EventHandler AssistantsReady;

        public Agent(string interaction)
        {
            // Initialize the Eloquence and Grace assistants with the interaction string
            Assistant eloquence = new Assistant(interaction, false); // false for Eloquence
            Assistant grace = new Assistant(interaction, true); // true for Grace

            // Set synkronisity to true before triggering the AssistantsReady event
            Program.Synkronisity = true;

            // Trigger the AssistantsReady event to signal that the assistants are done
            OnAssistantsReady();
        }

        protected virtual void OnAssistantsReady()
        {
            AssistantsReady?.Invoke(this, EventArgs.Empty);
        }
    }
}