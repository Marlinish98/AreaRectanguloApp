using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AreaRectanguloApp.Models;

namespace AreaRectanguloApp.ViewModels
{
    public partial class AreaRectanguloViewModel : ObservableObject
    {
        [ObservableProperty]
        private double baseRectangulo;

        [ObservableProperty]
        private double altura;

        [ObservableProperty]
        private double area;

        [RelayCommand]
        private void CalcularArea()
        {
            var rectangulo = new Rectangulo
            {
                Base = this.BaseRectangulo,
                Altura = this.Altura
            };

            Area = rectangulo.Base * rectangulo.Altura;
        }
    }
}