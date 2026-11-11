namespace Gaming_Backlog.Tools
{
    public class GameValidator : IGameValidator
    {
        public string ValidateTitle(string input)
        {
            return input;
        }
        public int? ValidateYear(int? input)
        {
            if (input == null) return null;
            return input.ToString().Length == 4 ? input : null;
        }
    }
}
