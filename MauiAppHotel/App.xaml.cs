using MauiAppHotel.Models;
using MauiAppHotel.Views;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto> 
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca =55.0
            },

            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca =40.0
            },

            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca =25.0
            },

            new Quarto()
            {
                Descricao = "Suíte Básico",
                ValorDiariaAdulto = 30.0,
                ValorDiariaCrianca =15.0
            },

        };
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