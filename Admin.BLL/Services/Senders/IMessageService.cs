using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Models.Enums;

namespace Admin.BLL.Services.Senders
{
    public interface IMessageService
    {
        MessageStates MessageState { get; }
        Task SendAsync{ IdentityMessage mesage, params string[] contacts
    };

}
}
