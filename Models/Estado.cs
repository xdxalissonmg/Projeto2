using System;
using System.Collections.Generic;

namespace Cadastro_Veiculos.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Veiculo = new HashSet<Veiculo>();
        }

        public int CodEstado { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Veiculo> Veiculo { get; set; }
    }
}
