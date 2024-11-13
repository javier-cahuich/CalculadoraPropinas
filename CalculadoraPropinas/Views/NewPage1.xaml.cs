/*namespace CalculadoraPropinas.Views;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
}*/
using CalculadoraPropinas.Model;
using CalculadoraPropinas.ViewModel;
using CalculadoraPropinas.Views;
using Microsoft.Maui.Controls;

namespace CalculadoraPropinas.Views
{
    public partial class NewPage1 : ContentPage
    {
        private CalculadoraPropinaViewModel viewModel;

        public NewPage1()
        {
            InitializeComponent();
            viewModel = new CalculadoraPropinaViewModel();
            BindingContext = viewModel;
        }

        private void OnPorcentajePropinaClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                double.TryParse(button.Text.Trim('%'), out double porcentajePropina);
                viewModel.PorcentajePropina = porcentajePropina;
            }
        }

        private void OnCalcularClicked(object sender, EventArgs e)
        {
            viewModel.CalcularPropina();
        }

        private void OnLimpiarClicked(object sender, EventArgs e)
        {
            viewModel.Limpiar();
        }
    }
}