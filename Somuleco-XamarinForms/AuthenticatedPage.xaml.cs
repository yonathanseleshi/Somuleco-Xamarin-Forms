using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SomulecoXamarinForms
{
    public partial class AuthenticatedPage : MasterDetailPage
    {
        DrawerMasterPage masterPage;

        public AuthenticatedPage()
        {
            InitializeComponent();
            MasterBehavior = MasterBehavior.Popover;

            masterPage = new DrawerMasterPage();

            Master = masterPage;

            Detail = new NavigationPage(new LearningFeedPage());
        }
    }
}
