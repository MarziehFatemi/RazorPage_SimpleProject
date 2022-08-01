using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBlog.Context;
using RazorBlog.Models;
using System.Linq;

namespace testrazor2.Pages
{
    public class IndexModel : PageModel
    {
        public List<ProjectIndexViewModel> Project { get; set; }
        private readonly RazorBlog_dbContext _Context; 
        
        public IndexModel(RazorBlog_dbContext Context)
        {
            _Context = Context; 
        }

        public void OnGet()
        {
            Project = _Context.Projects.Select(x => new ProjectIndexViewModel
            {
                Id = x.Id,
                Name = x.Name,
                ShortDiscription = x.ShortDiscription,
                Image =x.Image,
                Body = x.Body, 
                Client = x.Client,

            }
            ).ToList(); 
             
            
        }
    }
}