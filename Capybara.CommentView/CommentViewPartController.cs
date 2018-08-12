using System;
using System.Windows.Forms;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;

namespace Capybara.CommentView
{
    [ViewPart(
        Id = "CommentViewPart",
        Name = "Plugin_Name",
        Description = "Plugin_Description",
        Icon = "CommentViewPlugin_Icon")]
    [ViewPartLayout(typeof(FilesController), Dock = DockType.Bottom)]
    class CommentViewPartController : AbstractViewPartController
    {
        protected override Control GetContentControl()
        {
            return Control.Value;
        }

        protected override void Initialize()
        {
            
        }

        private static readonly Lazy<CommentViewPartControl> Control = new Lazy<CommentViewPartControl>(() => new CommentViewPartControl());
    }
}
