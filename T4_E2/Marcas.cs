using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace T4_E2
{
    public class ListaMarcas
    {
        public int Id { get; set; }
        public string Marca { get; set; }

        public ListaMarcas(int id, string marca)
        {
            Id = id;
            Marca = marca;
        }

        public override string ToString()
        {
            return Marca;
        }
    }
   
}
