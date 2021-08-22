using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ctbl.Entities.Dtos.CategoryDtos
{
    public class CategoryAddDto
    {
        
        [DisplayName("Kategori Adi")]
        [Required(ErrorMessage = "{0} Bos gecilemez")]
        [MaxLength(70,ErrorMessage = "{0} {1 } Karakterden buyuk olamaz")]
        [MinLength(3, ErrorMessage = "{0} {1} Karakterden kucuk olamaz")]
        public string Name { get; set; }
        
        [DisplayName("Kategori Aciklamasi")]
        [MaxLength(70,ErrorMessage = "{0} {1 } Karakterden buyuk olamaz")]
        [MinLength(3, ErrorMessage = "{0} {1} Karakterden kucuk olamaz")]
        public string Description { get; set; }
        
        [DisplayName("Kategori Notu")] 
        [MaxLength(70,ErrorMessage = "{0} {1 } Karakterden buyuk olamaz")] 
        [MinLength(3, ErrorMessage = "{0} {1} Karakterden kucuk olamaz")]
        public string Note { get; set; }
        
        [DisplayName("Aktif mi ")]
        [Required(ErrorMessage = "{0} Bos gecilemez")]
        public bool IsActive { get; set; }
        
    }
}