namespace Gaming_Backlog.Models
{
    public class GamesModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? ReleaseYear { get; set; }
        public int Interest { get; set; }
        public DateTime Added { get; set; }

        public List<GenresModel> Genres { get; set; } = new();
    }
}
