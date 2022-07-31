namespace RazorBlog.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ShortDiscription { get; set; }
        public string Client { get; set; }
        public string Image { get; set; }
        public string Body { get; set; }
        public string PictureAlt { get; set; }
        public string  PictureTitle { get; set; }
        public DateTime CreationDate { get; set; }


        public Project(long id, string name , string client, 
            string image, string pictureAlt, string pictureTitle,
            string shortDiscription, string body)
        {
            Id = id;
            Name = name;
            ShortDiscription = shortDiscription;
            Client = client;
            Image = image;
            Body = body;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            CreationDate = DateTime.Now; 
        }
    }
}
