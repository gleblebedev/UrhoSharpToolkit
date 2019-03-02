using System.Windows;
using UrhoSharp.Editor.ViewModel;

namespace UrhoSharp.Editor.View
{
    /// <summary>
    ///     Interaction logic for HubWindow.xaml
    /// </summary>
    public partial class HubWindow : Window
    {
        public HubWindow()
        {
            InitializeComponent();
        }

        public HubWindow(HubWindowViewModel vm) : this()
        {
            DataContext = vm;
        }
    }
}