using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SomulecoXamarinForms
{
    public partial class UnauthenticatedTabsPage : TabbedPage
    {
        public UnauthenticatedTabsPage()
        {
            InitializeComponent();



            var welcomePage = new NavigationPage(new WelcomePage());
            welcomePage.Title = "Welcome";

            var explorePage = new NavigationPage(new ExplorePage());
            explorePage.Title = "Explore";

            var libraryPage = new NavigationPage(new LibraryPage());
            libraryPage.Title = "Library";

            Children.Add(welcomePage);
            Children.Add(explorePage);
            Children.Add(libraryPage);
        }
    }
}
