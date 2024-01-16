/*using static Android.Provider.Contacts.Intents;*/
/*using static JetBrains.Annotations.Async;*/
using System;
using System.Text;
using System.Threading.Channels;
using static System.Collections.Specialized.BitVector32;

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
        /*private void OnCounterClicked(object sender, EventArgs e)
        {
            *//*count++;*//*
            count += 5; // update this

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }*/

        string translatedNumber;

        /*
         * La méthode OnTranslate extrait le numéro de téléphone de la propriété Text du contrôle Entry, 
         * et le transmet à la méthode ToNumber statique de la classe PhonewordTranslator que vous avez créée.
         */
        private void OnTranslate(object sender, EventArgs e)
        {
            string enteredNumber = PhoneNumberText.Text;
            translatedNumber = Core.PhonewordTranslator.ToNumber(enteredNumber);

            if (!string.IsNullOrEmpty(translatedNumber))
            {
                CallButton.IsEnabled = true;
                CallButton.Text = "Call " + translatedNumber;
            }
            else
            {
                CallButton.IsEnabled = false;
                CallButton.Text = "Call";
            }
        }

        /*Ajoutez la méthode de gestion des événements OnCall à la fin de la classe MainPage.Cette méthode utilisera des opérations asynchrones.Marquez-la donc en tant que async*/
        async void OnCall(object sender, System.EventArgs e)
        {
            /*
             * à l’aide de la méthode Page.DisplayAlert, s’il souhaite composer le numéro. 
             * Les paramètres pour DisplayAlert sont un titre, un message et deux chaînes utilisées 
             * pour le texte du bouton Accepter et Annuler. Il retourne une valeur booléenne indiquant 
             * si l’utilisateur a appuyé sur le bouton Accepter pour fermer la boîte de dialogue.
             */
            if (await this.DisplayAlert(
                    "Dial a Number",
                    "Would you like to call " + translatedNumber + "?",
                    "Yes",
                    "No")
                )
            {
                try
                {
                    if (PhoneDialer.Default.IsSupported)
                        PhoneDialer.Default.Open(translatedNumber);
                }
                catch (ArgumentNullException)
                {
                    await DisplayAlert("Unable to dial", "Phone number was not valid.", "OK");
                }
                catch (Exception)
                {
                    // Other error has occurred.
                    await DisplayAlert("Unable to dial", "Phone dialing failed.", "OK");
                }
            }
        }


    }
}