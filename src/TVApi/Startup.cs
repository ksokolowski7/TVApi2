using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using TVApi.Providers;
using Microsoft.Owin.Cors;
using System.Threading.Tasks;
using System.Web.Cors;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.Facebook;
using TVApi.Utils;

[assembly: OwinStartup(typeof(TVApi.Startup))]

namespace TVApi
{
        public partial class Startup
        {
            public void Configuration(IAppBuilder app)
            {
                ConfigureOAuth(app);
            }
        }
}
