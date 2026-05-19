using MauiAppHotel.Views;
using Microsoft.Extensions.DependencyInjection;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(HospedagemContratada), typeof(HospedagemContratada));
            Routing.RegisterRoute(nameof(ContratacaoHospedagem), typeof(ContratacaoHospedagem));
            Routing.RegisterRoute(nameof(Sobre), typeof(Sobre));

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var w = new Window(new AppShell());

            w.Width = 400;
            w.Height = 600;

            return w;
        }
    }
}