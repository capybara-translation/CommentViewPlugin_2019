﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Capybara.CommentView.Models;
using Sdl.ProjectAutomation.Core;

namespace Capybara.CommentView
{
    public static class CommentExtractor
    {
        private static readonly XNamespace Sdl = @"http://sdl.com/FileTypes/SdlXliff/1.0";
        private static readonly XNamespace Xlf = @"urn:oasis:names:tc:xliff:document:1.2";

        public static IList<CommentEntry> Extract(ProjectFile projectFile)
        {
            var commentEntries = new List<CommentEntry>();
            using (var reader = new XmlTextReader(projectFile.LocalFilePath))
            {
                reader.XmlResolver = null;
                while (reader.Read())
                {
                    if (reader.IsStartElement("doc-info", Sdl.NamespaceName))
                    {
                        commentEntries.AddRange(ExtractComments(reader));
                    }
                    if (!reader.IsStartElement("file", Xlf.NamespaceName))
                    {
                        continue;
                    }

                    foreach (
                        var tu in
                            StreamXElements(reader, "trans-unit", "body").Where(e => e.Element(Xlf + "target") != null))
                    {
                        var srcMrks =
                            tu.Element(Xlf + "seg-source")
                                .Descendants(Xlf + "mrk")
                                .Where(e => ((string) e.Attribute("mtype")) == "seg");
                        var trgMrks =
                            tu.Element(Xlf + "target")
                                .Descendants(Xlf + "mrk")
                                .Where(e => ((string) e.Attribute("mtype")) == "seg")
                                .ToList();
                        var paragraphId = (string) tu.Attribute("id");
                        foreach (var srcMrk in srcMrks)
                        {
                            var mid = srcMrk.Attribute("mid").Value;
                            var trgMrk = trgMrks.FirstOrDefault(e => ((string) e.Attribute("mid")) == mid);
                            if (trgMrk == null)
                            {
                                continue;
                            }
                            // Get all the comment IDs contained in the current source mrk and target mrk.
                            var commentIDs =
                                srcMrk.Descendants(Xlf + "mrk")
                                    .Where(e => ((string) e.Attribute("mtype") == "x-sdl-comment"))
                                    .Select(e => (string) e.Attribute(Sdl + "cid"))
                                    .Concat(
                                        trgMrk.Descendants(Xlf + "mrk")
                                            .Where(e => ((string) e.Attribute("mtype") == "x-sdl-comment"))
                                            .Select(e => (string) e.Attribute(Sdl + "cid")))
                                    .ToList();

                            if (commentIDs.Count == 0)
                            {
                                continue;
                            }

                            mid = mid.Replace("_x0020_", " ");
                            foreach (var commentEntry in commentEntries.Where(e => commentIDs.Contains(e.Id)))
                            {
                                commentEntry.SegmentId = mid;
                                commentEntry.ParagraphId = paragraphId;
                                commentEntry.SourceSegment = BuildSegment(srcMrk, commentEntry.Id);
                                commentEntry.TargetSegment = BuildSegment(trgMrk, commentEntry.Id);
                                commentEntry.SourceText =
                                    commentEntry.SourceSegment.Aggregate(new StringBuilder(),
                                        (builder, e) => builder.Append(e.Value)).ToString();
                                commentEntry.TargetText = 
                                    commentEntry.TargetSegment.Aggregate(new StringBuilder(),
                                        (builder, e) => builder.Append(e.Value)).ToString();
                            }
                        }
                    }
                }
            }
            foreach (var commentEntry in commentEntries)
            {
                commentEntry.ProjectFile = projectFile;
                commentEntry.FileName = projectFile.Folder + projectFile.Name;
                if (string.IsNullOrEmpty(commentEntry.ParagraphId))
                {
                    commentEntry.ParagraphId = null;
                    commentEntry.SegmentId = null;
                    commentEntry.SourceSegment = null;
                    commentEntry.TargetSegment = null;
                    commentEntry.SourceText = null;
                    commentEntry.TargetText = null;
                }
            }
            return commentEntries;
        }

        private static List<ISegmentElement> BuildSegment(XElement mrkElement, string cid)
        {
            var elements = new List<ISegmentElement>();
            foreach (var textNode in mrkElement.DescendantNodes().OfType<XText>())
            {
                var ancestors =
                    textNode.Ancestors(Xlf + "mrk")
                        .Where(e => cid == (string) e.Attribute(Sdl + "cid"));
                if (ancestors.Any())
                {
                    elements.Add(new CommentElement
                    {
                        Value = textNode.Value
                    });
                }
                else
                {
                    elements.Add(new TextElement
                    {
                        Value = textNode.Value
                    });
                }
            }
            return elements;
        }


        private static IEnumerable<XElement> StreamXElements(XmlTextReader reader, string name, string end)
        {
            while (reader.Read())
            {
                if (reader.LocalName == name)
                {
                    using (var subreader = reader.ReadSubtree())
                    {
                        subreader.MoveToContent();
                        var el = XNode.ReadFrom(subreader) as XElement;
                        if (el != null)
                        {
                            yield return el;
                        }
                    }
                }
                if (end != null)
                {
                    if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName == end)
                    {
                        yield break;
                    }
                }
            }
        }

        private static List<CommentEntry> ExtractComments(XmlTextReader reader)
        {
            var comments = new List<CommentEntry>();
            if (reader.ReadToDescendant("cmt-defs", Sdl.NamespaceName))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName == "cmt-defs")
                    {
                        break;
                    }
                    if (reader.NodeType == XmlNodeType.Whitespace)
                    {
                        continue;
                    }
                    if (reader.NodeType == XmlNodeType.Element && reader.LocalName == "cmt-def")
                    {
                        var id = reader.GetAttribute("id");
                        while (reader.Read())
                        {
                            if (reader.NodeType == XmlNodeType.EndElement &&
                                reader.LocalName == "cmt-def")
                            {
                                break;
                            }
                            if (reader.NodeType == XmlNodeType.Whitespace)
                            {
                                continue;
                            }
                            if (reader.NodeType == XmlNodeType.Element && reader.LocalName == "Comment")
                            {
                                comments.Add(new CommentEntry
                                {
                                    Id = id,
                                    Author = reader.GetAttribute("user") ?? string.Empty,
                                    Date = reader.GetAttribute("date") ?? string.Empty,
                                    Severity = reader.GetAttribute("severity") ?? string.Empty,
                                    Version = reader.GetAttribute("version") ?? string.Empty,
                                    Text = reader.ReadString()
                                });
                            }
                        }
                    }
                }
            }
            return comments;
        }
    }
}