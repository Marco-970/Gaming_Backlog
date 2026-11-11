namespace Gaming_Backlog.Tools
{
    public interface IGameValidator
    {
        string ValidateTitle(string input);
        public int? ValidateYear(int? input);
    }
}