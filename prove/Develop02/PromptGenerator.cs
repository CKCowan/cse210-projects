
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public string GetRandomPrompt(){
        CreatePromptList();
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public void CreatePromptList(){
        _prompts.Add("If you could change one thing about today, what would it be?");
        _prompts.Add("How did you sleep last night?");
        _prompts.Add("What is one thing new you learned today?");
    }
}