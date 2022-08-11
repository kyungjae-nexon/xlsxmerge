namespace NexonKorea.XlsxMerge
{
    partial class FormMainDiff
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainDiff));
			this.panelTop = new System.Windows.Forms.Panel();
			this.labelPathResult = new System.Windows.Forms.Label();
			this.labelPathTheirs = new System.Windows.Forms.Label();
			this.labelPathMine = new System.Windows.Forms.Label();
			this.labelPathBase = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonSaveMergeResult = new System.Windows.Forms.Button();
			this.splitContainerBottom = new System.Windows.Forms.SplitContainer();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.listViewWorksheets = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panelMergeHunksOff = new System.Windows.Forms.Panel();
			this.panelMergeHunksOn = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.labelTotalDiffHunks = new System.Windows.Forms.Label();
			this.labelCurrentDiffHunkIdx = new System.Windows.Forms.Label();
			this.buttonNavPrev = new System.Windows.Forms.Button();
			this.linkLabelChangeMergeOrder = new System.Windows.Forms.LinkLabel();
			this.labelCurrentMergeOrder = new System.Windows.Forms.Label();
			this.buttonNavNext = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelCurrentWorksheetMergeMode = new System.Windows.Forms.Label();
			this.linkLabelChangeWorksheetMergeMode = new System.Windows.Forms.LinkLabel();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.buttonCopyTableContents = new System.Windows.Forms.Button();
			this.checkBoxHideRemovedLines = new System.Windows.Forms.CheckBox();
			this.checkBoxHideEqualLines = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.checkBoxShowFirstRowContentsOnTop = new System.Windows.Forms.CheckBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.panelTop.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).BeginInit();
			this.splitContainerBottom.Panel1.SuspendLayout();
			this.splitContainerBottom.Panel2.SuspendLayout();
			this.splitContainerBottom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panelMergeHunksOn.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelTop.Controls.Add(this.labelPathResult);
			this.panelTop.Controls.Add(this.labelPathTheirs);
			this.panelTop.Controls.Add(this.labelPathMine);
			this.panelTop.Controls.Add(this.labelPathBase);
			this.panelTop.Controls.Add(this.panel2);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(1284, 69);
			this.panelTop.TabIndex = 0;
			// 
			// labelPathResult
			// 
			this.labelPathResult.BackColor = System.Drawing.Color.DarkGray;
			this.labelPathResult.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelPathResult.Font = new System.Drawing.Font("Consolas", 9F);
			this.labelPathResult.Location = new System.Drawing.Point(0, 45);
			this.labelPathResult.Name = "labelPathResult";
			this.labelPathResult.Size = new System.Drawing.Size(990, 15);
			this.labelPathResult.TabIndex = 3;
			this.labelPathResult.Text = "<<RESULT FILE>>";
			// 
			// labelPathTheirs
			// 
			this.labelPathTheirs.BackColor = System.Drawing.Color.DarkGray;
			this.labelPathTheirs.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelPathTheirs.Font = new System.Drawing.Font("Consolas", 9F);
			this.labelPathTheirs.Location = new System.Drawing.Point(0, 30);
			this.labelPathTheirs.Name = "labelPathTheirs";
			this.labelPathTheirs.Size = new System.Drawing.Size(990, 15);
			this.labelPathTheirs.TabIndex = 2;
			this.labelPathTheirs.Text = "<<THEIRS FILE>>";
			// 
			// labelPathMine
			// 
			this.labelPathMine.BackColor = System.Drawing.Color.DarkGray;
			this.labelPathMine.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelPathMine.Font = new System.Drawing.Font("Consolas", 9F);
			this.labelPathMine.Location = new System.Drawing.Point(0, 15);
			this.labelPathMine.Name = "labelPathMine";
			this.labelPathMine.Size = new System.Drawing.Size(990, 15);
			this.labelPathMine.TabIndex = 1;
			this.labelPathMine.Text = "<<MINE FILE>>";
			// 
			// labelPathBase
			// 
			this.labelPathBase.BackColor = System.Drawing.Color.DarkGray;
			this.labelPathBase.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelPathBase.Font = new System.Drawing.Font("Consolas", 9F);
			this.labelPathBase.Location = new System.Drawing.Point(0, 0);
			this.labelPathBase.Name = "labelPathBase";
			this.labelPathBase.Size = new System.Drawing.Size(990, 15);
			this.labelPathBase.TabIndex = 0;
			this.labelPathBase.Text = "<<BASE FILE>>";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.buttonSaveMergeResult);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(990, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(292, 67);
			this.panel2.TabIndex = 4;
			// 
			// buttonSaveMergeResult
			// 
			this.buttonSaveMergeResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveMergeResult.BackColor = System.Drawing.Color.PeachPuff;
			this.buttonSaveMergeResult.Location = new System.Drawing.Point(7, 3);
			this.buttonSaveMergeResult.Name = "buttonSaveMergeResult";
			this.buttonSaveMergeResult.Size = new System.Drawing.Size(274, 58);
			this.buttonSaveMergeResult.TabIndex = 0;
			this.buttonSaveMergeResult.Text = "머지 결과 저장 (...)";
			this.buttonSaveMergeResult.UseVisualStyleBackColor = false;
			this.buttonSaveMergeResult.Click += new System.EventHandler(this.buttonSaveMergeResult_Click);
			// 
			// splitContainerBottom
			// 
			this.splitContainerBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainerBottom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerBottom.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainerBottom.Location = new System.Drawing.Point(0, 69);
			this.splitContainerBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.splitContainerBottom.Name = "splitContainerBottom";
			// 
			// splitContainerBottom.Panel1
			// 
			this.splitContainerBottom.Panel1.Controls.Add(this.splitContainer1);
			// 
			// splitContainerBottom.Panel2
			// 
			this.splitContainerBottom.Panel2.Controls.Add(this.dataGridView1);
			this.splitContainerBottom.Panel2.Controls.Add(this.panelMergeHunksOff);
			this.splitContainerBottom.Panel2.Controls.Add(this.panelMergeHunksOn);
			this.splitContainerBottom.Panel2.Controls.Add(this.panel1);
			this.splitContainerBottom.Panel2.Controls.Add(this.panel3);
			this.splitContainerBottom.Size = new System.Drawing.Size(1284, 712);
			this.splitContainerBottom.SplitterDistance = 332;
			this.splitContainerBottom.TabIndex = 1;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.listViewWorksheets);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.textBox1);
			this.splitContainer1.Panel2.Controls.Add(this.label4);
			this.splitContainer1.Size = new System.Drawing.Size(330, 710);
			this.splitContainer1.SplitterDistance = 357;
			this.splitContainer1.TabIndex = 3;
			// 
			// listViewWorksheets
			// 
			this.listViewWorksheets.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewWorksheets.FullRowSelect = true;
			this.listViewWorksheets.GridLines = true;
			this.listViewWorksheets.HideSelection = false;
			this.listViewWorksheets.Location = new System.Drawing.Point(0, 15);
			this.listViewWorksheets.Name = "listViewWorksheets";
			this.listViewWorksheets.Size = new System.Drawing.Size(330, 342);
			this.listViewWorksheets.TabIndex = 2;
			this.listViewWorksheets.UseCompatibleStateImageBehavior = false;
			this.listViewWorksheets.View = System.Windows.Forms.View.Details;
			this.listViewWorksheets.SelectedIndexChanged += new System.EventHandler(this.listViewWorksheets_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Lavender;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(330, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "워크시트 목록";
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(0, 15);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(330, 334);
			this.textBox1.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.LavenderBlush;
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(330, 15);
			this.label4.TabIndex = 2;
			this.label4.Text = "추가 정보";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 192);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.ShowCellErrors = false;
			this.dataGridView1.ShowEditingIcon = false;
			this.dataGridView1.ShowRowErrors = false;
			this.dataGridView1.Size = new System.Drawing.Size(946, 491);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// panelMergeHunksOff
			// 
			this.panelMergeHunksOff.BackColor = System.Drawing.Color.LemonChiffon;
			this.panelMergeHunksOff.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelMergeHunksOff.Location = new System.Drawing.Point(0, 126);
			this.panelMergeHunksOff.Name = "panelMergeHunksOff";
			this.panelMergeHunksOff.Size = new System.Drawing.Size(946, 66);
			this.panelMergeHunksOff.TabIndex = 13;
			this.panelMergeHunksOff.Visible = false;
			// 
			// panelMergeHunksOn
			// 
			this.panelMergeHunksOn.BackColor = System.Drawing.Color.LemonChiffon;
			this.panelMergeHunksOn.Controls.Add(this.groupBox1);
			this.panelMergeHunksOn.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelMergeHunksOn.Location = new System.Drawing.Point(0, 60);
			this.panelMergeHunksOn.Name = "panelMergeHunksOn";
			this.panelMergeHunksOn.Size = new System.Drawing.Size(946, 66);
			this.panelMergeHunksOn.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.labelTotalDiffHunks);
			this.groupBox1.Controls.Add(this.labelCurrentDiffHunkIdx);
			this.groupBox1.Controls.Add(this.buttonNavPrev);
			this.groupBox1.Controls.Add(this.linkLabelChangeMergeOrder);
			this.groupBox1.Controls.Add(this.labelCurrentMergeOrder);
			this.groupBox1.Controls.Add(this.buttonNavNext);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(929, 51);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "직접 머지하기";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(114, 19);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(12, 15);
			this.label12.TabIndex = 11;
			this.label12.Text = "/";
			// 
			// labelTotalDiffHunks
			// 
			this.labelTotalDiffHunks.AutoSize = true;
			this.labelTotalDiffHunks.Location = new System.Drawing.Point(132, 19);
			this.labelTotalDiffHunks.Name = "labelTotalDiffHunks";
			this.labelTotalDiffHunks.Size = new System.Drawing.Size(13, 15);
			this.labelTotalDiffHunks.TabIndex = 11;
			this.labelTotalDiffHunks.Text = "?";
			// 
			// labelCurrentDiffHunkIdx
			// 
			this.labelCurrentDiffHunkIdx.AutoSize = true;
			this.labelCurrentDiffHunkIdx.Location = new System.Drawing.Point(71, 19);
			this.labelCurrentDiffHunkIdx.Name = "labelCurrentDiffHunkIdx";
			this.labelCurrentDiffHunkIdx.Size = new System.Drawing.Size(13, 15);
			this.labelCurrentDiffHunkIdx.TabIndex = 11;
			this.labelCurrentDiffHunkIdx.Text = "?";
			// 
			// buttonNavPrev
			// 
			this.buttonNavPrev.BackColor = System.Drawing.Color.LightYellow;
			this.buttonNavPrev.Location = new System.Drawing.Point(182, 16);
			this.buttonNavPrev.Name = "buttonNavPrev";
			this.buttonNavPrev.Size = new System.Drawing.Size(37, 23);
			this.buttonNavPrev.TabIndex = 2;
			this.buttonNavPrev.Text = "<<";
			this.buttonNavPrev.UseVisualStyleBackColor = false;
			this.buttonNavPrev.Click += new System.EventHandler(this.buttonNavPrev_Click);
			// 
			// linkLabelChangeMergeOrder
			// 
			this.linkLabelChangeMergeOrder.AutoSize = true;
			this.linkLabelChangeMergeOrder.Location = new System.Drawing.Point(343, 19);
			this.linkLabelChangeMergeOrder.Name = "linkLabelChangeMergeOrder";
			this.linkLabelChangeMergeOrder.Size = new System.Drawing.Size(40, 15);
			this.linkLabelChangeMergeOrder.TabIndex = 9;
			this.linkLabelChangeMergeOrder.TabStop = true;
			this.linkLabelChangeMergeOrder.Text = "변경...";
			this.linkLabelChangeMergeOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangeMergeOrder_LinkClicked);
			// 
			// labelCurrentMergeOrder
			// 
			this.labelCurrentMergeOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelCurrentMergeOrder.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.labelCurrentMergeOrder.Location = new System.Drawing.Point(389, 15);
			this.labelCurrentMergeOrder.Name = "labelCurrentMergeOrder";
			this.labelCurrentMergeOrder.Size = new System.Drawing.Size(295, 25);
			this.labelCurrentMergeOrder.TabIndex = 10;
			this.labelCurrentMergeOrder.Text = "---";
			// 
			// buttonNavNext
			// 
			this.buttonNavNext.BackColor = System.Drawing.Color.LightYellow;
			this.buttonNavNext.Location = new System.Drawing.Point(225, 15);
			this.buttonNavNext.Name = "buttonNavNext";
			this.buttonNavNext.Size = new System.Drawing.Size(37, 23);
			this.buttonNavNext.TabIndex = 2;
			this.buttonNavNext.Text = ">>";
			this.buttonNavNext.UseVisualStyleBackColor = false;
			this.buttonNavNext.Click += new System.EventHandler(this.buttonNavNext_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "변경 위치";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(267, 19);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(70, 15);
			this.label9.TabIndex = 8;
			this.label9.Text = "현재 동작 : ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.labelCurrentWorksheetMergeMode);
			this.panel1.Controls.Add(this.linkLabelChangeWorksheetMergeMode);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(946, 60);
			this.panel1.TabIndex = 3;
			// 
			// labelCurrentWorksheetMergeMode
			// 
			this.labelCurrentWorksheetMergeMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelCurrentWorksheetMergeMode.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.labelCurrentWorksheetMergeMode.Location = new System.Drawing.Point(173, 29);
			this.labelCurrentWorksheetMergeMode.Name = "labelCurrentWorksheetMergeMode";
			this.labelCurrentWorksheetMergeMode.Size = new System.Drawing.Size(239, 25);
			this.labelCurrentWorksheetMergeMode.TabIndex = 7;
			this.labelCurrentWorksheetMergeMode.Text = "---";
			// 
			// linkLabelChangeWorksheetMergeMode
			// 
			this.linkLabelChangeWorksheetMergeMode.AutoSize = true;
			this.linkLabelChangeWorksheetMergeMode.Location = new System.Drawing.Point(127, 32);
			this.linkLabelChangeWorksheetMergeMode.Name = "linkLabelChangeWorksheetMergeMode";
			this.linkLabelChangeWorksheetMergeMode.Size = new System.Drawing.Size(40, 15);
			this.linkLabelChangeWorksheetMergeMode.TabIndex = 6;
			this.linkLabelChangeWorksheetMergeMode.TabStop = true;
			this.linkLabelChangeWorksheetMergeMode.Text = "변경...";
			this.linkLabelChangeWorksheetMergeMode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangeWorksheetMergeMode_LinkClicked);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(122, 15);
			this.label5.TabIndex = 5;
			this.label5.Text = "워크시트 머지 모드 : ";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Honeydew;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F);
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(946, 29);
			this.label2.TabIndex = 0;
			this.label2.Text = "선택한 워크시트 : ";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.buttonCopyTableContents);
			this.panel3.Controls.Add(this.checkBoxHideRemovedLines);
			this.panel3.Controls.Add(this.checkBoxHideEqualLines);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.checkBoxShowFirstRowContentsOnTop);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 683);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(946, 27);
			this.panel3.TabIndex = 4;
			// 
			// buttonCopyTableContents
			// 
			this.buttonCopyTableContents.BackColor = System.Drawing.Color.Snow;
			this.buttonCopyTableContents.Location = new System.Drawing.Point(826, 1);
			this.buttonCopyTableContents.Name = "buttonCopyTableContents";
			this.buttonCopyTableContents.Size = new System.Drawing.Size(211, 23);
			this.buttonCopyTableContents.TabIndex = 11;
			this.buttonCopyTableContents.Text = "위에 표시된 테이블 클립보드로 복사";
			this.buttonCopyTableContents.UseVisualStyleBackColor = false;
			this.buttonCopyTableContents.Click += new System.EventHandler(this.buttonCopyTableContents_Click);
			// 
			// checkBoxHideRemovedLines
			// 
			this.checkBoxHideRemovedLines.AutoSize = true;
			this.checkBoxHideRemovedLines.Location = new System.Drawing.Point(331, 5);
			this.checkBoxHideRemovedLines.Name = "checkBoxHideRemovedLines";
			this.checkBoxHideRemovedLines.Size = new System.Drawing.Size(158, 19);
			this.checkBoxHideRemovedLines.TabIndex = 9;
			this.checkBoxHideRemovedLines.Text = "삭제된 행 표시하지 않기";
			this.checkBoxHideRemovedLines.UseVisualStyleBackColor = true;
			this.checkBoxHideRemovedLines.CheckedChanged += new System.EventHandler(this.checkBoxHideRemovedLines_CheckedChanged);
			// 
			// checkBoxHideRemovedLines
			// 
			this.checkBoxHideEqualLines.AutoSize = true;
			this.checkBoxHideEqualLines.Location = new System.Drawing.Point(491, 5);
			this.checkBoxHideEqualLines.Name = "checkBoxHideEqualLines";
			this.checkBoxHideEqualLines.Size = new System.Drawing.Size(158, 19);
			this.checkBoxHideEqualLines.TabIndex = 10;
			this.checkBoxHideEqualLines.Text = "동일한 행 표시하지 않기";
			this.checkBoxHideEqualLines.UseVisualStyleBackColor = true;
			this.checkBoxHideEqualLines.CheckedChanged += new System.EventHandler(this.checkBoxHideEqualLines_CheckedChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(1, 6);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 15);
			this.label7.TabIndex = 8;
			this.label7.Text = "보기 옵션";
			// 
			// checkBoxShowFirstRowContentsOnTop
			// 
			this.checkBoxShowFirstRowContentsOnTop.AutoSize = true;
			this.checkBoxShowFirstRowContentsOnTop.Location = new System.Drawing.Point(79, 5);
			this.checkBoxShowFirstRowContentsOnTop.Name = "checkBoxShowFirstRowContentsOnTop";
			this.checkBoxShowFirstRowContentsOnTop.Size = new System.Drawing.Size(246, 19);
			this.checkBoxShowFirstRowContentsOnTop.TabIndex = 1;
			this.checkBoxShowFirstRowContentsOnTop.Text = "base 문서 첫 행의 내용을 열 이름에 표시";
			this.checkBoxShowFirstRowContentsOnTop.UseVisualStyleBackColor = true;
			this.checkBoxShowFirstRowContentsOnTop.CheckedChanged += new System.EventHandler(this.checkBoxShowFirstRowContentsOnTop_CheckedChanged);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "xlsx";
			this.saveFileDialog1.Filter = "Excel 파일(*.xls*)|*.xls*|모든 파일|*.*";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// FormMainDiff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1284, 781);
			this.Controls.Add(this.splitContainerBottom);
			this.Controls.Add(this.panelTop);
			this.Font = new System.Drawing.Font("Malgun Gothic", 9F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormMainDiff";
			this.Text = "XlsxMerge";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormMainDiff_Load);
			this.panelTop.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.splitContainerBottom.Panel1.ResumeLayout(false);
			this.splitContainerBottom.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).EndInit();
			this.splitContainerBottom.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panelMergeHunksOn.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.SplitContainer splitContainerBottom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPathResult;
        private System.Windows.Forms.Label labelPathTheirs;
        private System.Windows.Forms.Label labelPathMine;
        private System.Windows.Forms.Label labelPathBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewWorksheets;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxShowFirstRowContentsOnTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNavNext;
        private System.Windows.Forms.Button buttonNavPrev;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button buttonSaveMergeResult;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.LinkLabel linkLabelChangeWorksheetMergeMode;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label labelCurrentWorksheetMergeMode;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.CheckBox checkBoxHideRemovedLines;
		private System.Windows.Forms.CheckBox checkBoxHideEqualLines;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label labelCurrentMergeOrder;
		private System.Windows.Forms.LinkLabel linkLabelChangeMergeOrder;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panelMergeHunksOn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label labelCurrentDiffHunkIdx;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label labelTotalDiffHunks;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panelMergeHunksOff;
        private System.Windows.Forms.Button buttonCopyTableContents;
		private System.Windows.Forms.TextBox textBox1;
	}
}