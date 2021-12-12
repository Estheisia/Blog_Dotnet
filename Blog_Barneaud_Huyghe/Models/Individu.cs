using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Barneaud_Huyghe.Models
{
    public class Individu
    {
        [Key]
        public int IndividuId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(128)]
        [RegularExpression(@"^[^,\.\^]+$")]
        [DataType(DataType.Text)]
        public string Identifiant { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(128)]
        [DataType(DataType.Text)]
        public string Motdepasse { get; set; }

        [Required]
        public bool EstBloggeur { get; set; }
    }
}
