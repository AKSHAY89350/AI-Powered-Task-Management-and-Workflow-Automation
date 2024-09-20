using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Task_Management.Model
{
    public class ContextDB : DbContext
    {
       
        public ContextDB(DbContextOptions<ContextDB> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }
        
    }
}
