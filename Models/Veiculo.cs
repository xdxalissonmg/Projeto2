using System;
using System.Collections.Generic;

namespace Cadastro_Veiculos.Models
{
    public partial class Veiculo
    {
        public Veiculo()
        {
            Modelo = new HashSet<Modelo>();
        }

        public string Chassi { get; set; }
        public short? Ano { get; set; }
        public string Placa { get; set; }
        public short? AnoLicenciamento { get; set; }
        public string CpfProp { get; set; }
        public int? CodEstado { get; set; }
        public int? CodModelo { get; set; }

        public virtual Estado CodEstadoNavigation { get; set; }
        public virtual Modelo CodModeloNavigation { get; set; }
        public virtual Proprietario CpfPropNavigation { get; set; }
        public virtual ICollection<Modelo> Modelo { get; set; }
    }
}
