using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Academ
{
    public class Cadastro<T> : ICadastro<T>
    {
        private List<T> _entidades = new List<T>();

        public void Adicionar(T entidade)
        {
            _entidades.Add(entidade);
        }

        public List<T> Listar()
        {
            return _entidades;
        }

        public T BuscarPorNome(string nome)
        {
            return _entidades.FirstOrDefault(e => e.ToString().Contains(nome));
        }
    }
}
