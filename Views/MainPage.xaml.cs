﻿using ProyectoP2.ViewModels;
namespace ProyectoP2;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new RazasPerrosViewModel();

    }

    private async void botonCitas(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Citas());
    }

    private async void botonAnimales(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Animales());
    }

    private async void botonClientes(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Clientes());
    }
    private async void botonAPI(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RazasPerrosPage());

    }


}

