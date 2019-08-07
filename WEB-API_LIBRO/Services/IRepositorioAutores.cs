using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API_LIBRO.Services
{
    public interface IRepositorioAutores
    {
        Autor ObtenerPorId(int id);
    }
}
