using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Uplift.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Category Name")]
        public string? Name { get; set; }

        [Required]
        [Display(Name="Display Order")]
        public int DisplayOrder { get; set; }
    }
}
