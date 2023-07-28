using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_E1
{

        public class Paises
        {
            public int IdPais;
            public string nombrePais;

        }

        public class Departamento : Paises
        {
            public int IdDepartamento;
            public string nombreDepartamento;

        }

        public class Municipio : Departamento
        {
            public int IdMunicipio;
            public string nombreMunicipio;

        }

        public class Habitante : Municipio
        {
            public int IdHabitante;
            public string nombreHabitante;

        }
 
}
