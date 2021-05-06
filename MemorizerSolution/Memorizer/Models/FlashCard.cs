using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Memorizer.Models
{
    public class FlashCard
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Question { get; set; }
        [Required]
        public string Answer { get; set; }
        [DisplayName("Created On")]
        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; }
        [DisplayName("Updated On")]
        [DataType(DataType.Date)]
        public DateTime UpdatedOn { get; set; }
        public string Note { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        //public int FlashCardFk { get; set; }
        
    }
}
