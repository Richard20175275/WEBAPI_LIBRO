using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_LIBRO.Context;
using WEB_API_LIBRO.Entities;

namespace WEB_API_LIBRO.Services
{
    public class RepositorioAutores: IRepositorioAutores
    {
        private readonly ApplicatioDbContext context;

        public RepositorioAutores(ApplicatioDbContext context)
        {
            this.context = context;
        }

        public Autor ObtenerPorId(int id)
        {
            return context.Autores.FirstOrDefault(x => x.Id == id);
        }
    }
}
