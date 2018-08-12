namespace Capybara.CommentView
{
    partial class CommentViewPartControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.commentsDGV = new System.Windows.Forms.DataGridView();
            this.fileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.commentsTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.sourceRTB = new System.Windows.Forms.RichTextBox();
            this.targetRTB = new System.Windows.Forms.RichTextBox();
            this.filesTab = new System.Windows.Forms.TabPage();
            this.filesDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paragraphIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.severityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.showExportFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.commentsDGV)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.commentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.filesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileEntryBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // commentsDGV
            // 
            this.commentsDGV.AllowUserToAddRows = false;
            this.commentsDGV.AllowUserToDeleteRows = false;
            this.commentsDGV.AllowUserToOrderColumns = true;
            this.commentsDGV.AllowUserToResizeRows = false;
            this.commentsDGV.AutoGenerateColumns = false;
            this.commentsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.commentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.paragraphIdDataGridViewTextBoxColumn,
            this.segmentIdDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.sourceTextDataGridViewTextBoxColumn,
            this.targetTextDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.severityDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn});
            this.commentsDGV.DataSource = this.commentEntryBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.commentsDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.commentsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.commentsDGV.Location = new System.Drawing.Point(0, 0);
            this.commentsDGV.Name = "commentsDGV";
            this.commentsDGV.RowHeadersVisible = false;
            this.commentsDGV.RowTemplate.Height = 21;
            this.commentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.commentsDGV.Size = new System.Drawing.Size(641, 295);
            this.commentsDGV.TabIndex = 0;
            this.commentsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commentsDGV_CellDoubleClick);
            this.commentsDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.commentsDGV_CellFormatting);
            this.commentsDGV.SelectionChanged += new System.EventHandler(this.commentsDGV_SelectionChanged);
            this.commentsDGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commentsDGV_KeyDown);
            // 
            // fileDataGridViewTextBoxColumn
            // 
            this.fileDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileDataGridViewTextBoxColumn.HeaderText = "File";
            this.fileDataGridViewTextBoxColumn.Name = "fileDataGridViewTextBoxColumn";
            this.fileDataGridViewTextBoxColumn.Width = 250;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.commentsTab);
            this.mainTabControl.Controls.Add(this.filesTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(3, 3);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(874, 327);
            this.mainTabControl.TabIndex = 1;
            // 
            // commentsTab
            // 
            this.commentsTab.Controls.Add(this.splitContainer1);
            this.commentsTab.Location = new System.Drawing.Point(4, 22);
            this.commentsTab.Name = "commentsTab";
            this.commentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.commentsTab.Size = new System.Drawing.Size(866, 301);
            this.commentsTab.TabIndex = 0;
            this.commentsTab.Text = "Comments";
            this.commentsTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.commentsDGV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(860, 295);
            this.splitContainer1.SplitterDistance = 641;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.sourceRTB);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.targetRTB);
            this.splitContainer2.Size = new System.Drawing.Size(215, 295);
            this.splitContainer2.SplitterDistance = 143;
            this.splitContainer2.TabIndex = 0;
            // 
            // sourceRTB
            // 
            this.sourceRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceRTB.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sourceRTB.Location = new System.Drawing.Point(0, 0);
            this.sourceRTB.Name = "sourceRTB";
            this.sourceRTB.ReadOnly = true;
            this.sourceRTB.Size = new System.Drawing.Size(215, 143);
            this.sourceRTB.TabIndex = 0;
            this.sourceRTB.Text = "";
            // 
            // targetRTB
            // 
            this.targetRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetRTB.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.targetRTB.Location = new System.Drawing.Point(0, 0);
            this.targetRTB.Name = "targetRTB";
            this.targetRTB.ReadOnly = true;
            this.targetRTB.Size = new System.Drawing.Size(215, 148);
            this.targetRTB.TabIndex = 0;
            this.targetRTB.Text = "";
            // 
            // filesTab
            // 
            this.filesTab.Controls.Add(this.filesDGV);
            this.filesTab.Location = new System.Drawing.Point(4, 22);
            this.filesTab.Name = "filesTab";
            this.filesTab.Padding = new System.Windows.Forms.Padding(3);
            this.filesTab.Size = new System.Drawing.Size(754, 246);
            this.filesTab.TabIndex = 1;
            this.filesTab.Text = "Files";
            this.filesTab.UseVisualStyleBackColor = true;
            // 
            // filesDGV
            // 
            this.filesDGV.AllowUserToAddRows = false;
            this.filesDGV.AllowUserToDeleteRows = false;
            this.filesDGV.AllowUserToOrderColumns = true;
            this.filesDGV.AllowUserToResizeRows = false;
            this.filesDGV.AutoGenerateColumns = false;
            this.filesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commentsDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn});
            this.filesDGV.DataSource = this.fileEntryBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.filesDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.filesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.filesDGV.Location = new System.Drawing.Point(3, 3);
            this.filesDGV.Name = "filesDGV";
            this.filesDGV.RowHeadersVisible = false;
            this.filesDGV.RowTemplate.Height = 21;
            this.filesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filesDGV.Size = new System.Drawing.Size(748, 240);
            this.filesDGV.TabIndex = 0;
            this.filesDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filesDGV_CellDoubleClick);
            this.filesDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.filesDGV_CellFormatting);
            this.filesDGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filesDGV_KeyDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 20;
            // 
            // paragraphIdDataGridViewTextBoxColumn
            // 
            this.paragraphIdDataGridViewTextBoxColumn.DataPropertyName = "ParagraphId";
            this.paragraphIdDataGridViewTextBoxColumn.HeaderText = "ParagraphId";
            this.paragraphIdDataGridViewTextBoxColumn.Name = "paragraphIdDataGridViewTextBoxColumn";
            this.paragraphIdDataGridViewTextBoxColumn.Visible = false;
            this.paragraphIdDataGridViewTextBoxColumn.Width = 71;
            // 
            // segmentIdDataGridViewTextBoxColumn
            // 
            this.segmentIdDataGridViewTextBoxColumn.DataPropertyName = "SegmentId";
            dataGridViewCellStyle1.NullValue = "N/A";
            this.segmentIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.segmentIdDataGridViewTextBoxColumn.HeaderText = "Segment ID";
            this.segmentIdDataGridViewTextBoxColumn.Name = "segmentIdDataGridViewTextBoxColumn";
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.textDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.textDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.Width = 500;
            // 
            // sourceTextDataGridViewTextBoxColumn
            // 
            this.sourceTextDataGridViewTextBoxColumn.DataPropertyName = "SourceText";
            this.sourceTextDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceTextDataGridViewTextBoxColumn.Name = "sourceTextDataGridViewTextBoxColumn";
            this.sourceTextDataGridViewTextBoxColumn.Visible = false;
            this.sourceTextDataGridViewTextBoxColumn.Width = 250;
            // 
            // targetTextDataGridViewTextBoxColumn
            // 
            this.targetTextDataGridViewTextBoxColumn.DataPropertyName = "TargetText";
            this.targetTextDataGridViewTextBoxColumn.HeaderText = "Target";
            this.targetTextDataGridViewTextBoxColumn.Name = "targetTextDataGridViewTextBoxColumn";
            this.targetTextDataGridViewTextBoxColumn.Visible = false;
            this.targetTextDataGridViewTextBoxColumn.Width = 250;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 64;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle3.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 120;
            // 
            // severityDataGridViewTextBoxColumn
            // 
            this.severityDataGridViewTextBoxColumn.DataPropertyName = "Severity";
            this.severityDataGridViewTextBoxColumn.HeaderText = "Severity";
            this.severityDataGridViewTextBoxColumn.Name = "severityDataGridViewTextBoxColumn";
            this.severityDataGridViewTextBoxColumn.Width = 72;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.Width = 69;
            // 
            // commentEntryBindingSource
            // 
            this.commentEntryBindingSource.DataSource = typeof(Capybara.CommentView.Models.CommentEntry);
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.commentsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.Width = 120;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "File";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            // 
            // fileEntryBindingSource
            // 
            this.fileEntryBindingSource.DataSource = typeof(Capybara.CommentView.Models.FileEntry);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mainTabControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.showExportFormButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 362);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // showExportFormButton
            // 
            this.showExportFormButton.AutoSize = true;
            this.showExportFormButton.Location = new System.Drawing.Point(3, 336);
            this.showExportFormButton.Name = "showExportFormButton";
            this.showExportFormButton.Size = new System.Drawing.Size(112, 23);
            this.showExportFormButton.TabIndex = 2;
            this.showExportFormButton.Text = "Export Comments...";
            this.showExportFormButton.UseVisualStyleBackColor = true;
            this.showExportFormButton.Click += new System.EventHandler(this.showExportFormButton_Click);
            // 
            // CommentViewPartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CommentViewPartControl";
            this.Size = new System.Drawing.Size(880, 362);
            ((System.ComponentModel.ISupportInitialize)(this.commentsDGV)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.commentsTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.filesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileEntryBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView commentsDGV;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage commentsTab;
        private System.Windows.Forms.TabPage filesTab;
        private System.Windows.Forms.DataGridView filesDGV;
        private System.Windows.Forms.BindingSource fileEntryBindingSource;
        private System.Windows.Forms.BindingSource commentEntryBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox sourceRTB;
        private System.Windows.Forms.RichTextBox targetRTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paragraphIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn severityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button showExportFormButton;
    }
}
