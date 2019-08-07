using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_LIBRO.Context;
using WEB_API_LIBRO.Entities;
using WEB_API_LIBRO.Services;

namespace WEB_API_LIBRO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController: ControllerBase
    {
        private readonly IRepositorioAutores repositorioAutores;

        public AutoresController(IRepositorioAutores repositorioAutores)
        {
            this.repositorioAutores = repositorioAutores;
        }

        [HttpGet("{id}")]
        public ActionResult<Autor> Get(int id)
        {
            var autor = repositorioAutores.ObtenerPorId(id);
            if (autor == null)
            {
                return NotFound();
            }
            return autor;
        }

    }
}
