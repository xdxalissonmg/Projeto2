using System;
using System.Collections.Generic;

namespace Cadastro_Veiculos.Models
{
    public partial class Modelo
    {
        public Modelo()
        {
            ModeloOpcional = new HashSet<ModeloOpcional>();
            Veiculo = new HashSet<Veiculo>();
        }

        public int CodModelo { get; set; }
        public string Nome { get; set; }
        public short? Ano { get; set; }
        public string Motor { get; set; }
        public string Combustivel { get; set; }
        public string Portas { get; set; }
        public string Chassi { get; set; }
        public int? CodMarca { get; set; }

        public virtual Veiculo ChassiNavigation { get; set; }
        public virtual Marca CodMarcaNavigation { get; set; }
        public virtual ICollection<ModeloOpcional> ModeloOpcional { get; set; }
        public virtual ICollection<Veiculo> Veiculo { get; set; }
    }
}
