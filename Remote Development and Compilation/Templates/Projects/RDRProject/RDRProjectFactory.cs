using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Flavor;

namespace Remote_Development_and_Compilation.Templates.Projects.RDRProject
{
    [Guid(RDRProjectPackage.RDRProjectFactoryString)]
    class RDRProjectFactory : FlavoredProjectFactory
    {
        private RDRProjectPackage rdrProjectPackage;

        public RDRProjectFactory(RDRProjectPackage rdrProjectPackage)
        {
            this.rdrProjectPackage = rdrProjectPackage;
        }

        protected override object PreCreateForOuter(object outerProject)
        {
            return null;
        }
    }
}
