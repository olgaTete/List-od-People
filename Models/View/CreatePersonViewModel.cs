using System.ComponentModel.DataAnnotations;
namespace ListOfPeople.Models.View
{
    public class CreatePersonViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string City { get; set; }
    }
}
