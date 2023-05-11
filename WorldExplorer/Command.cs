namespace WorldExplorer;

public class Command
{
    private string CommandText { get; }
    private string[] SplitText => CommandText.Split(' ');

    private Command(string text)
    {
        CommandText = text;
    }
    
    public static Command GetCommand()
    {
        var text = Console.ReadLine();
        if (text != null) return new Command(text);
        throw new NullReferenceException();
    }

    public string GetFirstWord()
    {
        return SplitText[0];
    }

    public string GetSecondWord()
    {
        return SplitText[1];
    }
}