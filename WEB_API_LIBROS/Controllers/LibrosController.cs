﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_LIBROS.Contexts;
using WEB_API_LIBROS.Entities;

namespace WEB_API_LIBROS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController: ControllerBase
    {

        private readonly ApplicationDbContext context;

        public LibrosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Libro>> Get()
        {
            return context.Libros.Include(x => x.Autor).ToList();
        }

        [HttpGet("{id}", Name = "ObtenerLibro")]
        public ActionResult<Libro> Get(int id)
        {
            var libro = context.Libros.Include(x => x.Autor).FirstOrDefault(x => x.Id == id);
            if (libro == null)
            {
                return NotFound();
            }
            return libro;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Libro libro)
        {
            context.Libros.Add(libro);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerLibro", new { id = libro.Id }, libro);
        }

    }
}
