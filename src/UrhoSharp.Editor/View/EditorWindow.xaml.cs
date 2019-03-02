using System.IO;
using System.Windows;
using Autofac;
using Urho;
using Urho.Extensions.Wpf;
using UrhoSharp.Editor.Model;
using UrhoSharp.Editor.ViewModel;

namespace UrhoSharp.Editor.View
{
    /// <summary>
    ///     Interaction logic for EditorWindow.xaml
    /// </summary>
    public partial class EditorWindow : Window
    {
        private readonly ILifetimeScope _scope;

        public EditorWindow()
        {
            InitializeComponent();
        }

        private async void ShowApp(object sender, RoutedEventArgs e)
        {
            await _urhoContainer.Show<EditorApp>(new ApplicationOptions(Path.Combine(ViewModel.Path,"Data")));
        }

        private EditorViewModel ViewModel
        {
            get { return DataContext as EditorViewModel; }
        }

        public EditorWindow(EditorViewModel vm, ILifetimeScope scope) : this()
        {
            _scope = scope;
            DataContext = vm;
            Loaded += ShowApp;
            Closed += (s, args) => _scope.Dispose();
        }
    }
}