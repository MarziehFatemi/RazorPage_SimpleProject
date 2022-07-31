using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorBlog.Models
{
    public class ProjectViewModel
    {
        
		[DisplayName("نام")]
        [Required(ErrorMessage = "نام اجباری است")]
		[MaxLength(255)]
        public string Name { get; set; }

        [DisplayName("چکیده مقاله")]
        [Required(ErrorMessage = "چکیده مقاله اجباری است")]
        [MaxLength(255)]
        public string ShortDiscription { get; set; }

        [DisplayName("مشتری")]
        [MaxLength(255)]
        public string Client { get; set; }

        [DisplayName("تصویر")]
        [MaxLength(255)]
        [Required(ErrorMessage = "تصویر اجباری است")]
        public string Image { get; set; }

        [DisplayName("متن مقاله")]
        [Required(ErrorMessage = "متن مقاله اجباری است")]
        public string Body { get; set; }

        [DisplayName("ALt تصویر")]
        [MaxLength(255)]
        public string PictureAlt { get; set; }

        [DisplayName("عنوان تصویر")]
        [MaxLength(255)]
        public string PictureTitle { get; set; }

        public string CreationDate { get; set; }


    }
}
