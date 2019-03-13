using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using UrhoSharp.Editor.Annotations;

namespace UrhoSharp.Editor.Model
{
    public class ImageSourceContainer : INotifyPropertyChanged
    {

        public ImageSourceContainer()
        {
            
        }
        public ImageSourceContainer(ImageSource source)
        {
            _imageSource = source;
        }
        private ImageSource _imageSource;

        public ImageSource ImageSource
        {
            get => _imageSource;
            set
            {
                if (_imageSource != value)
                {
                    _imageSource = value;
                    OnPropertyChanged(nameof(ImageSource));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}