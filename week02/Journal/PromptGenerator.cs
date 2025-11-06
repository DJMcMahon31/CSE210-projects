//Supplies random prompts whenever requested

//Behaviours needed to support prompt generation:
//-Provide a random prompt (GetRandomPrompt(): string)

//Attributes needed to support prompt generation:
//_prompts: List<string>
//.................
//GetRandomPrompt(): string


using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "Describe a challenge you faced recently.",
        "What is a goal you have for the next week?",
        "Write about someone who inspires you.",
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"

    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

}
