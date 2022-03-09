namespace Models
{
    public interface IRulesEngine
    {
        bool WordIsValid(string word, out string message);
        string CompareWords(string actualWord, string guessWord);
    }
}