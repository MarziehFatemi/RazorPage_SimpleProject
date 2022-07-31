﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBlog.Context;
using RazorBlog.Models;

namespace testrazor2.Pages
{
    public class PrivacyModel : PageModel
    {
      //[ViewData]
      //string Success { get; set; } 
        private readonly  RazorBlog_dbContext _Context; 
        public PrivacyModel(RazorBlog_dbContext Context)
        {
            _Context= Context;


        }

        public void OnGet()
        {
        }

        public void OnPost (ProjectViewModel Command)
        {
            Project project = new Project(Command.Name, Command.Client,
                Command.Image, Command.PictureAlt, Command.PictureTitle,
                Command.ShortDiscription, Command.Body); 

            _Context.Projects.Add(project);
            _Context.SaveChanges();
           ViewData["Success"] = "مقاله با موفقیت ذخیره شد";


        }
    }
}