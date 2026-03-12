public class PromptGenerator()
    {
        public List<string> _prompts = new List<string>()
        {
        "What made you smile today?",
        "What challenged you today?",
        "What did you learn today?",
        "Who helped you today?"
        };

        public string GetRandomPrompt()
        {
            Random rand = new Random();
            int index = rand.Next(_prompts.Count);
            return _prompts[index];
        }
    }