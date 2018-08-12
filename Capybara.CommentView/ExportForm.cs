using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capybara.CommentView.Models;

namespace Capybara.CommentView
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
