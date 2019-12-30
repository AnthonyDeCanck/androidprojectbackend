using AndroidAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndroidAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Message> Fietsen { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Message>().HasData(
              new { Id = 1, Title = "Title 1",   Author = "Author1", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 2, Title = "Title 2",   Author = "Author2", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 3, Title = "Title 3",   Author = "Author3", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 4, Title = "Title 4",   Author = "Author1", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 5, Title = "Title 5",   Author = "Author4", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 6, Title = "Title 6",   Author = "Author2", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 7, Title = "Title 7",   Author = "Author2", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 8, Title = "Title 8",   Author = "Author5", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 9, Title = "Title 9",   Author = "Author3", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 10, Title = "Title 10", Author = "Author1", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 11, Title = "Title 11", Author = "Author2", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 12, Title = "Title 12", Author = "Author6", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 13, Title = "Title 13", Author = "Author5", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 14, Title = "Title 14", Author = "Author2", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 15, Title = "Title 15", Author = "Author4", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 16, Title = "Title 16", Author = "Author6", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 17, Title = "Title 17", Author = "Author1", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 18, Title = "Title 18", Author = "Author2", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 19, Title = "Title 19", Author = "Author4", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 20, Title = "Title 20", Author = "Author2", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 21, Title = "Title 21", Author = "Author1", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 22, Title = "Title 22", Author = "Author5", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 23, Title = "Title 23", Author = "Author3", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 24, Title = "Title 24", Author = "Author3", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 25, Title = "Title 25", Author = "Author3", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 26, Title = "Title 26", Author = "Author2", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 27, Title = "Title 27", Author = "Author1", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 28, Title = "Title 28", Author = "Author6", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 29, Title = "Title 29", Author = "Author6", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 30, Title = "Title 30", Author = "Author1", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 31, Title = "Title 31", Author = "Author4", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 32, Title = "Title 32", Author = "Author5", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 33, Title = "Title 33", Author = "Author2", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 34, Title = "Title 34", Author = "Author4", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 35, Title = "Title 35", Author = "Author3", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 36, Title = "Title 36", Author = "Author4", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 37, Title = "Title 37", Author = "Author1", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 38, Title = "Title 38", Author = "Author6", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 39, Title = "Title 39", Author = "Author1", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." },
              new { Id = 40, Title = "Title 40", Author = "Author2", Body = "Lorem ipsum erat venio sic defat amur deria se. Se Loren Gwynn derita varen defora se amur." }
            );
        }
    }
}
