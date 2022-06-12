using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.Entities.Dto
{
    public class CategoriesDTO
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }
        public override string ToString()
        {
            return $"Categoria: {CategoryID} \t Nombre: {CategoryName} \t Descripcion: {Description}";
        }
    }
}
