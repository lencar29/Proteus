using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using AgencyAlchemy.Core.Data;
using AgencyAlchemy.Core.Utility;


namespace AgencyAlchemy
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            UserPathManager sapd = new UserPathManager("SuperAdmin");
            UserPathManager aapd = new UserPathManager("AgencyAdmin");
            UserPathManager capd = new UserPathManager("ClientAdmin");
            UserPathManager cmpd = new UserPathManager("ClientManager");
            UserPathManager tmpd = new UserPathManager("TalentManager");
            UserPathManager tpd = new UserPathManager("Talent");
            UserPathManager apd = new UserPathManager("Applicant");

            sapd.AddActionDetails("Dashboard", "Home");
            aapd.AddActionDetails("Dashboard", "Agency" );
            capd.AddActionDetails("Main", "Home"); //TODO: Create client admin landing page
            cmpd.AddActionDetails("Main", "Home"); //TODO: Create client manager landing page
            tmpd.AddActionDetails("Main", "Home"); //TODO: Create talent manager landing page
            tpd.AddActionDetails("Main", "Home"); //TODO: Create talent landing page
            apd.AddActionDetails("Main", "Home"); //TODO: Create applicant landing page

            sapd.Add(aapd);
            aapd.Add(capd);
            capd.Add(cmpd);
            cmpd.Add(tmpd);
            tmpd.Add(tpd);
            tpd.Add(apd);

            Application.Add("UserPathManager", sapd);

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            if (Session.Count == 0)
            {
                Agency agency = Agency.GetAgencyByDomain("login.motivatedmodels.com"); //TODO:Grab host from URL or subdomain name

                Session.Add("Host", agency.agency_url);
                Session.Add("AgencyID", agency.agency_pk);
                Session.Add("AgencyName", agency.agency_name);
                Session.Add("AgencyTitle", agency.agency_home_title);
                Session.Add("AgencyHomeText", agency.agency_home_text);
                Session.Add("AgencyLocation", agency.agency_location_name);
                Session.Add("AgencyLocationUrl", agency.agency_location_url);
                Session.Add("AgencyLocationLat", agency.agency_location_lat);
                Session.Add("AgencyLocationLong", agency.agency_location_long);
                Session.Add("AgencyYoutube", agency.agency_home_youtube);
                Session.Add("AgencyFacebook", agency.agency_social_facebook);
                Session.Add("AgencyGooglePlus", agency.agency_social_gplus);

                String logoPath = (agency.agency_has_logo) ? String.Format("~/Public/Agency/{0}/Logo/logo_thumb.jpg", agency.agency_pk): null;
                String favicon = (agency.agency_has_favicon) ? String.Format("~/Public/Agency/{0}/Favicon/favicon.ico", agency.agency_pk): null;

                Session.Add("LogoThumb", logoPath);
                Session.Add("Favicon", favicon);

            }
        }

        void Application_Error(object sender, EventArgs e)
        {
            var error = Server.GetLastError();
            var code = (error is HttpException) ? (error as HttpException).GetHttpCode() : 500;
            var httpContext = HttpContext.Current;

            if (code != 404)
                //TODO: Add error logger            

            Response.Clear();
            Server.ClearError();

            string path = Request.Path;
            Context.RewritePath(string.Format("~/Error/Http{0}", code), false);

            try
            {
                httpContext.Server.TransferRequest(string.Format("~/Error/Http{0}", code));
            }
            catch (InvalidProgramException) { }

            Context.RewritePath(path, false);
        }

        void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            HttpCookie authCookie = Context.Request.Cookies[FormsAuthentication.FormsCookieName];

            if (authCookie != null)
            {
                FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);

                string[] roles = authTicket.UserData.Split(new Char[] { ',' });
               
                GenericPrincipal userPrincipal = new GenericPrincipal(new GenericIdentity(authTicket.Name), roles);                               

                Context.User = userPrincipal;
            }
        }
    }
}
