using Avalonia.Controls;
using Avalonia.Threading;
using System.Threading;

namespace Test_Avalonia_Window_Size_Bug.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            new Thread(() =>
            {
                Thread.Sleep(5000);
                Dispatcher.UIThread.Post(() =>
                {
                    Title = $"{Width}x{Height}";
                });
            }).Start();
        }
    }
}
