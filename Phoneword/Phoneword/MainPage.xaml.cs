/*using static Android.Provider.Contacts.Intents;*/
/*using static JetBrains.Annotations.Async;*/
using System.Text;
namespace Phoneword
{
    /*Le fichier MainPage.xaml.cs contient la logique d’application de la page.Plus précisément, 
     * la classe MainPage inclut une méthode nommée OnCounterClicked qui s’exécute lorsque l’utilisateur appuie sur le bouton Cliquer ici.*/
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            /*count++;*/
            count += 5; // update this

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }


    }
}