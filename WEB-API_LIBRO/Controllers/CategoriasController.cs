using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_LIBRO.Context;
using WEB_API_LIBRO.Entities;

namespace WEB_API_LIBRO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController: ControllerBase
    {
        private readonly ApplicatioDbContext context;

        public CategoriasController(ApplicatioDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            return context.Categorias.Include(x => x.SubCates).ToList();
        }

        [HttpGet("{id}", Name = "ObtenerCategoria")]
        public ActionResult<Categoria> Get(int id)
        {
            var categoria = context.Categorias.Include(x => x.SubCates).FirstOrDefault(x => x.Id == id);
            if (categoria == null)
            {
                return NotFound();
            }
            return categoria;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Categoria categoria)
        {
            context.Categorias.Add(categoria);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerCategoria", new { id = categoria.Id }, categoria);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Categoria value)
        {
            if (id != value.Id)
            {
                return BadRequest();
            }
            context.Entry(value).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Categoria> Delete(int id)
        {
            var categoria = context.Categorias.FirstOrDefault(x => x.Id == id);

            if (categoria == null)
            {
                return NotFound();
            }

            context.Categorias.Remove(categoria);
            context.SaveChanges();
            return Ok();
        }

    }
}
