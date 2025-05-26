using System.ComponentModel.DataAnnotations;

namespace BookStoreWebAppFE.Models
{
    public  class Category
    {
        [Required(ErrorMessage = "Không Được Để Trống !")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Không Được Để Trống !")]

        public string Name { get; set; } = null!;

        public bool IsDeleted { get; set; }

    }
}
