using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using ctbl.Entities.Concrete;
using Microsoft.Win32.SafeHandles;

namespace ctbl.Entities.Dtos.ArticleDtos
{
    public class ArticleAddDto
    {
        
        [Required]
        public int Id { get; set; }
        
        
        [DisplayName("Baslik")]
        [Required(ErrorMessage = "{0} Alani bos gecilmemelidir")]
        [MaxLength(100, ErrorMessage = "{0} alani {1} karakterden buyuk olmamalidir}")]
        [MinLength(5, ErrorMessage = "{0} alani {1} karakterden kucuk olmamalidir}")]
        public string Title { get; set; }
       
        [DisplayName("Icerik")]
        [Required(ErrorMessage = "{0} Alani bos gecilmemelidir")]
        [MinLength(5, ErrorMessage = "{0} alani {1} karakterden kucuk olmamalidir}")]
        public string Content { get; set; }
        
        
        [DisplayName("Thumbnail")]
        [Required(ErrorMessage = "{0} Alani bos gecilmemelidir")]
        [MaxLength(250, ErrorMessage = "{0} alani {1} karakterden buyuk olmamalidir}")]
        [MinLength(5, ErrorMessage = "{0} alani {1} karakterden kucuk olmamalidir}")]
        public string Thumbnail { get; set; }
        
       
        [DisplayName("Tarih")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: dd/mm/yyyy}")]
        [Required(ErrorMessage = "{0} Alani bos gecilmemelidir")]
        public DateTime Date { get; set; }
       
        
        [DisplayName("Seo Yazar")] 
        [Required(ErrorMessage = "{0} Alani bos gecilmemelidir")]
        [MaxLength(50, ErrorMessage = "{0} alani {1} karakterden buyuk olmamalidir}")]
        [MinLength(0, ErrorMessage = "{0} alani {1} karakterden kucuk olmamalidir}")]
        public string SeoAuthor { get; set; }
        
        [DisplayName("Seo Aciklama")] 
        [Required(ErrorMessage = "{0} Alani bos gecilmemelidir")]
        [MaxLength(150, ErrorMessage = "{0} alani {1} karakterden buyuk olmamalidir}")]
        [MinLength(0, ErrorMessage = "{0} alani {1} karakterden kucuk olmamalidir}")]
        public string SeoDescription { get; set; }
        
        
        
        [DisplayName("Seo Etiketleri")] 
        [Required(ErrorMessage = "{0} Alani bos gecilmemelidir")]
        [MaxLength(70, ErrorMessage = "{0} alani {1} karakterden buyuk olmamalidir}")]
        [MinLength(0, ErrorMessage = "{0} alani {1} karakterden kucuk olmamalidir}")]
        public string SeoTags { get; set; }
 
        [DisplayName("Categori")] 
        [Required(ErrorMessage = "{0} Alani bos gecilmemelidir")]
        public int CategoryId { get; set; }
        public Category Category{ get; set; }

        
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} Alani bos gecilmemelidir")]
        public bool IsActive { get; set; }
        
       
        [DisplayName("Silinsin  Mi?")]
        [Required(ErrorMessage = "{0} Alani bos gecilmemelidir")]
        public bool IsDeleted { get; set; }
        
    }
}