namespace Models
{
    public interface IRulesEngine
    {
        bool ValidateWord(string word);
        string CompareWords(string actualWord, string guessWord);
    }
}