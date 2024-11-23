using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Academ
{
    public class Evento
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public string Criador { get; set; } // Nome do professor que criou o evento
        public List<Usuario> Participantes { get; set; } = new List<Usuario>();

        public override string ToString()
        {
            return $"{Titulo} - {DataHora:dd/MM/yyyy HH:mm}";
        }
    }
}
