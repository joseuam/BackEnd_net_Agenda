using System;
using Microsoft.EntityFrameworkCore;

namespace AgendaT.Models
{
    public class TodoContext: DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }
        public DbSet<Contacto> ContactoItems { get; set; }
    }
}
