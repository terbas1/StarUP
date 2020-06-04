﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarUp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(string Name, string Image, string Precio, string DetallePrincipio, string DetalleSegunda, string Ingredientes)
        {


            InitializeComponent();

            FoodName.Text = Name;
            FoodIngredientes.Text = Ingredientes;
            FoodDetalleSegundo.Text = DetalleSegunda;
            FoodImage.Source = new UriImageSource()
            {
                Uri = new Uri(Image)
            };





        }
    }
}