using Microsoft.ServiceBus.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBackend
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Create a hub client using the DefaultFullSharedAccessSignature
            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString(
                "Endpoint=sb://sabbour.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=qqlk0PPmc0RAv/HgjMOAED3zAWQ+UqAGgupsn3JFHXM=",
                "myhub"
            );

            // Since we are using native notifications, we have to construct the payload in the format
            // the service is expecting. The example below is for sending a Toast notification on Windows 8
            var toast = @"<toast><visual><binding template=""ToastText01""><text id=""1"">" + TextBox1.Text + "</text></binding></visual></toast>";
            hub.SendWindowsNativeNotificationAsync(toast);
        }
    }
}