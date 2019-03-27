using Urho;

namespace UrhoSharp.Editor.Model
{
    public class LogMessage
    {
        public LogMessage(UnhandledExceptionEventArgs e)
        {
            Message = e.Exception?.Message;
        }

        public LogMessage(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}