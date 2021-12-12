using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Barneaud_Huyghe.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int IndividuId { get; set; }

        public virtual Individu ArticleIndividuId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(128)]
        [DataType(DataType.Text)]
        public string Titre { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.MultilineText)]
        public string Contenu { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Publication { get; set; }
    }
}
