using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_LIBRO.Entities;

namespace WEB_API_LIBRO.Context
{
    public class ApplicatioDbContext: DbContext
    {
        public ApplicatioDbContext(DbContextOptions<ApplicatioDbContext> options) : base(options)
        {

        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<SubCate> SubCates { get; set; }
    }
}
