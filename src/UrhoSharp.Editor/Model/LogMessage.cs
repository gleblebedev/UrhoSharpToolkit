using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urho;

namespace UrhoSharp.Editor.Model
{
    public class LogMessage
    {
        private string _message;

        public LogMessage(Urho.UnhandledExceptionEventArgs e)
        {
            _message = e.Exception?.Message;
        }

        public string Message
        {
            get { return _message; }
        }
    }
}
