﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(task02.Startup))]
namespace task02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
