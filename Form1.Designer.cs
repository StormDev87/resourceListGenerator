﻿
namespace createResourceText
{
  partial class Form1
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
      this.btnOpenDir = new System.Windows.Forms.Button();
      this.dgvList = new System.Windows.Forms.DataGridView();
      this.dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Start = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.comment = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.typeIncl = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.tbPath = new System.Windows.Forms.TextBox();
      this.btnGenResource = new System.Windows.Forms.Button();
      this.btnClipBoard = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.aBCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnOpenDir
      // 
      this.btnOpenDir.Location = new System.Drawing.Point(11, 138);
      this.btnOpenDir.Name = "btnOpenDir";
      this.btnOpenDir.Size = new System.Drawing.Size(116, 29);
      this.btnOpenDir.TabIndex = 0;
      this.btnOpenDir.Text = "Seleziona cartella";
      this.btnOpenDir.UseVisualStyleBackColor = true;
      this.btnOpenDir.Click += new System.EventHandler(this.btnEvent_Click);
      // 
      // dgvList
      // 
      this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dir,
            this.Start,
            this.comment,
            this.typeIncl});
      this.dgvList.Location = new System.Drawing.Point(12, 172);
      this.dgvList.Name = "dgvList";
      this.dgvList.RowTemplate.Height = 25;
      this.dgvList.Size = new System.Drawing.Size(1109, 457);
      this.dgvList.TabIndex = 1;
      // 
      // dir
      // 
      this.dir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dir.HeaderText = "Cartella";
      this.dir.Name = "dir";
      // 
      // Start
      // 
      this.Start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.Start.HeaderText = "Inclusione";
      this.Start.Name = "Start";
      this.Start.Width = 67;
      // 
      // comment
      // 
      this.comment.HeaderText = "commentato";
      this.comment.Name = "comment";
      // 
      // typeIncl
      // 
      this.typeIncl.HeaderText = "Tipo Inclusione";
      this.typeIncl.Items.AddRange(new object[] {
            "start",
            "ensure"});
      this.typeIncl.Name = "typeIncl";
      // 
      // tbPath
      // 
      this.tbPath.Location = new System.Drawing.Point(132, 138);
      this.tbPath.Multiline = true;
      this.tbPath.Name = "tbPath";
      this.tbPath.Size = new System.Drawing.Size(296, 28);
      this.tbPath.TabIndex = 2;
      // 
      // btnGenResource
      // 
      this.btnGenResource.Location = new System.Drawing.Point(888, 138);
      this.btnGenResource.Name = "btnGenResource";
      this.btnGenResource.Size = new System.Drawing.Size(233, 28);
      this.btnGenResource.TabIndex = 4;
      this.btnGenResource.Text = ">> Genera porzione File resource";
      this.btnGenResource.UseVisualStyleBackColor = true;
      this.btnGenResource.Click += new System.EventHandler(this.btnEvent_Click);
      // 
      // btnClipBoard
      // 
      this.btnClipBoard.Location = new System.Drawing.Point(649, 138);
      this.btnClipBoard.Name = "btnClipBoard";
      this.btnClipBoard.Size = new System.Drawing.Size(233, 28);
      this.btnClipBoard.TabIndex = 5;
      this.btnClipBoard.Text = ">> Copy To ClipBoard";
      this.btnClipBoard.UseVisualStyleBackColor = true;
      this.btnClipBoard.Click += new System.EventHandler(this.btnEvent_Click);
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.Location = new System.Drawing.Point(13, 636);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1108, 40);
      this.panel1.TabIndex = 6;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBCToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1131, 24);
      this.menuStrip1.TabIndex = 7;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // aBCToolStripMenuItem
      // 
      this.aBCToolStripMenuItem.Name = "aBCToolStripMenuItem";
      this.aBCToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
      this.aBCToolStripMenuItem.Text = "ABC";
      this.aBCToolStripMenuItem.Click += new System.EventHandler(this.aBCToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1131, 678);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.btnClipBoard);
      this.Controls.Add(this.btnGenResource);
      this.Controls.Add(this.tbPath);
      this.Controls.Add(this.dgvList);
      this.Controls.Add(this.btnOpenDir);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOpenDir;
    private System.Windows.Forms.DataGridView dgvList;
    private System.Windows.Forms.TextBox tbPath;
    private System.Windows.Forms.Button btnGenResource;
    private System.Windows.Forms.DataGridViewTextBoxColumn dir;
    private System.Windows.Forms.DataGridViewCheckBoxColumn Start;
    private System.Windows.Forms.DataGridViewCheckBoxColumn comment;
    private System.Windows.Forms.DataGridViewComboBoxColumn typeIncl;
    private System.Windows.Forms.Button btnClipBoard;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem aBCToolStripMenuItem;
  }
}

