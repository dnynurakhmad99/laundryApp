using SakananeWash.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakananeWash.Controller
{
    class ControllerChat
    {
        private Model.ModelChat chat;
        private View.IsiChat isiChat;

        public ControllerChat(View.IsiChat isiChat)
        {
            this.isiChat = isiChat;
            chat = new Model.ModelChat();
        }

        public void TeksChat()
        {
            chat.IsiChat = isiChat.txtChat.Text;

            bool result = chat.TeksChat();
            if (result == true)
            {
                isiChat.NavigationService.Navigate(new View.IsiChat());
            }

            else
            {
                isiChat.NavigationService.Navigate(new View.IsiChat());
            }
        }
    }
}
