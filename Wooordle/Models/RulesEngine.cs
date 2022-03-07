namespace Models
{
    public class RulesEngine: IRulesEngine
    {
        public RulesEngine()
        {
        }

        public bool WordIsValid(string v, out string message)
        {
            message = string.Empty;
            return true;
        }
    }
}