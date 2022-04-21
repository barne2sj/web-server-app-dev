using System.ComponentModel.DataAnnotations;
namespace FinalProject.Models
{
    public class Hobby
    {
        public int HobbyId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string? HobbyName { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string? HobbyDescription { get; set; }
    }
}