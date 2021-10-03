using System;
using System.Collections.Generic;

namespace Cadastro_Veiculos.Models
{
    public partial class Proprietario
    {
        public Proprietario()
        {
            Veiculo = new HashSet<Veiculo>();
        }

        public string CpfProp { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereço { get; set; }
        public int? Idade { get; set; }
        public string Cnh { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Veiculo> Veiculo { get; set; }
    }
}
