using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_LIBRO.Context;
using WEB_API_LIBRO.Entities;

namespace WEB_API_LIBRO.Services
{
    public class RepAutor: IRepAutor
    {
        private readonly ApplicatioDbContext context;

        public RepAutor(ApplicatioDbContext context)
        {
            this.context = context;
        }
        public Autor ObtenerPorId(int id)
        {
            return context.Autores.Include(x => x.Libros).FirstOrDefault(x => x.Id == id);
        }

    }
}
