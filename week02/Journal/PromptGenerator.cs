public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "What was the strongest emotion I felt today?",
        "What did I learn today?",
        "What is something I am grateful for today?",
        "What is one thing I could do better tomorrow?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}
