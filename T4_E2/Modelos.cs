using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_E2
{
    public class ListaModelos
    {
        
        public int Id { get; set; }
        public string Modelo { get; set; }

        public ListaModelos(int id, string modelo)
        {
            Id = id;
            Modelo = modelo;
        }

        public override string ToString()
        {
            return Modelo;
        }
        
    }


}
