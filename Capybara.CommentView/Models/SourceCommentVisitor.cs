using System.Collections.Generic;
using System.Linq;
using NPOI.OpenXmlFormats.Dml;
using Sdl.FileTypeSupport.Framework.BilingualApi;
using Sdl.FileTypeSupport.Framework.Core.Utilities.BilingualApi;
using Sdl.FileTypeSupport.Framework.NativeApi;

namespace Capybara.CommentView.Models
{
    public class SourceCommentVisitor : IMarkupDataVisitor
    {
        private readonly IDocumentItemFactory _itemFactory;
        private readonly List<IText> _itexts = new List<IText>();
        private readonly CommentInfo _commentInfo;
        public SourceCommentVisitor(CommentInfo commentInfo)
        {
            _itemFactory = DefaultDocumentItemFactory.CreateInstance();
            _commentInfo = commentInfo;
        }

        public void VisitTagPair(ITagPair tagPair)
        {
            VisitChildren(tagPair);
        }


        public void VisitText(IText text)
        {
            _itexts.Add(text);
        }

        public void VisitSegment(ISegment segment)
        {
            VisitChildren(segment);
            ApplyComment(segment);
        }
        private void VisitChildren(IAbstractMarkupDataContainer container)
        {
            foreach (var item in container)
            {
                item.AcceptVisitor(this);
            }
        }

        private IAbstractMarkupData CreateIText(string chunk)
        {
            var textProps = _itemFactory.PropertiesFactory.CreateTextProperties(chunk);
            return _itemFactory.CreateText(textProps);
        }

        private void ApplyComment(ISegment segment)
        {
            var textChars = new List<IAbstractMarkupData>();
            foreach (var itext in _itexts)
            {
                var rawText = itext.Properties.Text;
                var parent = itext.Parent;
                foreach (var c in rawText)
                {
                    var citext = CreateIText(c.ToString());
                    textChars.Add(citext);
                    parent.Add(citext);
                }
                itext.RemoveFromParent();
            }
            var commentProperties = _itemFactory.PropertiesFactory.CreateCommentProperties();
            var comment = _itemFactory.PropertiesFactory.CreateComment(_commentInfo.Text, _commentInfo.Author, _commentInfo.Severity);
            commentProperties.Add(comment);
            var commentMarker = _itemFactory.CreateCommentMarker(commentProperties);

            // add comment on entire segment
            if (!_commentInfo.From.HasValue || !_commentInfo.UpTo.HasValue || _commentInfo.From == _commentInfo.UpTo)  
            {
                segment.MoveAllItemsTo(commentMarker);
                segment.Clear();
                segment.Add(commentMarker);
            }
            else
            {
                //foreach (var c in textChars.Select(((c, i) => new {Char = c, Idx = i})))
                //{
                //    if ((int) _commentInfo.From <= c.Idx && c.Idx < (int) _commentInfo.UpTo)
                //    {
                //        c.Char.RemoveFromParent();
                //        commentMarker.Add(c.Char);
                //    }
                    
                //}
                int? idxToInsert = null;
                int offset = 0;
                foreach (var item in segment.AllSubItems.Select(((data, i) => new {Item = data, Idx = i})))
                {
                    if (item.Item is IText)
                    {
                        continue;
                    }

                    if (item.Idx <= _commentInfo.From)
                    {
                        offset++;
                    }
                }

                //_commentInfo.From += offset;
                //_commentInfo.UpTo += offset;
                //foreach (var idx in Enumerable.Range(0, segment.AllSubItems.Count(x => x is IText)))
                //{
                //    if ((int)_commentInfo.From <= idx && idx < (int)_commentInfo.UpTo)
                //    {
                //        segment.MoveItemsTo(commentMarker, idx - offset, 1);
                //        if (!idxToInsert.HasValue)
                //        {
                //            idxToInsert = idx;
                //        }
                //        offset++;
                //    }
                //}
                segment.MoveItemsTo(commentMarker, (int)_commentInfo.From, (int)(_commentInfo.UpTo - _commentInfo.From));
                segment.Insert((int)_commentInfo.From, commentMarker);

                //if (idxToInsert.HasValue)
                //{
                //    segment.Insert(idxToInsert.Value, commentMarker);
                //}
                //else
                //{
                //    segment.Insert(0, commentMarker);
                //}
            }
        }

        public void VisitPlaceholderTag(IPlaceholderTag tag)
        {
        }

        public void VisitLocationMarker(ILocationMarker location)
        {
        }

        public void VisitCommentMarker(ICommentMarker commentMarker)
        {
            VisitChildren(commentMarker);
        }

        public void VisitOtherMarker(IOtherMarker marker)
        {
        }

        public void VisitLockedContent(ILockedContent lockedContent)
        {
        }

        public void VisitRevisionMarker(IRevisionMarker revisionMarker)
        {
        }
    }
}