using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;

namespace AgencyAlchemy.Core.Utility
{
    public class TicketManager
    {
        public static HttpCookie CreateAuthCookie(String name, String data)
        {
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, name, DateTime.Now, DateTime.Now.AddMinutes(30), false, data);
            String cookieInfo = FormsAuthentication.Encrypt(ticket);
            FormsAuthentication.SetAuthCookie(cookieInfo, false);

            return new HttpCookie(FormsAuthentication.FormsCookieName, cookieInfo);
        }

        public static HttpCookie CreateCookie(String name, String data, String cookieName)
        {
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, name, DateTime.Now, DateTime.Now.AddDays(30), true, data);
            String cookieInfo = FormsAuthentication.Encrypt(ticket);

             return new HttpCookie(cookieName, cookieInfo);
        }

        public static void ExpireCookie(HttpCookie cookie)
        {
            if(cookie != null)
                cookie.Expires = DateTime.Now.AddMonths(-12);
        }
    }
}
