using System;
using System.Collections.Generic;

namespace Cadastro_Veiculos.Models
{
    public partial class Marca
    {
        public Marca()
        {
            Modelo = new HashSet<Modelo>();
        }

        public int CodMarca { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Modelo> Modelo { get; set; }
    }
}
