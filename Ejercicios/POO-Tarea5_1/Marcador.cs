using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directorio.Clases
{
    internal class Marcador
    {
        private double costoHora { get; set; }

        private double horasTrabajadas { get; set; }
        private double salario { get; set; }

        public Marcador()
        {
            this.costoHora = 50;
        }

        public double getSalario(double p_horastrabajadas)
        {
            this.salario = p_horastrabajadas * this.costoHora;
            return this.salario;
        }
    }
}
