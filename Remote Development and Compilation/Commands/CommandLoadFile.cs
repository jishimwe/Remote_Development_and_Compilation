using Microsoft.VisualStudio.Shell;
using System.Threading.Tasks;

namespace Remote_Development_and_Compilation
{
    [Command("<insert guid from .vsct file>", 0x0100)]
    internal sealed class CommandLoadFile : BaseCommand<CommandLoadFile>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            await VS.MessageBox.ShowWarningAsync("CommandLoadFile", "File loaded");
        }
    }
}
