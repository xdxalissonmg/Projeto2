using System;
using System.Collections.Generic;

namespace Cadastro_Veiculos.Models
{
    public partial class Opcional
    {
        public Opcional()
        {
            ModeloOpcional = new HashSet<ModeloOpcional>();
        }

        public int CodOpcional { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<ModeloOpcional> ModeloOpcional { get; set; }
    }
}
