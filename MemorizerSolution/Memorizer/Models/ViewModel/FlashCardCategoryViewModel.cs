using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memorizer.Models.ViewModel
{
    public class FlashCardCategoryViewModel
    {
        public FlashCard FlashCard { get; set; }
        public List<Category> Categories { get; set; }
    }
}
