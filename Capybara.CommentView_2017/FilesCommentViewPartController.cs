using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capybara.CommentView_2017.Models;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;

namespace Capybara.CommentView_2017
{
    [ViewPart(
        Id = "FilesCommentViewPart",
        Name = "Plugin_Name",
        Description = "Plugin_Description",
        Icon = "CommentViewPlugin_Icon")]
    [ViewPartLayout(typeof(FilesController), Dock = DockType.Bottom)]
    class FilesCommentViewPartController : AbstractViewPartController
    {
        private CommentService _commentService;
        protected override Control GetContentControl()
        {
            return Control.Value;
        }

        protected override void Initialize()
        {
            _commentService = new CommentService();
            var filesController = SdlTradosStudio.Application.GetController<FilesController>();
            filesController.SelectedFilesChanged += async (sender, args) =>
            {
                Control.Value.ShowLoadingProgressBar(true);
                var result = await Task.Run(() =>
                {
                    return _commentService.GetCommentsFromProjectFiles(filesController.SelectedFiles);
                });
                Control.Value.SetContent(result);
                Control.Value.ShowLoadingProgressBar(false);
            };

        }


        private static readonly Lazy<FilesCommentViewPartControl> Control = new Lazy<FilesCommentViewPartControl>(() => new FilesCommentViewPartControl());
    }
}
