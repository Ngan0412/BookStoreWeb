using System.ComponentModel.DataAnnotations;
using BookStoreWebAppFE.Components.Helper;

namespace BookStoreWebAppFE.Models
{
    public  class Book
    {
        public Guid id { get; set; }
        [Required(ErrorMessage = "Không Được Để Trống!")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "Phải nhập 13 ký tự!")]
        public string Isbn { get; set; } = null!;
        [Required(ErrorMessage =  "Không Được Để Trống !")]
        [StringLength(200)]
        public string Title { get; set; }
        [GuidNotEmpty(ErrorMessage = "Không Được Để Trống!")]

        public Guid categoryId { get; set; }
        [GuidNotEmpty(ErrorMessage = "Không Được Để Trống!")]

        public Guid authorId { get; set; }
        [GuidNotEmpty(ErrorMessage = "Không Được Để Trống!")]

        public Guid publisherId { get; set; }
        [Required(ErrorMessage = "Không Được Để Trống !")]

        public int YearOfPublication { get; set; }
        [Required(ErrorMessage = "Không Được Để Trống !")]

        public int Quantity { get; set; }
        [Required(ErrorMessage = "Không Được Để Trống !")]

        public string Image { get; set; }
        [Required(ErrorMessage = "Không Được Để Trống !")]

        public decimal Price { get; set; }
        [Required(ErrorMessage =  "Không Được Để Trống !")]
        public bool isDeleted { get; set; }

    }
}
