using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SocialNetwork
{
    public class Post 
    {
        public Post()
        {
        }

        public DateTime Moment { get; set; } = DateTime.Now;
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public int View { get; set; }
        public int Codigo { get; set; }

        public IList<Comment> Comments { get; set; } = new List<Comment>();

        public void RemoveComment(Comment _comment)
        {
            try
            {
                Comments.Remove(_comment);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        public void AddComment(Comment _comment)
        {
            Comments.Add(_comment);
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
