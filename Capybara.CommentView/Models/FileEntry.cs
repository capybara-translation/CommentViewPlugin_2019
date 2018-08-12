using Sdl.ProjectAutomation.Core;

namespace Capybara.CommentView.Models
{
    public class FileEntry : ModelBase
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

        private int _comments;

        public int Comments
        {
            get { return _comments; }
            set
            {
                _comments = value;
                OnPropertyChanged("Comments");
            }
        }

        public override string Error
        {
            get { return null; }
        }
    }
}
