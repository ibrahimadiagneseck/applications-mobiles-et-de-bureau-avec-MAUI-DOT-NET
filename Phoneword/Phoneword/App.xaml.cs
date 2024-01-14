/*using static Android.Provider.Contacts.Intents;*/
using System.Net;
using System.Text;
namespace Phoneword
{
    public partial class App : Application
    {
        /*Le fichier App.xaml.cs, le constructeur de la classe App, crée une instance de la classe AppShell qui s’affiche ensuite dans la fenêtre d’application.*/
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}