using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Filmagine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //readonly DispatcherTimer _timer = new DispatcherTimer();
        //private void Timer_Tick(object sender,EventArgs e)
        //{
        //    _timer.Stop();
        //    intro.Visibility = Visibility.Collapsed;
        //}
        //private void DisplayIntro()
        //{
        //    _timer.Tick += Timer_Tick;
        //    _timer.Interval = new TimeSpan(0, 0, 0, 6);
        //    _timer.Start();
        //}
        public MainWindow()
        {
            InitializeComponent();
            
            //intro.Source = new Uri($@"\GraphicResources\intro.mp4");
            //DisplayIntro();
            
        }

    }



}
