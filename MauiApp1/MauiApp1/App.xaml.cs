/*using AndroidX.ConstraintLayout.Core;*/
using Microsoft.Maui.Controls;
using System.Text;
namespace MauiApp1
{
    /*
     * Cette classe représente votre application au moment de l’exécution.
     * Le constructeur de cette classe crée une fenêtre initiale et l’affecte à la propriété MainPage.
     * Cette propriété détermine la page affichée au démarrage de l’application.De plus, cette classe 
     * vous permet de remplacer les gestionnaires d’événements de cycle de vie des applications courants et
     * indépendants de la plateforme.Les événements incluent OnStart, OnResume et OnSleep.
    */    
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
        protected override void OnStart()
        {
            base.OnStart();
        }
        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }
    }
}