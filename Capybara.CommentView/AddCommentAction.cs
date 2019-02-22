using System.Windows.Forms;
using Capybara.CommentView.Models;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.FileTypeSupport.Framework.NativeApi;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using Sdl.TranslationStudioAutomation.IntegrationApi.Presentation.DefaultLocations;

namespace Capybara.CommentView
{
    [Action("CapybaraCommentView_AddCommentAction", typeof(EditorController), Name = "Add_Comment_Action_Name",
        Description = "Add_Comment_Action_Description", Icon = "CommentViewPlugin_Icon")]
    [ActionLayout(typeof(TranslationStudioDefaultContextMenus.EditorDocumentContextMenuLocation), 1, DisplayType.Large)
    ]
    public class AddCommentAction : AbstractViewControllerAction<EditorController>
    {
        protected override void Execute()
        {
            var editorController = SdlTradosStudio.Application.GetController<EditorController>();
            var document = editorController.ActiveDocument;
            var activeSegmentPair = document?.ActiveSegmentPair;
            if (activeSegmentPair == null)
            {
                return;
            }

            string commentText = null;
            using (var dialog = new AddCommentForm())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    commentText = dialog.CommentText;
                }
            }

            if (string.IsNullOrWhiteSpace(commentText))
            {
                return;
            }

            var commentInfo = new CommentInfo
            {
                Author = "commentview",
                Text = commentText,
                Severity = Severity.Low,
            };

            if (!document.Selection.Source.IsEmpty)
            {
                var fromInfo = document.Selection.Source.From;
                var uptoInfo = document.Selection.Source.UpTo;
                if (document.Selection.Source.IsReversed)
                {
                    commentInfo.From = uptoInfo.CursorPosition;
                    commentInfo.UpTo = fromInfo.CursorPosition;
                }
                else
                {
                    commentInfo.From = fromInfo.CursorPosition;
                    commentInfo.UpTo = uptoInfo.CursorPosition;
                }
            }
            var visitor = new SourceCommentVisitor(commentInfo);
            visitor.VisitSegment(activeSegmentPair.Source);

            //var commentProperties = document.PropertiesFactory.CreateCommentProperties();
            //var comment = document.PropertiesFactory.CreateComment(commentText, "commentview", Severity.Low);
            //commentProperties.Add(comment);
            //var commentMarker = document.ItemFactory.CreateCommentMarker(commentProperties);
            //activeSegmentPair.Source.MoveAllItemsTo(commentMarker);
            //activeSegmentPair.Source.Clear();
            //activeSegmentPair.Source.Add(commentMarker);
            document.UpdateSegmentPair(activeSegmentPair);
        }
    }
}