
/*
    Written in C# using Visual Studio
    25.9.2020 made by Levoohks
    All rights Reserved!
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EasyMessages
{
    public class EasyMessageBox
    {

        public void informationBox(string text, string title) 
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void errorBox(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void warnBox(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public void questionBox(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButton.YesNo, MessageBoxImage.Question);
        }

    }
}
