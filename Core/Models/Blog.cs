using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Blog
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Blog(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public Blog()
        {
            Comments = new Comment[0];

        }
        Comment[] Comments = new Comment[] { };


        public override string ToString()
        {
            return $"Description:{Description} Title:{Title}";
        }
        public Comment[] GetComment(int commentId)
        {
            foreach (Comment comment in Comments)
            {
                if (comment.Id == commentId)
                {
                    return Comments;
                }
            }
            return null;
        }
        public Comment[] GetAllComments()
        {
            return Comments;
        }
        public void AddComment(Comment comment)
        {
            Array.Resize(ref Comments, Comments.Length + 1);
            Comments[Comments.Length - 1] = comment;
        }

        public void RemoveComment(int commentId)
        {
            Comment[] filteredComments = new Comment[] { };
            foreach (Comment comment in Comments)
            {
                if (comment.Id != commentId)
                {
                    Array.Resize(ref filteredComments, filteredComments.Length + 1);
                    filteredComments[filteredComments.Length - 1] = comment;
                }
            }
            Comments = filteredComments;
        }
        public void UpdateComment(int commentId, Comment newComment)
        {
            for (int i = 0; i < Comments.Length; i++)
            {
                if (Comments[i].Id == commentId)
                {
                    Comments[i] = newComment;
                    return;
                }
            }
        }
    }
}
