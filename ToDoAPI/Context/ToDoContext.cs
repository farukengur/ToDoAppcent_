using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;



namespace ToDoAPI.Context
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {

        }
        public DbSet<TooDo> ToDo { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Memo> Memo { get; set; }


    }
}
