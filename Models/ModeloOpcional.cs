using System;
using System.Collections.Generic;

namespace Cadastro_Veiculos.Models
{
    public partial class ModeloOpcional
    {
        public int CodModelo { get; set; }
        public int CodOpcional { get; set; }

        public virtual Modelo CodModeloNavigation { get; set; }
        public virtual Opcional CodOpcionalNavigation { get; set; }
    }
}
