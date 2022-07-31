using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Avalonia_Window_Size_Bug.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        internal static double WinWidth { get => 1280; }

        internal static double WinHeight { get => 720; }
    }
}
