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
    public class SCategorias: ControllerBase
    {

        private readonly ApplicatioDbContext context;

        public SCategorias(ApplicatioDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SubCate>> Get()
        {
            return context.SubCates.Include(x => x.Categoria).ToList();
        }

        [HttpGet("{id}", Name = "ObtenerSCategoria")]
        public ActionResult<SubCate> Get(int id)
        {
            var scategoria = context.SubCates.Include(x => x.Categoria).FirstOrDefault(x => x.Id == id);

            if (scategoria == null)
            {
                return NotFound();
            }
            return scategoria;
        }

        [HttpPost]
        public ActionResult Post([FromBody] SubCate scategoria)
        {
            context.SubCates.Add(scategoria);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerSCategoria", new { id = scategoria.Id }, scategoria);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] SubCate scategoria)
        {
            if (id != scategoria.Id)
            {
                return BadRequest();
            }

            context.Entry(scategoria).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<SubCate> Delete(int id)
        {
            var scategoria = context.SubCates.FirstOrDefault(x => x.Id == id);

            if (scategoria == null)
            {
                return NotFound();
            }

            context.SubCates.Remove(scategoria);
            context.SaveChanges();
            return scategoria;
        }

    }
}
