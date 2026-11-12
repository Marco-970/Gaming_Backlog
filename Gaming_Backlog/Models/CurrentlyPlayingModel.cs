namespace Gaming_Backlog.Models
{
    public class CurrentlyPlayingModel
    {
            public string Title { get; set; }
            public DateTime Added { get; set; }
            public DateTime Started { get; set; } = DateTime.Today;
    }
}
