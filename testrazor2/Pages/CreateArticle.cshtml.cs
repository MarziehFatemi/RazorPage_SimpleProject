using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBlog.Context;
using RazorBlog.Models;

namespace testrazor2.Pages
{
    public class CreateArticleModel : PageModel
    {
      //[ViewData]
      //string Success { get; set; } 

        public ProjectViewModel Command { get; set; }

        private readonly  RazorBlog_dbContext _Context; 
        public CreateArticleModel(RazorBlog_dbContext Context)
        {
            _Context= Context;


        }

        public void OnGet()
        {
        }

        public void OnPost (ProjectViewModel Command)
        {
            if (ModelState.IsValid)
            {
                Project project = new Project(Command.Name, Command.Client,
                    Command.Image, Command.PictureAlt, Command.PictureTitle,
                    Command.ShortDiscription, Command.Body);
                try
                {
                    _Context.Projects.Add(project);
                    _Context.SaveChanges();
                    ViewData["Success"] = "مقاله با موفقیت ذخیره شد";
                }
                catch (Exception e)
				{
                    ViewData["Error"] = e.ToString(); 

                }
           }
            else
            {
                ViewData["Error"] = "اصلاح نموده مجدد تلاش نمایید. ";

            }


        }
    }
}