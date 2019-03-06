using System.Windows;
using UrhoSharp.Editor.ViewModel;

namespace UrhoSharp.Editor.View
{
    /// <summary>
    ///     Interaction logic for ExportPackageWindow.xaml
    /// </summary>
    public partial class ExportPackageWindow : Window
    {
        public ExportPackageWindow()
        {
            InitializeComponent();
        }
        public ExportPackageWindow(ExportPackageViewModel vm):this()
        {
            DataContext = vm;
        }

        private ExportPackageViewModel ViewModel
        {
            get { return DataContext as ExportPackageViewModel; }
        }

        private void Ok(object sender, RoutedEventArgs e)
        {
            if (ViewModel.Validate())
            {
                DialogResult = true;
            }

        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}