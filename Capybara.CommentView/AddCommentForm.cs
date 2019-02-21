using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capybara.CommentView
{
    public partial class AddCommentForm : Form
    {
        public string CommentText { get; private set; }

        public AddCommentForm()
        {
            InitializeComponent();
        }

        private void AddCommentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                CommentText = commentTextBox.Text;
            }
        }
    }
}
