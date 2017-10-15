using Models.Framework;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Core;
using Movie_DB.Ninject;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new MovieModule());

            IEngine engine = kernel.Get<Engine>();
            engine.Start();
        }
    }
}
