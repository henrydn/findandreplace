﻿using System.Drawing;

namespace FindAndReplace.App
{
	partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.RichTextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFileMask = new System.Windows.Forms.TextBox();
            this.btnFindOnly = new System.Windows.Forms.Button();
            this.chkIsCaseSensitive = new System.Windows.Forms.CheckBox();
            this.chkIncludeSubDirectories = new System.Windows.Forms.CheckBox();
            this.btnGenReplaceCommandLine = new System.Windows.Forms.Button();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.lblCommandLine = new System.Windows.Forms.Label();
            this.pnlCommandLine = new System.Windows.Forms.Panel();
            this.gvResults = new System.Windows.Forms.DataGridView();
            this.lblResults = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlGridResults = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNoMatches = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.chkIsRegEx = new System.Windows.Forms.CheckBox();
            this.txtMatchesPreview = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExcludeFileMask = new System.Windows.Forms.TextBox();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSwap = new System.Windows.Forms.Button();
            this.toolTip_btnSwap = new System.Windows.Forms.ToolTip(this.components);
            this.chkSkipBinaryFileDetection = new System.Windows.Forms.CheckBox();
            this.chkIncludeFilesWithoutMatches = new System.Windows.Forms.CheckBox();
            this.toolTip_chkIncludeFilesWithoutMatches = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_chkSkipBinaryFileDetection = new System.Windows.Forms.ToolTip(this.components);
            this.chkShowEncoding = new System.Windows.Forms.CheckBox();
            this.toolTip_chkShowEncoding = new System.Windows.Forms.ToolTip(this.components);
            this.txtFind = new System.Windows.Forms.RichTextBox();
            this.pnlFind = new System.Windows.Forms.Panel();
            this.pnlReplace = new System.Windows.Forms.Panel();
            this.chkUseEscapeChars = new System.Windows.Forms.CheckBox();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.cmbEncoding = new System.Windows.Forms.ComboBox();
            this.txtExcludeDir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCommandLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).BeginInit();
            this.pnlGridResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlFind.SuspendLayout();
            this.pnlReplace.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Find:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Replace:";
            // 
            // txtReplace
            // 
            this.txtReplace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReplace.CausesValidation = false;
            this.txtReplace.DetectUrls = false;
            this.txtReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReplace.Location = new System.Drawing.Point(0, 0);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(573, 83);
            this.txtReplace.TabIndex = 1;
            this.txtReplace.Text = "";
            this.txtReplace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReplace_KeyDown);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(582, 340);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 19;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dir:";
            // 
            // txtDir
            // 
            this.errorProvider1.SetIconPadding(this.txtDir, 30);
            this.txtDir.Location = new System.Drawing.Point(82, 11);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(548, 20);
            this.txtDir.TabIndex = 1;
            this.txtDir.Validating += new System.ComponentModel.CancelEventHandler(this.txtDir_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "File Mask:";
            // 
            // txtFileMask
            // 
            this.txtFileMask.Location = new System.Drawing.Point(82, 56);
            this.txtFileMask.Name = "txtFileMask";
            this.txtFileMask.Size = new System.Drawing.Size(232, 20);
            this.txtFileMask.TabIndex = 5;
            this.txtFileMask.Text = "*.*";
            this.txtFileMask.Validating += new System.ComponentModel.CancelEventHandler(this.txtFileMask_Validating);
            // 
            // btnFindOnly
            // 
            this.btnFindOnly.Location = new System.Drawing.Point(582, 175);
            this.btnFindOnly.Name = "btnFindOnly";
            this.btnFindOnly.Size = new System.Drawing.Size(75, 23);
            this.btnFindOnly.TabIndex = 16;
            this.btnFindOnly.Text = "Find Only";
            this.btnFindOnly.UseVisualStyleBackColor = true;
            this.btnFindOnly.Click += new System.EventHandler(this.btnFindOnly_Click);
            // 
            // chkIsCaseSensitive
            // 
            this.chkIsCaseSensitive.AutoSize = true;
            this.chkIsCaseSensitive.Location = new System.Drawing.Point(82, 177);
            this.chkIsCaseSensitive.Name = "chkIsCaseSensitive";
            this.chkIsCaseSensitive.Size = new System.Drawing.Size(94, 17);
            this.chkIsCaseSensitive.TabIndex = 10;
            this.chkIsCaseSensitive.Text = "Case sensitive";
            this.chkIsCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // chkIncludeSubDirectories
            // 
            this.chkIncludeSubDirectories.AutoSize = true;
            this.chkIncludeSubDirectories.Checked = true;
            this.chkIncludeSubDirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeSubDirectories.Location = new System.Drawing.Point(82, 33);
            this.chkIncludeSubDirectories.Name = "chkIncludeSubDirectories";
            this.chkIncludeSubDirectories.Size = new System.Drawing.Size(132, 17);
            this.chkIncludeSubDirectories.TabIndex = 3;
            this.chkIncludeSubDirectories.Text = "Include sub-directories";
            this.chkIncludeSubDirectories.UseVisualStyleBackColor = true;
            this.chkIncludeSubDirectories.CheckedChanged += new System.EventHandler(this.chkIncludeSubDirectories_CheckedChanged);
            // 
            // btnGenReplaceCommandLine
            // 
            this.btnGenReplaceCommandLine.Location = new System.Drawing.Point(483, 367);
            this.btnGenReplaceCommandLine.Name = "btnGenReplaceCommandLine";
            this.btnGenReplaceCommandLine.Size = new System.Drawing.Size(174, 23);
            this.btnGenReplaceCommandLine.TabIndex = 20;
            this.btnGenReplaceCommandLine.Text = "Gen Replace Command Line";
            this.btnGenReplaceCommandLine.UseVisualStyleBackColor = true;
            this.btnGenReplaceCommandLine.Click += new System.EventHandler(this.btnGenReplaceCommandLine_Click);
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.Location = new System.Drawing.Point(80, 11);
            this.txtCommandLine.Multiline = true;
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(930, 74);
            this.txtCommandLine.TabIndex = 15;
            this.txtCommandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommandLine_KeyDown);
            // 
            // lblCommandLine
            // 
            this.lblCommandLine.AutoSize = true;
            this.lblCommandLine.Location = new System.Drawing.Point(-1, 11);
            this.lblCommandLine.Name = "lblCommandLine";
            this.lblCommandLine.Size = new System.Drawing.Size(80, 13);
            this.lblCommandLine.TabIndex = 20;
            this.lblCommandLine.Text = "Command Line:";
            // 
            // pnlCommandLine
            // 
            this.pnlCommandLine.Controls.Add(this.lblCommandLine);
            this.pnlCommandLine.Controls.Add(this.txtCommandLine);
            this.pnlCommandLine.Location = new System.Drawing.Point(3, 417);
            this.pnlCommandLine.Name = "pnlCommandLine";
            this.pnlCommandLine.Size = new System.Drawing.Size(1012, 100);
            this.pnlCommandLine.TabIndex = 21;
            this.pnlCommandLine.Visible = false;
            // 
            // gvResults
            // 
            this.gvResults.AllowUserToAddRows = false;
            this.gvResults.AllowUserToDeleteRows = false;
            this.gvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResults.Location = new System.Drawing.Point(73, 10);
            this.gvResults.MultiSelect = false;
            this.gvResults.Name = "gvResults";
            this.gvResults.ReadOnly = true;
            this.gvResults.RowHeadersVisible = false;
            this.gvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvResults.Size = new System.Drawing.Size(1092, 138);
            this.gvResults.TabIndex = 18;
            this.gvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResults_CellClick);
            this.gvResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResults_CellDoubleClick);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(17, 9);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(45, 13);
            this.lblResults.TabIndex = 19;
            this.lblResults.Text = "Results:";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(77, 168);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1007, 23);
            this.progressBar.TabIndex = 20;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(74, 151);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 13);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "...";
            // 
            // pnlGridResults
            // 
            this.pnlGridResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGridResults.Controls.Add(this.btnCancel);
            this.pnlGridResults.Controls.Add(this.lblStatus);
            this.pnlGridResults.Controls.Add(this.progressBar);
            this.pnlGridResults.Controls.Add(this.lblResults);
            this.pnlGridResults.Controls.Add(this.gvResults);
            this.pnlGridResults.Location = new System.Drawing.Point(10, 417);
            this.pnlGridResults.Name = "pnlGridResults";
            this.pnlGridResults.Size = new System.Drawing.Size(1171, 194);
            this.pnlGridResults.TabIndex = 22;
            this.pnlGridResults.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1090, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // txtNoMatches
            // 
            this.txtNoMatches.AutoSize = true;
            this.txtNoMatches.Location = new System.Drawing.Point(80, 367);
            this.txtNoMatches.Name = "txtNoMatches";
            this.txtNoMatches.Size = new System.Drawing.Size(124, 13);
            this.txtNoMatches.TabIndex = 21;
            this.txtNoMatches.Text = " No matching files found.";
            this.txtNoMatches.Visible = false;
            // 
            // lblStats
            // 
            this.lblStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(1187, 417);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(37, 13);
            this.lblStats.TabIndex = 25;
            this.lblStats.Text = "[Stats]";
            // 
            // chkIsRegEx
            // 
            this.chkIsRegEx.AutoSize = true;
            this.chkIsRegEx.Location = new System.Drawing.Point(192, 177);
            this.chkIsRegEx.Name = "chkIsRegEx";
            this.chkIsRegEx.Size = new System.Drawing.Size(138, 17);
            this.chkIsRegEx.TabIndex = 11;
            this.chkIsRegEx.Text = "Use regular expressions";
            this.chkIsRegEx.UseVisualStyleBackColor = true;
            // 
            // txtMatchesPreview
            // 
            this.txtMatchesPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatchesPreview.BackColor = System.Drawing.SystemColors.Info;
            this.txtMatchesPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatchesPreview.DetectUrls = false;
            this.txtMatchesPreview.Location = new System.Drawing.Point(689, 12);
            this.txtMatchesPreview.Name = "txtMatchesPreview";
            this.txtMatchesPreview.ReadOnly = true;
            this.txtMatchesPreview.Size = new System.Drawing.Size(680, 399);
            this.txtMatchesPreview.TabIndex = 24;
            this.txtMatchesPreview.Text = "";
            this.txtMatchesPreview.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exclude Mask:";
            // 
            // txtExcludeFileMask
            // 
            this.txtExcludeFileMask.Location = new System.Drawing.Point(407, 56);
            this.txtExcludeFileMask.Name = "txtExcludeFileMask";
            this.txtExcludeFileMask.Size = new System.Drawing.Size(250, 20);
            this.txtExcludeFileMask.TabIndex = 7;
            this.txtExcludeFileMask.Text = "*.dll, *.exe";
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.CausesValidation = false;
            this.btnSelectDir.Location = new System.Drawing.Point(633, 9);
            this.btnSelectDir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(24, 23);
            this.btnSelectDir.TabIndex = 2;
            this.btnSelectDir.Text = "...";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select folder with files to find and replace.";
            // 
            // btnSwap
            // 
            this.btnSwap.AccessibleDescription = "";
            this.btnSwap.CausesValidation = false;
            this.btnSwap.Location = new System.Drawing.Point(520, 195);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(32, 23);
            this.btnSwap.TabIndex = 15;
            this.btnSwap.Text = "↑ ↓";
            this.toolTip_btnSwap.SetToolTip(this.btnSwap, "Swap find text and replace text");
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // chkSkipBinaryFileDetection
            // 
            this.chkSkipBinaryFileDetection.AutoSize = true;
            this.chkSkipBinaryFileDetection.Location = new System.Drawing.Point(360, 177);
            this.chkSkipBinaryFileDetection.Name = "chkSkipBinaryFileDetection";
            this.chkSkipBinaryFileDetection.Size = new System.Drawing.Size(141, 17);
            this.chkSkipBinaryFileDetection.TabIndex = 12;
            this.chkSkipBinaryFileDetection.Text = "Skip binary file detection";
            this.toolTip_chkSkipBinaryFileDetection.SetToolTip(this.chkSkipBinaryFileDetection, "Include binary files when searching for the string in \'Find\'.");
            this.chkSkipBinaryFileDetection.UseVisualStyleBackColor = true;
            // 
            // chkIncludeFilesWithoutMatches
            // 
            this.chkIncludeFilesWithoutMatches.AutoSize = true;
            this.chkIncludeFilesWithoutMatches.Location = new System.Drawing.Point(192, 200);
            this.chkIncludeFilesWithoutMatches.Name = "chkIncludeFilesWithoutMatches";
            this.chkIncludeFilesWithoutMatches.Size = new System.Drawing.Size(162, 17);
            this.chkIncludeFilesWithoutMatches.TabIndex = 14;
            this.chkIncludeFilesWithoutMatches.Text = "Include files without matches";
            this.toolTip_chkIncludeFilesWithoutMatches.SetToolTip(this.chkIncludeFilesWithoutMatches, "Show files without matches in results.");
            this.chkIncludeFilesWithoutMatches.UseVisualStyleBackColor = true;
            // 
            // chkShowEncoding
            // 
            this.chkShowEncoding.AutoSize = true;
            this.chkShowEncoding.Location = new System.Drawing.Point(82, 200);
            this.chkShowEncoding.Name = "chkShowEncoding";
            this.chkShowEncoding.Size = new System.Drawing.Size(100, 17);
            this.chkShowEncoding.TabIndex = 13;
            this.chkShowEncoding.TabStop = false;
            this.chkShowEncoding.Text = "Show encoding";
            this.toolTip_chkShowEncoding.SetToolTip(this.chkShowEncoding, "Indicate encoding detected for each file");
            this.chkShowEncoding.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFind.DetectUrls = false;
            this.txtFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFind.Location = new System.Drawing.Point(0, 0);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(573, 83);
            this.txtFind.TabIndex = 1;
            this.txtFind.Text = "";
            this.txtFind.WordWrap = false;
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // pnlFind
            // 
            this.pnlFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFind.Controls.Add(this.txtFind);
            this.pnlFind.Location = new System.Drawing.Point(82, 82);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(575, 85);
            this.pnlFind.TabIndex = 9;
            this.pnlFind.Validating += new System.ComponentModel.CancelEventHandler(this.pnlFind_Validating);
            // 
            // pnlReplace
            // 
            this.pnlReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReplace.Controls.Add(this.txtReplace);
            this.pnlReplace.Location = new System.Drawing.Point(82, 248);
            this.pnlReplace.Name = "pnlReplace";
            this.pnlReplace.Size = new System.Drawing.Size(575, 85);
            this.pnlReplace.TabIndex = 18;
            this.pnlReplace.Validating += new System.ComponentModel.CancelEventHandler(this.pnlReplace_Validating);
            // 
            // chkUseEscapeChars
            // 
            this.chkUseEscapeChars.AutoSize = true;
            this.chkUseEscapeChars.Location = new System.Drawing.Point(360, 200);
            this.chkUseEscapeChars.Name = "chkUseEscapeChars";
            this.chkUseEscapeChars.Size = new System.Drawing.Size(112, 17);
            this.chkUseEscapeChars.TabIndex = 26;
            this.chkUseEscapeChars.Text = "Use escape chars";
            this.chkUseEscapeChars.UseVisualStyleBackColor = true;
            // 
            // lblEncoding
            // 
            this.lblEncoding.AutoSize = true;
            this.lblEncoding.Location = new System.Drawing.Point(79, 224);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(55, 13);
            this.lblEncoding.TabIndex = 27;
            this.lblEncoding.Text = "Encoding:";
            // 
            // cmbEncoding
            // 
            this.cmbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncoding.FormattingEnabled = true;
            this.cmbEncoding.Location = new System.Drawing.Point(139, 221);
            this.cmbEncoding.Name = "cmbEncoding";
            this.cmbEncoding.Size = new System.Drawing.Size(121, 21);
            this.cmbEncoding.TabIndex = 28;
            // 
            // txtExcludeDir
            // 
            this.txtExcludeDir.Location = new System.Drawing.Point(407, 35);
            this.txtExcludeDir.Name = "txtExcludeDir";
            this.txtExcludeDir.Size = new System.Drawing.Size(250, 20);
            this.txtExcludeDir.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Exclude Dir:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkSkipBinaryFileDetection);
            this.panel1.Controls.Add(this.txtExcludeDir);
            this.panel1.Controls.Add(this.pnlReplace);
            this.panel1.Controls.Add(this.txtNoMatches);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pnlFind);
            this.panel1.Controls.Add(this.cmbEncoding);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblEncoding);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chkUseEscapeChars);
            this.panel1.Controls.Add(this.btnReplace);
            this.panel1.Controls.Add(this.chkShowEncoding);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSwap);
            this.panel1.Controls.Add(this.txtDir);
            this.panel1.Controls.Add(this.btnSelectDir);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtExcludeFileMask);
            this.panel1.Controls.Add(this.txtFileMask);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnFindOnly);
            this.panel1.Controls.Add(this.chkIncludeFilesWithoutMatches);
            this.panel1.Controls.Add(this.chkIsCaseSensitive);
            this.panel1.Controls.Add(this.chkIsRegEx);
            this.panel1.Controls.Add(this.chkIncludeSubDirectories);
            this.panel1.Controls.Add(this.btnGenReplaceCommandLine);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 400);
            this.panel1.TabIndex = 32;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1381, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.txtMatchesPreview);
            this.Controls.Add(this.pnlGridResults);
            this.Controls.Add(this.pnlCommandLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find and Replace";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlCommandLine.ResumeLayout(false);
            this.pnlCommandLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).EndInit();
            this.pnlGridResults.ResumeLayout(false);
            this.pnlGridResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlFind.ResumeLayout(false);
            this.pnlReplace.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox txtReplace;
		private System.Windows.Forms.Button btnReplace;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDir;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtFileMask;
		private System.Windows.Forms.Button btnFindOnly;
		private System.Windows.Forms.CheckBox chkIsCaseSensitive;
		private System.Windows.Forms.CheckBox chkIncludeSubDirectories;
		private System.Windows.Forms.Button btnGenReplaceCommandLine;
		private System.Windows.Forms.TextBox txtCommandLine;
		private System.Windows.Forms.Label lblCommandLine;
		private System.Windows.Forms.Panel pnlCommandLine;
		public System.Windows.Forms.DataGridView gvResults;
		private System.Windows.Forms.Label lblResults;
		public System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Panel pnlGridResults;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label txtNoMatches;
		//public System.Windows.Forms.RichTextBox txtMatches;
		private System.Windows.Forms.RichTextBox txtMatchesPreview;
		private System.Windows.Forms.Label lblStats;
		private System.Windows.Forms.CheckBox chkIsRegEx;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtExcludeFileMask;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSelectDir;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button btnSwap;
		private System.Windows.Forms.ToolTip toolTip_btnSwap;
		private System.Windows.Forms.CheckBox chkSkipBinaryFileDetection;
		private System.Windows.Forms.CheckBox chkIncludeFilesWithoutMatches;
		private System.Windows.Forms.ToolTip toolTip_chkIncludeFilesWithoutMatches;
		private System.Windows.Forms.ToolTip toolTip_chkSkipBinaryFileDetection;
		private System.Windows.Forms.CheckBox chkShowEncoding;
		private System.Windows.Forms.ToolTip toolTip_chkShowEncoding;
		private System.Windows.Forms.RichTextBox txtFind;
		private System.Windows.Forms.Panel pnlFind;
		private System.Windows.Forms.Panel pnlReplace;
		private System.Windows.Forms.CheckBox chkUseEscapeChars;
		private System.Windows.Forms.ComboBox cmbEncoding;
		private System.Windows.Forms.Label lblEncoding;
        private System.Windows.Forms.TextBox txtExcludeDir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}

