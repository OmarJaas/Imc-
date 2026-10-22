using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Imc.Maui.Models;

namespace Imc.Maui.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _peso;
        [ObservableProperty]
        private string _estatura;
        [ObservableProperty]
        private string _imc;
        [ObservableProperty]
        private string _estadoNutricional;



        public MainViewModel()
        {
            Limpiar();
        }

        [RelayCommand]
        private void Calcular()
        {
            decimal peso;
            decimal estatura;
            bool pesoEsValido = decimal.TryParse(Peso, out peso);
            bool estaturaEsValida = decimal.TryParse(Estatura, out estatura);
            if(pesoEsValido && estaturaEsValida)
            {
                decimal imc = CalculadoraImc.IndiceDeMasaCorporal(peso, estatura);
                Imc = imc.ToString("F4");
                EstadoNutricional = CalculadoraImc.EstadoNutricional(imc);
            }

        }
        [RelayCommand]
        private void Limpiar()
        {
            Peso= string.Empty;
            Estatura = string.Empty;
            Imc = string.Empty;
            EstadoNutricional = string.Empty;
        }
    }
}