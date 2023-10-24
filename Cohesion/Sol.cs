namespace Cohesion
{
    public class Sol
    {
        private string userInteraction;
        private string[] perspective; // Array to store observations

        public Sol()
        {
            Console.Write("Enter your input: ");
            userInteraction = Console.ReadLine();
            Agent agentofSol = new Agent(userInteraction);

            // Subscribe to the Agent's event to know when the assistants are ready
            agentofSol.AssistantsReady += OnAssistantsReady;
        }

        private void OnAssistantsReady(object sender, EventArgs e)
        {
            // The event handler is called when the assistants are ready

            // Now you can call the Moon to populate the perspective
            perspective = Moon();

            // Set synkronisity to false after a successful event
            Program.Synkronisity = false;

            // Perform any additional actions after obtaining the perspective
            DoSomethingWithObservation();
        }

        private string[] Moon()
        {
            string[] eloquenceObservation = File.ReadAllLines("eloquence.txt");
            string[] graceObservation = File.ReadAllLines("grace.txt");

            // Combine eloquenceObservation and graceObservation into a single array
            string[] combinedObservations = new string[] { eloquenceObservation[0], graceObservation[0] };

            return combinedObservations;
        }

        public void DoSomethingWithObservation()
        {
            // You can access the observation arrays through the perspective object.
            string eloquenceObservation = perspective[0]; // Access Eloquence observation
            string graceObservation = perspective[1]; // Access Grace observation

            // Perform operations with the observation data as needed.
        }
    }
}