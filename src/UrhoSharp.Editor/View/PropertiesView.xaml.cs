using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using UrhoSharp.Editor.Annotations;

namespace UrhoSharp.Editor.View
{
    /// <summary>
    ///     Interaction logic for PropertiesView.xaml
    /// </summary>
    public partial class PropertiesView : UserControl, INotifyPropertyChanged
    {
        public static readonly DependencyProperty NameWidthProperty =
            DependencyProperty.Register("NameWidth", typeof(GridLength), typeof(PropertiesView), new
                PropertyMetadata(GridLength.Auto, new PropertyChangedCallback(OnNameWidthChanged)));

        private static void OnNameWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((PropertiesView)d).OnPropertyChanged(nameof(NameWidth));
        }
        public GridLength NameWidth
        {
            get { return (GridLength)GetValue(NameWidthProperty); }
            set { SetValue(NameWidthProperty, value); }
        }

        //public static readonly DependencyProperty NumRowsProperty = DependencyProperty.RegisterAttached(
        //    "NumRows",
        //    typeof(int),
        //    typeof(Grid),
        //    new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender)
        //);
        //public static void SetNumRows(UIElement element, int value)
        //{
        //    element.SetValue(NumRowsProperty, value);
        //}
        //public static int GetNumRows(UIElement element)
        //{
        //    return (int)element.GetValue(NumRowsProperty);
        //}

        public PropertiesView()
        {
            InitializeComponent();
        }

        private void UpdateNameWidth(object sender, EventArgs e)
        {
            NameWidth = new GridLength(_nameWidth.ActualWidth);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}