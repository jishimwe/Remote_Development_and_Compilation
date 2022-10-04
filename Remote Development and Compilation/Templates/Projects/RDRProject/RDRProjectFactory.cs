using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Flavor;
using Microsoft.VisualStudio.Shell.Interop;

namespace Remote_Development_and_Compilation.Templates.Projects.RDRProject
{
    [Guid(RDRProjectPackage.RDRProjectFactoryString)]
    //class RDRProjectFactory : FlavoredProjectFactory
    class RDRProjectFactory : IVsProjectFactory
    {
        private RDRProjectPackage rdrProjectPackage;

        public RDRProjectFactory(RDRProjectPackage rdrProjectPackage)
        {
            this.rdrProjectPackage = rdrProjectPackage;
        }

/*        protected override object PreCreateForOuter(object outerProject)
        {
            return null;
        }*/

        public int CanCreateProject(string pszFilename, uint grfCreateFlags, out int pfCanCreate)
        {
            Console.WriteLine("Can I Create project");

            pfCanCreate = grfCreateFlags == 4 ? VSConstants.E_FAIL : VSConstants.S_OK;
            return pfCanCreate;
        }

        public int CreateProject(string pszFilename, string pszLocation, string pszName, uint grfCreateFlags, ref Guid iidProject, out IntPtr ppvProject, out int pfCanceled)
        {
            throw new NotImplementedException();
        }

        public int SetSite(Microsoft.VisualStudio.OLE.Interop.IServiceProvider psp)
        {
            throw new NotImplementedException();
        }

        public int Close()
        {
            throw new NotImplementedException();
        }
    }
}
