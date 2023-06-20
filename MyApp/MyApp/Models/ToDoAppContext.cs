using Microsoft.EntityFrameworkCore;
using System;


namespace MyApp.Models
{
    public class ToDoAppContext : DbContext
    {

        public ToDoAppContext(DbContextOptions<ToDoAppContext> options) : base(options)
        {


        }
        public DbSet<ToDoAppModel> ToDoAppModels { get; set; }
    }
}
