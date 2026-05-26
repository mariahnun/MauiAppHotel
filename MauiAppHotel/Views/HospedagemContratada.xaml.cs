using MauiAppHotel.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{

    App PropriedadesApp;


    public HospedagemContratada()
	{
		InitializeComponent();
        PropriedadesApp = (App)Application.Current;
        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Sobre));

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}