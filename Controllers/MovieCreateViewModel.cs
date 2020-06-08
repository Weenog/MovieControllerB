using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Controllers
{
    public class MovieCreateViewModel
    {
        [DisplayName("Titel")]
        [Required(AllowEmptyStrings = false, ErrorMessage= "Titel Is verplicht")]
        [MaxLength(20, ErrorMessage = "Maximum 20 Karakters!")]
        public string Title { get; internal set; }

        [DisplayName("Omschrijving")]
        public string Description { get;  set; }

        [DisplayName("Genre")]
        public string Genre { get; set; }
      

        [DisplayName("Genre")]
        [Range(typeof(DateTime), "01/01/2000", "01/01/2030", ErrorMessage = "Hallo")]
        public DateTime ReleaseDate { get; internal set; }
        
    }
}