using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API_LIBRO.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public List<SubCate> SubCates { get; set; }
    }
}
