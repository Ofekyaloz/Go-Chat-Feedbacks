#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Go_Chat_Feedbacks.Models;

namespace Go_Chat_Feedbacks.Data
{
    public class Go_Chat_FeedbacksContext : DbContext
    {
        public Go_Chat_FeedbacksContext (DbContextOptions<Go_Chat_FeedbacksContext> options)
            : base(options)
        {
        }

        public DbSet<Go_Chat_Feedbacks.Models.Feedback> Feedback { get; set; }
    }
}
