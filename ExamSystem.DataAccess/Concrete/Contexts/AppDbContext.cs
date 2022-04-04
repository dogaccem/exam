using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Entities.Concrete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ExamSystem.DataAccess.Concrete.Contexts
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=LAPTOP-IUG2VKNA;Database=ExamDb;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;");
        }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<User> Users { get; set; }
    }
    
    
}
