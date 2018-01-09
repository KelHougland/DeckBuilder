using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeckBuilder.ViewModels
{
    public class AddDeckViewModel
    {
        [Required]
        [Display(Name = "Deck Name")]
        public string Name { get; set; }
    }
}
