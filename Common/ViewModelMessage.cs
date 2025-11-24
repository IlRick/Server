using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ViewModelMessage
    {
        public string TypeMessage { get; set; }
        public string Message { get; set; }

        public ViewModelMessage()
        {
            TypeMessage = "";
            Message = "";
        }

        public ViewModelMessage(string typeMessage, string message)
        {
            TypeMessage = typeMessage;
            Message = message;
        }
    }
}
