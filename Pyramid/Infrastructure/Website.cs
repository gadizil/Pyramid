using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pyramid.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid.Infrastructure
{
    public static class Website
    {

        public static MainPage GoToSignInPage()
        {
            return new MainPage();
        }

        internal static ProfilePage GoToProfilePage()
        {
            return new ProfilePage();
        }

        internal static ConnectionPage GoToConnections()
        {
            return new ConnectionPage();
        }
    }
}
