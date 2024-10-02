public class Prompt
{
    List<string> _prompts = new List<string>()
    {
        "What is something you've been doing lately that you're proud of?",
        "Who is the most interesting person you spoke with today?",
        "How did you see the Lord's hand in your life today?",
        "What's something that's been stressing you out lately?",
        "How are you getting closet to the person you want to become?"
    };

    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        
        return _prompts[index];
    }
}