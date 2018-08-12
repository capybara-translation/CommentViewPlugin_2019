using System.Collections.Generic;
using Sdl.ProjectAutomation.Core;

namespace Capybara.CommentView.Models
{
    public class CommentEntry : ModelBase
    {
        private ProjectFile _projectFile;

        public ProjectFile ProjectFile
        {
            get { return _projectFile; }
            set
            {
                _projectFile = value;
                OnPropertyChanged("ProjectFile");
            }
        }

        private string _fileName;

        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                OnPropertyChanged("FileName");
            }
        }
        private string _id;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        private string _author;

        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                OnPropertyChanged("Author");
            }
        }

        private string _date;

        public string Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged("Date");
            }
        }

        private string _severity;

        public string Severity
        {
            get { return _severity; }
            set
            {
                _severity = value;
                OnPropertyChanged("Severity");
            }
        }

        private string _version;

        public string Version
        {
            get { return _version; }
            set
            {
                _version = value;
                OnPropertyChanged("Version");
            }
        }

        private string _paragraphId;

        public string ParagraphId
        {
            get { return _paragraphId; }
            set
            {
                _paragraphId = value;
                OnPropertyChanged("ParagraphId");
            }
        }

        private string _segmentId;

        public string SegmentId
        {
            get { return _segmentId; }
            set
            {
                _segmentId = value;
                OnPropertyChanged("SegmentId");
            }
        }

        private List<ISegmentElement> _sourceSegment;

        public List<ISegmentElement> SourceSegment
        {
            get { return _sourceSegment; }
            set
            {
                _sourceSegment = value;
                OnPropertyChanged("SourceSegment");
            }
        }

        private string _sourceText;

        public string SourceText
        {
            get { return _sourceText; }
            set
            {
                _sourceText = value;
                OnPropertyChanged("SourceText");
            }
        }


        private List<ISegmentElement> _targetSegment;

        public List<ISegmentElement> TargetSegment
        {
            get { return _targetSegment; }
            set
            {
                _targetSegment = value;
                OnPropertyChanged("TargetSegment");
            }
        }

        private string _targetText;

        public string TargetText
        {
            get { return _targetText; }
            set
            {
                _targetText = value;
                OnPropertyChanged("TargetText");
            }
        }

        public override string Error
        {
            get { return null; }
        }
    }
}