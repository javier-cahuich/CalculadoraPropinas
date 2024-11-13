/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPropinas.ViewModel
{
    class CalculadoraPropinaViewModel
    {
    }
}*/
using CalculadoraPropinas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace CalculadoraPropinas.ViewModel
{
    public class CalculadoraPropinaViewModel : BindableObject
    {
        private double costoServicio;
        private int numeroPersonas;
        private double porcentajePropina;
        private string resultado;
        private double totalPagar;
        private double totalPagarPorPersona;

        public double CostoServicio
        {
            get => costoServicio;
            set
            {
                costoServicio = value;
                OnPropertyChanged(nameof(CostoServicio));
            }
        }

        public int NumeroPersonas
        {
            get => numeroPersonas;
            set
            {
                numeroPersonas = value;
                OnPropertyChanged(nameof(NumeroPersonas));
            }
        }

        public double PorcentajePropina
        {
            get => porcentajePropina;
            set
            {
                porcentajePropina = value;
                OnPropertyChanged(nameof(PorcentajePropina));
            }
        }

        public string Resultado
        {
            get => resultado;
            set
            {
                resultado = value;
                OnPropertyChanged(nameof(Resultado));
            }
        }

        public double TotalPagar
        {
            get => totalPagar;
            set
            {
                totalPagar = value;
                OnPropertyChanged(nameof(TotalPagar));
            }
        }

        public double TotalPagarPorPersona
        {
            get => totalPagarPorPersona;
            set
            {
                totalPagarPorPersona = value;
                OnPropertyChanged(nameof(TotalPagarPorPersona));
            }
        }

        private CalculadoraPropinaModel calculadoraModel;

        public CalculadoraPropinaViewModel()
        {
            calculadoraModel = new CalculadoraPropinaModel();
        }

        public void CalcularPropina()
        {
            var resultado = calculadoraModel.CalcularPropina(costoServicio, numeroPersonas, porcentajePropina);
            Resultado = $"Propina: {resultado.Propina:C2}";
            TotalPagar = resultado.TotalPagar;
            TotalPagarPorPersona = resultado.TotalPagarPorPersona;
        }

        public void Limpiar()
        {
            CostoServicio = 0;
            NumeroPersonas = 0;
            PorcentajePropina = 0;
            Resultado = string.Empty;
            TotalPagar = 0;
            TotalPagarPorPersona = 0;
        }
    }
}
