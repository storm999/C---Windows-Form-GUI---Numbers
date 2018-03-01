namespace Numbers
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.randomGen = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.RadioButton();
            this.sortedGen = new System.Windows.Forms.Button();
            this.shuffle = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.linearSearch = new System.Windows.Forms.RadioButton();
            this.binarySearch = new System.Windows.Forms.RadioButton();
            this.delete = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.insertBox = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.unsorted = new System.Windows.Forms.RadioButton();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
            this.orDrag = new System.Windows.Forms.Label();
            this.binBox = new System.Windows.Forms.PictureBox();
            this.howManyy = new System.Windows.Forms.TextBox();
            this.genInsertSorted = new System.Windows.Forms.Button();
            this.sortedInsert = new System.Windows.Forms.CheckBox();
            this.toolStripContainer4 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer5 = new System.Windows.Forms.ToolStripContainer();
            this.logs = new System.Windows.Forms.ListBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.toolStripContainer3.ContentPanel.SuspendLayout();
            this.toolStripContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binBox)).BeginInit();
            this.toolStripContainer4.SuspendLayout();
            this.toolStripContainer5.ContentPanel.SuspendLayout();
            this.toolStripContainer5.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.AccessibleDescription = "";
            this.listBox.AccessibleName = "";
            this.listBox.AllowDrop = true;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(23, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(50, 394);
            this.listBox.TabIndex = 0;
            this.listBox.Tag = "";
            this.listBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // randomGen
            // 
            this.randomGen.Location = new System.Drawing.Point(104, 14);
            this.randomGen.Name = "randomGen";
            this.randomGen.Size = new System.Drawing.Size(68, 36);
            this.randomGen.TabIndex = 1;
            this.randomGen.Text = "Generate Random";
            this.randomGen.UseVisualStyleBackColor = true;
            this.randomGen.Click += new System.EventHandler(this.randomGen_Click);
            // 
            // sort
            // 
            this.sort.AutoSize = true;
            this.sort.Enabled = false;
            this.sort.Location = new System.Drawing.Point(81, 5);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(56, 17);
            this.sort.TabIndex = 2;
            this.sort.TabStop = true;
            this.sort.Text = "Sorted";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // sortedGen
            // 
            this.sortedGen.Location = new System.Drawing.Point(104, 82);
            this.sortedGen.Name = "sortedGen";
            this.sortedGen.Size = new System.Drawing.Size(144, 38);
            this.sortedGen.TabIndex = 4;
            this.sortedGen.Text = "Clean && Initialise Sorted\r\n(More Efficent)";
            this.sortedGen.UseVisualStyleBackColor = true;
            this.sortedGen.Click += new System.EventHandler(this.sortedGen_Click);
            // 
            // shuffle
            // 
            this.shuffle.Enabled = false;
            this.shuffle.Location = new System.Drawing.Point(136, 283);
            this.shuffle.Name = "shuffle";
            this.shuffle.Size = new System.Drawing.Size(75, 23);
            this.shuffle.TabIndex = 5;
            this.shuffle.Text = "Shuffle";
            this.shuffle.UseVisualStyleBackColor = true;
            this.shuffle.Click += new System.EventHandler(this.shuffle_Click);
            // 
            // clear
            // 
            this.clear.Enabled = false;
            this.clear.Location = new System.Drawing.Point(98, 383);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(179, 383);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // linearSearch
            // 
            this.linearSearch.AutoSize = true;
            this.linearSearch.Enabled = false;
            this.linearSearch.Location = new System.Drawing.Point(5, 8);
            this.linearSearch.Name = "linearSearch";
            this.linearSearch.Size = new System.Drawing.Size(54, 17);
            this.linearSearch.TabIndex = 8;
            this.linearSearch.TabStop = true;
            this.linearSearch.Text = "Linear";
            this.linearSearch.UseVisualStyleBackColor = true;
            // 
            // binarySearch
            // 
            this.binarySearch.AutoSize = true;
            this.binarySearch.Enabled = false;
            this.binarySearch.Location = new System.Drawing.Point(79, 8);
            this.binarySearch.Name = "binarySearch";
            this.binarySearch.Size = new System.Drawing.Size(54, 17);
            this.binarySearch.TabIndex = 9;
            this.binarySearch.TabStop = true;
            this.binarySearch.Text = "Binary";
            this.binarySearch.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Enabled = false;
            this.delete.Location = new System.Drawing.Point(3, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(70, 20);
            this.delete.TabIndex = 10;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Enabled = false;
            this.searchTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.searchTextBox.Location = new System.Drawing.Point(3, 34);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(70, 20);
            this.searchTextBox.TabIndex = 11;
            this.searchTextBox.Text = "Search";
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // search
            // 
            this.search.Enabled = false;
            this.search.Location = new System.Drawing.Point(79, 34);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(70, 20);
            this.search.TabIndex = 12;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // insertBox
            // 
            this.insertBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.insertBox.Location = new System.Drawing.Point(104, 167);
            this.insertBox.Name = "insertBox";
            this.insertBox.Size = new System.Drawing.Size(68, 20);
            this.insertBox.TabIndex = 14;
            this.insertBox.Text = "Insert";
            this.insertBox.Enter += new System.EventHandler(this.insertBox_Enter);
            this.insertBox.Leave += new System.EventHandler(this.insertBox_Leave);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(178, 167);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(70, 20);
            this.insert.TabIndex = 15;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.unsorted);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.sort);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(156, 30);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(97, 247);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(156, 30);
            this.toolStripContainer1.TabIndex = 16;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // unsorted
            // 
            this.unsorted.AutoSize = true;
            this.unsorted.Enabled = false;
            this.unsorted.Location = new System.Drawing.Point(5, 6);
            this.unsorted.Name = "unsorted";
            this.unsorted.Size = new System.Drawing.Size(68, 17);
            this.unsorted.TabIndex = 5;
            this.unsorted.TabStop = true;
            this.unsorted.Text = "Unsorted";
            this.unsorted.UseVisualStyleBackColor = true;
            this.unsorted.CheckedChanged += new System.EventHandler(this.unsorted_CheckedChanged);
            // 
            // toolStripContainer2
            // 
            this.toolStripContainer2.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolStripContainer2.ContentPanel.Controls.Add(this.linearSearch);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.binarySearch);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.searchTextBox);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.search);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(156, 61);
            this.toolStripContainer2.LeftToolStripPanelVisible = false;
            this.toolStripContainer2.Location = new System.Drawing.Point(97, 311);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.RightToolStripPanelVisible = false;
            this.toolStripContainer2.Size = new System.Drawing.Size(156, 61);
            this.toolStripContainer2.TabIndex = 17;
            this.toolStripContainer2.Text = "toolStripContainer2";
            this.toolStripContainer2.TopToolStripPanelVisible = false;
            // 
            // toolStripContainer3
            // 
            // 
            // toolStripContainer3.ContentPanel
            // 
            this.toolStripContainer3.ContentPanel.AllowDrop = true;
            this.toolStripContainer3.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolStripContainer3.ContentPanel.Controls.Add(this.orDrag);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.binBox);
            this.toolStripContainer3.ContentPanel.Controls.Add(this.delete);
            this.toolStripContainer3.ContentPanel.Size = new System.Drawing.Size(156, 28);
            this.toolStripContainer3.ContentPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.toolStripContainer3_ContentPanel_DragDrop);
            this.toolStripContainer3.ContentPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.toolStripContainer3_ContentPanel_DragEnter_1);
            this.toolStripContainer3.Location = new System.Drawing.Point(97, 208);
            this.toolStripContainer3.Name = "toolStripContainer3";
            this.toolStripContainer3.Size = new System.Drawing.Size(156, 28);
            this.toolStripContainer3.TabIndex = 18;
            this.toolStripContainer3.Text = "toolStripContainer3";
            // 
            // orDrag
            // 
            this.orDrag.AutoSize = true;
            this.orDrag.Location = new System.Drawing.Point(75, 6);
            this.orDrag.Name = "orDrag";
            this.orDrag.Size = new System.Drawing.Size(40, 13);
            this.orDrag.TabIndex = 24;
            this.orDrag.Text = "or drag";
            // 
            // binBox
            // 
            this.binBox.Image = global::Numbers.Properties.Resources.bin;
            this.binBox.Location = new System.Drawing.Point(118, -2);
            this.binBox.Name = "binBox";
            this.binBox.Size = new System.Drawing.Size(28, 28);
            this.binBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.binBox.TabIndex = 24;
            this.binBox.TabStop = false;
            // 
            // howManyy
            // 
            this.howManyy.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.howManyy.Location = new System.Drawing.Point(136, 56);
            this.howManyy.Name = "howManyy";
            this.howManyy.Size = new System.Drawing.Size(75, 20);
            this.howManyy.TabIndex = 19;
            this.howManyy.Text = "How Many";
            this.howManyy.Enter += new System.EventHandler(this.howManyy_Enter);
            this.howManyy.Leave += new System.EventHandler(this.howManyy_Leave);
            // 
            // genInsertSorted
            // 
            this.genInsertSorted.Location = new System.Drawing.Point(185, 14);
            this.genInsertSorted.Name = "genInsertSorted";
            this.genInsertSorted.Size = new System.Drawing.Size(63, 36);
            this.genInsertSorted.TabIndex = 20;
            this.genInsertSorted.Text = "Generate Sorted";
            this.genInsertSorted.UseVisualStyleBackColor = true;
            this.genInsertSorted.Click += new System.EventHandler(this.genInsertSorted_Click);
            // 
            // sortedInsert
            // 
            this.sortedInsert.AutoSize = true;
            this.sortedInsert.Enabled = false;
            this.sortedInsert.Location = new System.Drawing.Point(5, 4);
            this.sortedInsert.Name = "sortedInsert";
            this.sortedInsert.Size = new System.Drawing.Size(86, 17);
            this.sortedInsert.TabIndex = 21;
            this.sortedInsert.Text = "Sorted Insert";
            this.sortedInsert.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer4
            // 
            // 
            // toolStripContainer4.ContentPanel
            // 
            this.toolStripContainer4.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolStripContainer4.ContentPanel.Size = new System.Drawing.Size(156, 93);
            this.toolStripContainer4.Location = new System.Drawing.Point(97, 9);
            this.toolStripContainer4.Name = "toolStripContainer4";
            this.toolStripContainer4.Size = new System.Drawing.Size(156, 118);
            this.toolStripContainer4.TabIndex = 22;
            this.toolStripContainer4.Text = "toolStripContainer4";
            // 
            // toolStripContainer5
            // 
            // 
            // toolStripContainer5.ContentPanel
            // 
            this.toolStripContainer5.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolStripContainer5.ContentPanel.Controls.Add(this.sortedInsert);
            this.toolStripContainer5.ContentPanel.Size = new System.Drawing.Size(156, 62);
            this.toolStripContainer5.Location = new System.Drawing.Point(97, 138);
            this.toolStripContainer5.Name = "toolStripContainer5";
            this.toolStripContainer5.Size = new System.Drawing.Size(156, 62);
            this.toolStripContainer5.TabIndex = 23;
            this.toolStripContainer5.Text = "toolStripContainer5";
            // 
            // logs
            // 
            this.logs.FormattingEnabled = true;
            this.logs.Items.AddRange(new object[] {
            "Logs:"});
            this.logs.Location = new System.Drawing.Point(285, 12);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(290, 394);
            this.logs.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 431);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.genInsertSorted);
            this.Controls.Add(this.howManyy);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.insertBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.shuffle);
            this.Controls.Add(this.sortedGen);
            this.Controls.Add(this.randomGen);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.toolStripContainer2);
            this.Controls.Add(this.toolStripContainer3);
            this.Controls.Add(this.toolStripContainer4);
            this.Controls.Add(this.toolStripContainer5);
            this.Name = "Form1";
            this.Text = "Numbers";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.toolStripContainer3.ContentPanel.ResumeLayout(false);
            this.toolStripContainer3.ContentPanel.PerformLayout();
            this.toolStripContainer3.ResumeLayout(false);
            this.toolStripContainer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binBox)).EndInit();
            this.toolStripContainer4.ResumeLayout(false);
            this.toolStripContainer4.PerformLayout();
            this.toolStripContainer5.ContentPanel.ResumeLayout(false);
            this.toolStripContainer5.ContentPanel.PerformLayout();
            this.toolStripContainer5.ResumeLayout(false);
            this.toolStripContainer5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button randomGen;
        private System.Windows.Forms.RadioButton sort;
        private System.Windows.Forms.Button sortedGen;
        private System.Windows.Forms.Button shuffle;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RadioButton linearSearch;
        private System.Windows.Forms.RadioButton binarySearch;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox insertBox;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer3;
        private System.Windows.Forms.RadioButton unsorted;
        private System.Windows.Forms.TextBox howManyy;
        private System.Windows.Forms.Button genInsertSorted;
        private System.Windows.Forms.CheckBox sortedInsert;
        private System.Windows.Forms.ToolStripContainer toolStripContainer4;
        private System.Windows.Forms.ToolStripContainer toolStripContainer5;
        private System.Windows.Forms.PictureBox binBox;
        private System.Windows.Forms.Label orDrag;
        private System.Windows.Forms.ListBox logs;
    }
}

