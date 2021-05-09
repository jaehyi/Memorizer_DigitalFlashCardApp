using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Memorizer.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Category")]
        public string Name { get; set; }

        [DisplayName("Description")]
        public string Desc { get; set; }

        [DisplayName("Flash Cards")]
        public ICollection<FlashCard> FlashCards { get; set; }
    }
}
