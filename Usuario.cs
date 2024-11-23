using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Academ
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; } // "Professor" ou "Estudante"

        public override string ToString()
        {
            return $"{Nome} ({Tipo}) - {Email}";
        }
    }
}
