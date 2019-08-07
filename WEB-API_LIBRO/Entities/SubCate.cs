using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API_LIBRO.Entities
{
    public class SubCate
    {
        public int Id { get; set; }
        [Required]
        public string NombreSub { get; set; }
        [Required]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
