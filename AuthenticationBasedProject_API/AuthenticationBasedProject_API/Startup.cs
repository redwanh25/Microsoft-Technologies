﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;


[assembly: OwinStartup(typeof(AuthenticationBasedProject_API.Startup))]

namespace AuthenticationBasedProject_API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
