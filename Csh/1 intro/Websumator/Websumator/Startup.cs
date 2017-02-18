<<<<<<< HEAD
﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Websumator.Startup))]
namespace Websumator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
=======
﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Websumator.Startup))]
namespace Websumator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
>>>>>>> a133a25be30296e6ae9e8d9736acf3a888c9aa99
