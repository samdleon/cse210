public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public string GetResponse(string prompt)
    {
        Console.WriteLine($"{prompt}\n >");
        return Console.ReadLine();
  



    }

    public void ShowResponse()
    {
        // Date: [date] - Prompt: [prompt] \n [response]
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_response}\n");
    }



}