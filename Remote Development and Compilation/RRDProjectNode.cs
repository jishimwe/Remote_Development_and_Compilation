// Seems to be deprecated/broken?

/*using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.Project;
using Remote_Development_and_Compilation;

namespace Remote_Development_and_Compilation
{
    public class RDRProjectNode : ProjectNode
    {
        private RDRProjectPackage _package;

        public SimpleProjectNode(RDRProjectPackage package)
        {
            this._package = package;
        }
        public override Guid ProjectGuid
        {
            get { return RDRProjectPackage.guidSimpleProjectFactory; }
        }
        public override string ProjectType
        {
            get { return "RDRProjectType"; }
        }

        public override void AddFileFromTemplate(
            string source, string target)
        {
            this.FileTemplateProcessor.UntokenFile(source, target);
            this.FileTemplateProcessor.Reset();
        }
    }
}*/