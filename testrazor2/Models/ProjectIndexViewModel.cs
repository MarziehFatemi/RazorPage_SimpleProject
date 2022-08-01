using System.ComponentModel;

namespace RazorBlog.Models
{
    public class ProjectIndexViewModel
    {
        [DisplayName("نام")]
         public string Name { get; set; }

        [DisplayName("چکیده مقاله")]
        public string ShortDiscription { get; set; }

        [DisplayName("مشتری")]
        public string Client { get; set; }

        [DisplayName("تصویر")]
         public string Image { get; set; }

        [DisplayName("متن مقاله")]
        public string Body { get; set; }


   

    }
}
