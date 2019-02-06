using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;

namespace Admin.BLL.Services.Senders
{
    public class EmailService IMessageService
    {
        private string _userId = HttpContext.Current.User.Identity.GetUserId();
        public string[] Cc { get; set; }
    }
}
