using System.ComponentModel.DataAnnotations;

public class Prompts
{
    
    public List<string> _promptList = new List<string>();


    public string RandomizePrompt()
    {

        int i;
        Random randomGenerator = new Random();
        i = randomGenerator.Next(0, _promptList.Count);
        return _promptList[i];

    }

    public void AddPrompt()
    {
        // do I even want this? or should I just get rid of this feature?
    }

}