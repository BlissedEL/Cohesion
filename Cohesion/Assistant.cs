using System;
using System.IO;
using ChatGPT.Net;

namespace Cohesion
{
    public class Assistant
    {
        private readonly string apiKey;
        private readonly bool perspective; // bool representing Eloquence (true) or Grace (false)

        public Assistant(string interaction, bool perspective)
        {
            // Initialize the perspective (Eloquence or Grace)
            this.perspective = perspective;

            // Read or create the API key
            string apiKeyFilePath = "api_key.txt";
            if (File.Exists(apiKeyFilePath))
            {
                apiKey = File.ReadAllText(apiKeyFilePath);
            }
            else
            {
                Console.Write("Enter your API key: ");
                apiKey = Console.ReadLine();
                File.WriteAllText(apiKeyFilePath, apiKey);
            }
        }

        public async Task<string> Ask(string message)
        {
            // Initialize ChatGPT with the API key
            var bot = new ChatGpt(apiKey);

            // Get a response
            var response = await bot.Ask(message);

            // Store the response in the corresponding text file
            string responseFilePath = perspective ? "eloquence_response.txt" : "grace_response.txt";
            File.WriteAllText(responseFilePath, response);

            return response;
        }
    }
}