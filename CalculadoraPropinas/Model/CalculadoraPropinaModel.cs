/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPropinas.Model
{
    class CalculadoraPropinaModel
    {
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPropinas.Model
{
    public class CalculadoraPropinaModel
    {
        public (double Propina, double TotalPagar, double TotalPagarPorPersona) CalcularPropina(double costoServicio, int numeroPersonas, double porcentajePropina)
        {
            double propina = costoServicio * (porcentajePropina / 100);
            double totalPagar = costoServicio + propina;
            double totalPagarPorPersona = totalPagar / numeroPersonas;

            return (propina, totalPagar, totalPagarPorPersona);
        }
    }
}
