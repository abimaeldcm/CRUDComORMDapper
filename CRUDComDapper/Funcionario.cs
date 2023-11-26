using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDComDapper
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} \nNome: {Nome} \nSobrenome: {Sobrenome}";
        }

    }
    
}
