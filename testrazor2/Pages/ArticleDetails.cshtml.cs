using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBlog.Context;
using RazorBlog.Models;

namespace RazorBlog.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        public ProjectIndexViewModel Project { get; set; }
        private readonly RazorBlog_dbContext _Context;

        public ArticleDetailsModel(RazorBlog_dbContext Context)
        {
            _Context = Context;

        }

        public void OnGet(int id)
        {
            Project = _Context.Projects.Select(x => new ProjectIndexViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Client = x.Client,
                Body = x.Body,
                Image = x.Image + ".png",
                ShortDiscription = x.ShortDiscription,
            }).FirstOrDefault(x => x.Id == id);

        }
    }
}
