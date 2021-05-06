using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Memorizer.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        // [ForeignKey("FlashCardFk")]
        public ICollection<FlashCard> FlashCards { get; set; }
    }
}
