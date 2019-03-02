using System.Windows;
using Autofac;
using Urho.Extensions.Wpf;
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
            _urhoContainer.Children.Add(new UrhoSurface());
        }

        public EditorWindow(EditorViewModel vm, ILifetimeScope scope) : this()
        {
            _scope = scope;
            DataContext = vm;
            Closed += (s, args) => _scope.Dispose();
        }
    }
}