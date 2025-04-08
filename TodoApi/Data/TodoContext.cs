using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<Todo> Todos { get; set; }

        // Method to seed data if the database is empty (optional)
        public static void Seed(TodoContext context)
        {
            if (!context.Todos.Any())
            {
                context.Todos.AddRange(
                    new Todo { Title = "Learn C#", IsCompleted = false },
                    new Todo { Title = "Build .NET Core App", IsCompleted = false },
                    new Todo { Title = "Master Angular", IsCompleted = true }
                );
                context.SaveChanges();
            }
        }
    }
}
