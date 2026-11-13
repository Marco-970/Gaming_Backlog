using System.ComponentModel.DataAnnotations;

namespace Gaming_Backlog.Models
{
    public class GamesModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You must enter a title.")]
        [StringLength(100, ErrorMessage = "Title length cannot exceed 100 characters.")]
        public string Title { get; set; }
        [Range(1970, 2100, ErrorMessage = "Year must be between 1970 and 2100")]
        public int? ReleaseYear { get; set; }
        public int Interest { get; set; }
        public DateTime Added { get; set; }

        public List<GenresModel> Genres { get; set; } = new();
    }
}
