using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Solarizr
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPageConMenu : Page
    {
        public MainPageConMenu()
        {
            this.InitializeComponent();
            framePagina.Navigate(typeof(ListaCitas), null); //BlankPage1 es la pagina ListaCitas
        }

        /// <summary>
        /// Evento asociado al click del AppBarButton para volver atrás
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navegarAtras(object sender, RoutedEventArgs e)
        {
            if(framePagina.CanGoBack)
            {
                framePagina.GoBack();
            }
            
            
            //Frame.Navigate(typeof(BlankPage1), null);
            //framePagina.Content = null;
        }
        /// <summary>
        /// Evento asociado al click del AppBarButton de Cerrar Sesión
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void volverAlLogin(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
