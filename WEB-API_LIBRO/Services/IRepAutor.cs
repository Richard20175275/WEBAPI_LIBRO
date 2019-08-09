using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_LIBRO.Entities;

namespace WEB_API_LIBRO.Services
{
    public interface IRepAutor
    {
        Autor ObtenerPorId(int id);
    }
}
