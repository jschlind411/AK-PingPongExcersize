namespace Models
{
    public interface IRulesEngine
    {
        bool WordIsValid(string v, out string message);
    }
}