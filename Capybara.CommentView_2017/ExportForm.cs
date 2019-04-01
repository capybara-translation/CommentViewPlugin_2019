using System.Windows.Forms;
using Capybara.CommentView_2017.Models;

namespace Capybara.CommentView_2017
{
    public partial class ExportForm : Form
    {
        public ExportForm(ExportOptions exportOptions)
        {
            InitializeComponent();
            this.exportOptionsBindingSource.DataSource = exportOptions;
        }
    }
}
