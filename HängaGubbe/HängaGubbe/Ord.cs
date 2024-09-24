namespace HängaGubbe;

public class Ord
{
    public string Word { get; set; }
    public int WordLength { get; set; }

    public Ord(string word)
    {
        Word = word;
        WordLength = word.Length;
    }

    public char[] SplitWord()
    {
        return Word.ToCharArray();
    }
    
}