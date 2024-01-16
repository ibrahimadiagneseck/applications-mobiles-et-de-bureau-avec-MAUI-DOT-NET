# applications-mobiles-et-de-bureau-avec-MAUI-DOT-NET

https://learn.microsoft.com/fr-fr/training/paths/build-apps-with-dotnet-maui/



NET MAUI est une infrastructure multi-plateforme permettant de créer des applications mobiles et de bureau natives avec C# et XAML. .NET MAUI est un acronyme de .NET Multi-Platform App UI (interface utilisateur d’application multi-plateforme). .NET MAUI vous permet de concevoir des applications mobiles qui peuvent s’exécuter sur Windows, Android, iOS, iPadOS et macOS.


Objectifs d’apprentissage

Découvrir l’architecture de base de .NET MAUI.
Créer une application .NET MAUI.
Définir une IU partagée pour les plateformes prises en charge par .NET MAUI.
Déployer une application .NET MAUI à partir de Visual Studio.
Accéder aux API de plateforme à l’aide de .NET MAUI.


Quel est le contenu d’un projet .NET MAUI ?
Pour récapituler, un projet .NET MAUI contient initialement les éléments suivants :

Le fichier MauiProgram.cs contenant le code pour la création et la configuration de l’objet Application.

Les fichiers App.xaml et App.xaml.cs qui fournissent des ressources d’interface utilisateur et créent la fenêtre initiale pour l’application.

Les fichiers AppShell.xaml et AppShell.xaml.cs qui spécifient la page initiale de l’application et gèrent l’inscription des pages pour le routage de la navigation.

Les fichiers MainPage.xaml et MainPage.xaml.cs qui définissent la disposition et la logique de l’interface utilisateur de la page affichée par défaut dans la fenêtre initiale.




-----------------------------------------------------------------------------------------------------------------------
Classe d’application
La classe App représente l’application .NET MAUI dans son ensemble. Elle hérite de Microsoft.Maui.Controls.Application d’un ensemble de comportements par défaut. Rappelez-vous, comme indiqué dans l’unité précédente, qu’il s’agit de la classe App que le code d’amorçage instancie et charge pour chaque plateforme. Le constructeur de classe App, à son tour, crée généralement une instance de la classe AppShell, et l’affecte à la propriété MainPage. C’est ce code qui contrôle le premier écran que l’utilisateur voit au travers de ce qui est défini dans AppShell.

La classe App contient également les éléments suivants :

Des méthodes pour la gestion des événements de cycle de vie, notamment quand l’application est envoyée en arrière-plan (c’est-à-dire quand elle cesse d’être l’application située au premier plan).

Des méthodes pour la création de Windows pour l’application. L’application .NET MAUI a une seule fenêtre par défaut, mais vous pouvez créer et lancer des fenêtres supplémentaires, ce qui est utile dans les applications de bureau et pour tablettes.


-----------------------------------------------------------------------------------------------------------------------
Shell
.NET MAUI Shell (.NET Multi-platform App UI) réduit la complexité du développement d’applications en fournissant les fonctionnalités fondamentales dont la plupart des applications ont besoin, à savoir :

Un emplacement unique pour décrire la hiérarchie visuelle d’une application.
Une expérience utilisateur de navigation commune.
Un schéma de navigation basé sur l’URI qui permet de naviguer vers n’importe quelle page de l’application.
Un gestionnaire de recherche intégré.
Dans une application .NET MAUI Shell, la hiérarchie visuelle de l’application est décrite dans une classe, qui est une sous-classe de la classe Shell. Cette classe peut se composer de trois objets hiérarchiques principaux :

FlyoutItem ou TabBar. Un FlyoutItem représente un ou plusieurs éléments dans le menu volant, et doit être utilisé quand le modèle de navigation de l’application nécessite un menu volant. Un TabBar représente la barre d’onglets inférieure, et doit être utilisé quand le modèle de navigation de l’application commence par des onglets inférieurs et qu’il ne nécessite pas de menu volant.
Tab, qui représente le contenu regroupé, accessible via les onglets inférieurs.
ShellContent, qui représente les objets ContentPage de chaque onglet.
Ces objets ne représentent pas une interface utilisateur, mais plutôt l’organisation de la hiérarchie visuelle de l’application. Shell utilise ces objets afin de produire l’interface utilisateur de navigation pour le contenu.

-----------------------------------------------------------------------------------------------------------------------
Pages
Les pages constituent la racine de la hiérarchie d’interface utilisateur dans .NET MAUI à l’intérieur d’un Shell. La solution que nous avons vue jusqu’à présent comprend une classe nommée MainPage. Cette classe est dérivée de ContentPage, qui est le type de page le plus simple et le plus courant. Une page de contenu affiche simplement son contenu. .NET MAUI comprend également plusieurs autres types de page intégrés, à savoir :

TabbedPage : il s’agit de la page racine utilisée pour la navigation par onglets. Une page à onglets contient des objets page enfants, un pour chaque onglet.

FlyoutPage : cette page vous permet d’implémenter une présentation de style maître/détails. Une page de menu volant contient une liste d’éléments. Lorsque vous sélectionnez un élément, un affichage présentant les détails de cet élément s’affiche.

D’autres types de pages sont disponibles, qui servent principalement à activer différents modèles de navigation dans des applications multi-écrans.

-----------------------------------------------------------------------------------------------------------------------
Les vues
Une page de contenu présente généralement un affichage. Un affichage vous permet de récupérer et de présenter des données d’une manière spécifique. L’affichage par défaut d’une page de contenu est un ContentView qui présente les éléments tels quels. Si vous réduisez la vue, les éléments peuvent disparaître de l’affichage jusqu’à ce que vous redimensionniez la vue. Un ScrollView vous permet d’afficher des éléments dans une fenêtre de défilement. Si vous réduisez la fenêtre, vous pouvez la faire défiler vers le haut et le bas pour afficher les éléments. Un CarouselView est un affichage déroulant qui permet à l’utilisateur de parcourir une collection d’éléments. Un CollectionView peut extraire des données d’une source de données nommée et présenter chaque élément en utilisant un modèle en tant que format. Il existe de nombreux autres types de vues disponibles.

-----------------------------------------------------------------------------------------------------------------------
Contrôles et dispositions
Un affichage peut contenir un seul contrôle, tel qu’un bouton, une étiquette ou des zones de texte (À proprement parler, une vue est elle-même un contrôle. Une vue peut donc en contenir une autre.) Toutefois, une interface utilisateur limitée à un seul contrôle n’est pas très utile, c’est pourquoi les contrôles sont positionnés dans une disposition. Une disposition définit les règles régissant l’affichage des contrôles les uns par rapport aux autres. Une disposition étant également un contrôle, vous pouvez l’ajouter à un affichage. Si vous examinez le fichier MainPage.xaml par défaut, vous verrez cette hiérarchie page/affichage/disposition/contrôle à l’œuvre. Dans ce code XAML, l’élément VerticalStackLayout est simplement un autre contrôle qui vous permet d’affiner la disposition d’autres contrôles.

XML

Copier
<ContentPage ...>
    <ScrollView ...>
        <VerticalStackLayout>
            <Image ... />
            <Label ... />
            <Label ... />
            <Button ... />
        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
Voici quelques-uns des contrôles courants utilisés pour définir des dispositions :

VerticalStackLayout et HorizontalStackLayout sont des dispositions de pile optimisées, qui placent les contrôles dans une pile de haut en bas ou de gauche à droite. Un StackLayout est également disponible, et a une propriété nommée StackOrientation à laquelle vous pouvez affecter Horizontal ou Vertical. Sur une tablette ou un téléphone, la modification de cette propriété dans le code de votre application vous permet d’ajuster l’affichage si l’utilisateur fait pivoter l’appareil :

A diagram of how the horizontal and vertical orientations for the stack layout will lay out controls.

AbsoluteLayout qui vous permet de définir des coordonnées exactes pour les contrôles.

FlexLayout qui est similaire à StackLayout, sauf qu’il vous permet d’encapsuler les contrôles enfants qu’il contient s’ils ne tiennent pas dans une seule ligne ou colonne. Cette disposition fournit également des options pour l’alignement et l’adaptation à différentes tailles d’écran. Par exemple, un contrôle FlexLayout peut aligner son contrôle enfant à gauche, à droite ou au centre quand il est disposé verticalement. En cas d’alignement horizontal, vous pouvez justifier les contrôles pour garantir un espacement régulier. Vous pourriez utiliser une disposition FlexLayout horizontale à l’intérieur d’un ScrollView pour afficher une série de cadres à défilement horizontal (chaque cadre pouvant lui-même être une disposition FlexLayout verticale) :

A screenshot from an app running with the FlexLayout rendered to the screen. First an image is rendered, then a title, then a text label then a button. All of those are rendered vertically within a box.

Grid qui dispose ses contrôles en fonction d’un emplacement de colonne et de ligne que nous avons défini. Vous pouvez définir les tailles de colonnes et de lignes ainsi que leurs étendues de manière à ce que les dispositions de grille ne ressemblent pas nécessairement à un « damier ».

L’image suivante récapitule les attributs clés de ces types de dispositions courants :

A diagram of the layouts most frequently used in a .NET MAUI UI.

La disposition de pile montre quatre boîtes placées verticalement. La disposition absolue montre quatre boîtes placées à l’écran exactement à l’endroit spécifié par le développeur. La disposition Flex montre plusieurs boîtes réparties sur l’écran pour offrir la meilleure utilisation possible de la zone d’écran. La disposition Grille montre plusieurs boîtes réparties sur l’écran selon un modèle de grille.

Tous les contrôles ont des propriétés. Vous pouvez définir des valeurs initiales de ces propriétés à l’aide du langage XAML. Dans de nombreux cas, vous pouvez modifier ces propriétés dans le code C# de votre application. Par exemple, le code qui gère l’événement Clicked pour le bouton Cliquer ici dans l’application .NET MAUI par défaut ressemble à ceci :

C#
int count = 0;
private void OnCounterClicked(object sender, EventArgs e)
{
    count+=5;

    if (count == 1)
        CounterBtn.Text = $"Clicked {count} time";
    else
        CounterBtn.Text = $"Clicked {count} times";

    SemanticScreenReader.Announce(CounterBtn.Text);
}
Ce code modifie la propriété Text du contrôle CounterBtn dans la page. Vous pouvez même créer des pages, affichages et dispositions entiers dans votre code sans avoir à utiliser le langage XAML. Prenons l’exemple de la définition XAML suivante d’une page :

XML
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="Phoneword.MainPage">

    <ScrollView>
        <VerticalStackLayout>
            <Label Text="Current count: 0"
                Grid.Row="0"
                FontSize="18"
                FontAttributes="Bold"
                x:Name="CounterLabel"
                HorizontalOptions="Center" />

            <Button Text="Click me"
                Grid.Row="1"
                Clicked="OnCounterClicked"
                HorizontalOptions="Center" />
        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
Le code équivalent en C# ressemble à ceci :

C#
public partial class TestPage : ContentPage
{
    int count = 0;
    
    // Named Label - declared as a member of the class
    Label counterLabel;

    public TestPage()
    {       
        var myScrollView = new ScrollView();

        var myStackLayout = new VerticalStackLayout();
        myScrollView.Content = myStackLayout;

        counterLabel = new Label
        {
            Text = "Current count: 0",
            FontSize = 18,
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center
        };
        myStackLayout.Children.Add(counterLabel);
        
        var myButton = new Button
        {
            Text = "Click me",
            HorizontalOptions = LayoutOptions.Center
        };
        myStackLayout.Children.Add(myButton);

        myButton.Clicked += OnCounterClicked;

        this.Content = myScrollView;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        counterLabel.Text = $"Current count: {count}";

        SemanticScreenReader.Announce(counterLabel.Text);
    }
}
Le code C# est plus détaillé, mais il offre une flexibilité supplémentaire qui vous permet d’adapter l’IU de manière dynamique.

Pour afficher cette page lorsque l’application commence à s’exécuter, définissez la classe TestPage dans le AppShell en tant que ShellContent principal :

XML
<ShellContent
        Title="Home"
        ContentTemplate="{DataTemplate local:TestPage}"
        Route="TestPage" />

-----------------------------------------------------------------------------------------------------------------------
Réglage d’une disposition
Il est utile d’ajouter un peu d’espace de respiration autour d’un contrôle. Chaque contrôle a une propriété Margin que les dispositions respectent. Vous pouvez considérer la marge comme un contrôle qui éloigne les autres.

Toutes les dispositions ont également une propriété Padding qui empêche leurs enfants de s’approcher de leur bordure. Pour vous représenter ce concept, imaginez que tous les contrôles se trouvent dans une boîte avec des parois capitonnées.

Un autre paramètre d’espace blanc utile est la propriété Spacing de la disposition VerticalStackLayout ou HorizontalStackLayout. Il s’agit de l’espace entre tous les enfants de la disposition. Celui-ci vient s’ajouter à la propre marge du contrôle. L’espace blanc réel correspond donc à la somme de la marge et de l’espacement.







Composer le numéro de téléphone
Dans le fichier code-behind MainPage.xaml.cs, modifiez la méthode OnCall et remplacez le commentaire TODO par les blocs try/catch suivants :

C#
async void OnCall(object sender, System.EventArgs e)
{
    if (await this.DisplayAlert(
        "Dial a Number",
        "Would you like to call " + translatedNumber + "?",
        "Yes",
        "No"))
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
La classe PhoneDialer dans l’espace de noms Microsoft.Maui.ApplicationModel.Communication fournit une abstraction de la fonctionnalité de numérotation (et d’autres) pour les plateformes Windows, Android, iOS (et iPadOS) et macOS. La méthode Open statique tente d’utiliser le numéroteur téléphonique pour appeler le numéro fourni en tant que paramètre.

Les étapes suivantes montrent comment mettre à jour le manifeste d’application Android pour permettre à Android d’utiliser le numéroteur téléphonique. Les applications Windows, iOS et MacCatalyst suivent le même principe général, sauf que vous spécifiez une fonctionnalité dépendante du système d’exploitation différente dans le manifeste.

Dans la fenêtre Explorateur de solutions, développez le dossier Plateformes, puis le dossier Android, cliquez avec le bouton droit sur le fichier AndroidManifest.xml, sélectionnez Ouvrir avec>Sélecteur automatique de l’éditeur (XML). Cliquez sur OK.

Ajoutez l’extrait de code XML suivant à l’intérieur du nœud manifest, après le contenu existant pour ce nœud.

XML
<?xml version="1.0" encoding="utf-8"?>
<manifest xmlns:android="http://schemas.android.com/apk/res/android">
    ...
    <queries>
        <intent>
            <action android:name="android.intent.action.DIAL" />
            <data android:scheme="tel"/>
        </intent>
    </queries>
</manifest>


Résumé
Dans cet exercice, vous avez ajouté une interface utilisateur personnalisée à votre application à l’aide de pages et d’affichages. Vous avez également ajouté un support pour passer un appel à l’aide d’API spécifiques de la plateforme disponibles dans Android.