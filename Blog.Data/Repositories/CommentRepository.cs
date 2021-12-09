﻿using Blog.Core.Repositories;
using Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Repositories
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
