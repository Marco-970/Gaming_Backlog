using System.ComponentModel.DataAnnotations;

namespace Gaming_Backlog.Models
{
    public class BacklogModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You must enter a title.")]
        [StringLength(100, ErrorMessage = "Title length cannot exceed 100 characters.")]
        public string Title { get; set; } = "";
        public string Genres { get; set; } = "";
        public int Interest { get; set; }
    }
}
