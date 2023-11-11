namespace picture_box_SxS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel = new TableLayoutPanel();
            pictureBoxSrce_1 = new PictureBox();
            pictureBoxSrce_2 = new PictureBox();
            pictureBoxSrce_3 = new PictureBox();
            mainPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel = new FlowLayoutPanel();
            buttonShowByName = new Button();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSrce_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSrce_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSrce_3).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel.Controls.Add(pictureBoxSrce_1, 0, 0);
            tableLayoutPanel.Controls.Add(pictureBoxSrce_2, 1, 0);
            tableLayoutPanel.Controls.Add(pictureBoxSrce_3, 2, 0);
            tableLayoutPanel.Location = new Point(49, 32);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(241, 67);
            tableLayoutPanel.TabIndex = 0;
            // 
            // pictureBoxSrce_1
            // 
            pictureBoxSrce_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxSrce_1.BackColor = Color.FromArgb(0, 41, 245);
            pictureBoxSrce_1.Location = new Point(4, 4);
            pictureBoxSrce_1.Name = "pictureBoxSrce_1";
            pictureBoxSrce_1.Size = new Size(74, 59);
            pictureBoxSrce_1.TabIndex = 0;
            pictureBoxSrce_1.TabStop = false;
            // 
            // pictureBoxSrce_2
            // 
            pictureBoxSrce_2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxSrce_2.BackColor = Color.FromArgb(242, 54, 32);
            pictureBoxSrce_2.Location = new Point(85, 4);
            pictureBoxSrce_2.Name = "pictureBoxSrce_2";
            pictureBoxSrce_2.Size = new Size(74, 59);
            pictureBoxSrce_2.TabIndex = 0;
            pictureBoxSrce_2.TabStop = false;
            // 
            // pictureBoxSrce_3
            // 
            pictureBoxSrce_3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxSrce_3.BackColor = Color.FromArgb(255, 255, 241);
            pictureBoxSrce_3.Location = new Point(166, 4);
            pictureBoxSrce_3.Name = "pictureBoxSrce_3";
            pictureBoxSrce_3.Size = new Size(74, 59);
            pictureBoxSrce_3.TabIndex = 0;
            pictureBoxSrce_3.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Location = new Point(3, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(673, 353);
            mainPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(mainPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel, 0, 2);
            tableLayoutPanel1.Location = new Point(49, 127);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(679, 738);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel.Location = new Point(3, 382);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(673, 353);
            flowLayoutPanel.TabIndex = 2;
            // 
            // buttonShowByName
            // 
            buttonShowByName.Location = new Point(49, 886);
            buttonShowByName.Name = "buttonShowByName";
            buttonShowByName.Size = new Size(180, 34);
            buttonShowByName.TabIndex = 4;
            buttonShowByName.Text = "Show By Name";
            buttonShowByName.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 944);
            Controls.Add(buttonShowByName);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSrce_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSrce_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSrce_3).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private PictureBox pictureBoxSrce_1;
        private PictureBox pictureBoxSrce_2;
        private PictureBox pictureBoxSrce_3;
        private Panel mainPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel;
        private Button buttonShowByName;
    }
}