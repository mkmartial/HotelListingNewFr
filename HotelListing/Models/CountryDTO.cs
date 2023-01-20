using HotelListing.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage ="Country Name is too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Country Name is too long")]
        public string ShortName { get; set; }
      
    }

    public class UpdateCountryDTO : CreateCountryDTO
    {
       
    }

    public class CountryDTO:CreateCountryDTO
    {
        public int Id { get; set; }
       
        public ICollection<HotelDTO> Hotels { get; set; }
    }
}
