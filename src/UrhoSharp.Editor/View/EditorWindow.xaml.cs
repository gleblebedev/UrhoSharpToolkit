using System;
using System.IO;
using System.Windows;
using Autofac;
using Urho;
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

            MenuStyles.ItemsSource= new[] { "Dark", "White", "Gray" };
            MenuStyles.Click += SetStyle;
        }

        private void SetStyle(object sender, RoutedEventArgs e) {
            if( e.OriginalSource is System.Windows.Controls.MenuItem mi) {
                ResourceDictionary dir = new ResourceDictionary() {
                    Source = new Uri(@"View\Styles\" + mi.Header.ToString()+".xaml",UriKind.Relative)
                };

                System.Windows.Application.Current.Resources.MergedDictionaries.Clear();
                System.Windows.Application.Current.Resources.MergedDictionaries.Add(dir);

            }
            
        }

        public EditorWindow(EditorViewModel vm, ILifetimeScope scope) : this()
        {
            _scope = scope;
            DataContext = vm;
            Loaded += ShowApp;
            Closed += (s, args) => _scope.Dispose();
        }

        private EditorViewModel ViewModel => DataContext as EditorViewModel;

        public AssetsView AssetsView => _assetsView;

        private async void ShowApp(object sender, RoutedEventArgs e)
        {
            await _urhoContainer.Show<EditorApp>(new ApplicationOptions(Path.Combine(ViewModel.Path, "Data")));
        }
    }
}