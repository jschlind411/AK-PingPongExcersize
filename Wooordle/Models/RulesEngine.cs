namespace Models
{
    public class RulesEngine: IRulesEngine
    {
        public RulesEngine()
        {
        }

        public string CompareWords(string actualWord, string guessWord)
        {
            throw new System.NotImplementedException();
        }

        public bool WordIsValid(string v, out string message)
        {
            message = string.Empty;
            return true;
        }
    }
}