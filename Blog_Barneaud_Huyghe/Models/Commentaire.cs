using System;
using System.ComponentModel.DataAnnotations;

namespace Blog_Barneaud_Huyghe.Models
{
    public class Commentaire
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ArticleId { get; set; }

        [Required]
        public int IndividuId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(128)]
        [DataType(DataType.Text)]
        public string Message { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Publication { get; set; }
    }
}