using System.ComponentModel.DataAnnotations;

namespace SecondMVCApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz wpisać tytuł")]
        [MinLength(length: 3)]
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }

        public string Author { get; set; }

        public bool IsAvailable { get; set; }
    }
}
