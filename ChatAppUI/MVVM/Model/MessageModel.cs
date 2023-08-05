using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppUI.MVVM.Model
{
    public class MessageModel
    {
        public string userName { get; set; }
        public string userNameColor { get; set; }
        public string imageSource { get; set; }
        public string message { get; set; }
        public DateTime time { get; set; }
        public bool isNativeOrigin { get; set; }
        public bool firstMessage { get; set; }
    }
}
