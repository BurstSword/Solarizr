using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

namespace Solarizr
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class VistaCita : Page
    {
        public VistaCita()
        {
            this.InitializeComponent();


            /*GMapsUWP.Initializer.Initialize("mapuri", "en-US");
            Map.Style = MapStyle.None;
            Map.TileSources.Clear();
            string mapuri = "http://mt1.google.com/vt/lyrs=r&hl=x-local&z={zoomlevel}&x={x}&y={y}";
            Map.TileSources.Add(new MapTileSource(new HttpMapTileDataSource(mapuri)));
            GMapsUWP.Map.MapControlHelper.UseGoogleMaps(Map);*/
        }
<<<<<<< Updated upstream
        /// <summary>
        /// Evento asociado al click del botón Calcular ruta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
=======

>>>>>>> Stashed changes
        private void navegarAlMapa(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Mapa), null, new DrillInNavigationTransitionInfo());
        }
<<<<<<< Updated upstream
        /// <summary>
        /// Evento asociado al click del botón con forma de clip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
=======

>>>>>>> Stashed changes
        private void AbrirGaleria(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Galeria), null);
        }
    }

}