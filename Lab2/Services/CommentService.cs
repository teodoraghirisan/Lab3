using Lab2.ViewModels;
using Lab2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Services
{
    public interface ICommentService
    {

        IEnumerable<CommentsGetModel> GetAll(String filter);

    }

    public class CommentService : ICommentService
    {

        private MoviesDbContext context;

        public CommentService(MoviesDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<CommentsGetModel> GetAll(String filter)
        {
            IQueryable<Movie> result = context.Movies.Include(c => c.Comments);

            List<CommentsGetModel> resultComments = new List<CommentsGetModel>();
            List<CommentsGetModel> resultCommentsAll = new List<CommentsGetModel>();

            foreach (Movie movie in result)
            {
                movie.Comments.ForEach(c =>
                {
                    if (c.Text == null || filter == null)
                    {
                        CommentsGetModel comment = new CommentsGetModel
                        {
                            Id = c.Id,
                            Important = c.Important,
                            Text = c.Text,
                            MovieId = movie.Id

                        };
                        resultCommentsAll.Add(comment);
                    }
                    else if (c.Text.Contains(filter))
                    {
                        CommentsGetModel comment = new CommentsGetModel
                        {
                            Id = c.Id,
                            Important = c.Important,
                            Text = c.Text,
                            MovieId = movie.Id

                        };
                        resultComments.Add(comment);

                    }
                });
            }
            if (filter == null)
            {
                return resultCommentsAll;
            }
            return resultComments;
        }
    }
}

