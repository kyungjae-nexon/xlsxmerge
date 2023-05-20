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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainDiff));
			panelTop = new Panel();
			labelPathResult = new Label();
			labelPathTheirs = new Label();
			labelPathMine = new Label();
			labelPathBase = new Label();
			panel2 = new Panel();
			buttonSaveMergeResult = new Button();
			splitContainerBottom = new SplitContainer();
			splitContainer1 = new SplitContainer();
			listViewWorksheets = new ListView();
			label1 = new Label();
			textBox1 = new TextBox();
			label4 = new Label();
			dataGridView1 = new DataGridView();
			panelMergeHunksOff = new Panel();
			panelMergeHunksOn = new Panel();
			groupBox1 = new GroupBox();
			label12 = new Label();
			labelTotalDiffHunks = new Label();
			labelCurrentDiffHunkIdx = new Label();
			buttonNavPrev = new Button();
			linkLabelChangeMergeOrder = new LinkLabel();
			labelCurrentMergeOrder = new Label();
			buttonNavNext = new Button();
			label3 = new Label();
			label9 = new Label();
			panel1 = new Panel();
			labelCurrentWorksheetMergeMode = new Label();
			linkLabelChangeWorksheetMergeMode = new LinkLabel();
			label5 = new Label();
			label2 = new Label();
			panel3 = new Panel();
			buttonCopyTableContents = new Button();
			checkBoxHideRemovedLines = new CheckBox();
			checkBoxHideEqualLines = new CheckBox();
			label7 = new Label();
			checkBoxShowFirstRowContentsOnTop = new CheckBox();
			saveFileDialog1 = new SaveFileDialog();
			imageList1 = new ImageList(components);
			contextMenuStrip1 = new ContextMenuStrip(components);
			checkBoxNavigateOnlyConflictHunks = new CheckBox();
			panelTop.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainerBottom).BeginInit();
			splitContainerBottom.Panel1.SuspendLayout();
			splitContainerBottom.Panel2.SuspendLayout();
			splitContainerBottom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panelMergeHunksOn.SuspendLayout();
			groupBox1.SuspendLayout();
			panel1.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// panelTop
			// 
			panelTop.BorderStyle = BorderStyle.FixedSingle;
			panelTop.Controls.Add(labelPathResult);
			panelTop.Controls.Add(labelPathTheirs);
			panelTop.Controls.Add(labelPathMine);
			panelTop.Controls.Add(labelPathBase);
			panelTop.Controls.Add(panel2);
			panelTop.Dock = DockStyle.Top;
			panelTop.Location = new Point(0, 0);
			panelTop.Margin = new Padding(3, 4, 3, 4);
			panelTop.Name = "panelTop";
			panelTop.Size = new Size(1284, 69);
			panelTop.TabIndex = 0;
			// 
			// labelPathResult
			// 
			labelPathResult.BackColor = Color.DarkGray;
			labelPathResult.Dock = DockStyle.Top;
			labelPathResult.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			labelPathResult.Location = new Point(0, 45);
			labelPathResult.Name = "labelPathResult";
			labelPathResult.Size = new Size(990, 15);
			labelPathResult.TabIndex = 3;
			labelPathResult.Text = "<<RESULT FILE>>";
			// 
			// labelPathTheirs
			// 
			labelPathTheirs.BackColor = Color.DarkGray;
			labelPathTheirs.Dock = DockStyle.Top;
			labelPathTheirs.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			labelPathTheirs.Location = new Point(0, 30);
			labelPathTheirs.Name = "labelPathTheirs";
			labelPathTheirs.Size = new Size(990, 15);
			labelPathTheirs.TabIndex = 2;
			labelPathTheirs.Text = "<<THEIRS FILE>>";
			// 
			// labelPathMine
			// 
			labelPathMine.BackColor = Color.DarkGray;
			labelPathMine.Dock = DockStyle.Top;
			labelPathMine.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			labelPathMine.Location = new Point(0, 15);
			labelPathMine.Name = "labelPathMine";
			labelPathMine.Size = new Size(990, 15);
			labelPathMine.TabIndex = 1;
			labelPathMine.Text = "<<MINE FILE>>";
			// 
			// labelPathBase
			// 
			labelPathBase.BackColor = Color.DarkGray;
			labelPathBase.Dock = DockStyle.Top;
			labelPathBase.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			labelPathBase.Location = new Point(0, 0);
			labelPathBase.Name = "labelPathBase";
			labelPathBase.Size = new Size(990, 15);
			labelPathBase.TabIndex = 0;
			labelPathBase.Text = "<<BASE FILE>>";
			// 
			// panel2
			// 
			panel2.Controls.Add(buttonSaveMergeResult);
			panel2.Dock = DockStyle.Right;
			panel2.Location = new Point(990, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(292, 67);
			panel2.TabIndex = 4;
			// 
			// buttonSaveMergeResult
			// 
			buttonSaveMergeResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			buttonSaveMergeResult.BackColor = Color.PeachPuff;
			buttonSaveMergeResult.Location = new Point(7, 3);
			buttonSaveMergeResult.Name = "buttonSaveMergeResult";
			buttonSaveMergeResult.Size = new Size(274, 58);
			buttonSaveMergeResult.TabIndex = 0;
			buttonSaveMergeResult.Text = "머지 결과 저장 (...)";
			buttonSaveMergeResult.UseVisualStyleBackColor = false;
			buttonSaveMergeResult.Click += buttonSaveMergeResult_Click;
			// 
			// splitContainerBottom
			// 
			splitContainerBottom.BorderStyle = BorderStyle.FixedSingle;
			splitContainerBottom.Dock = DockStyle.Fill;
			splitContainerBottom.FixedPanel = FixedPanel.Panel1;
			splitContainerBottom.Location = new Point(0, 69);
			splitContainerBottom.Margin = new Padding(3, 4, 3, 4);
			splitContainerBottom.Name = "splitContainerBottom";
			// 
			// splitContainerBottom.Panel1
			// 
			splitContainerBottom.Panel1.Controls.Add(splitContainer1);
			// 
			// splitContainerBottom.Panel2
			// 
			splitContainerBottom.Panel2.Controls.Add(dataGridView1);
			splitContainerBottom.Panel2.Controls.Add(panelMergeHunksOff);
			splitContainerBottom.Panel2.Controls.Add(panelMergeHunksOn);
			splitContainerBottom.Panel2.Controls.Add(panel1);
			splitContainerBottom.Panel2.Controls.Add(panel3);
			splitContainerBottom.Size = new Size(1284, 712);
			splitContainerBottom.SplitterDistance = 332;
			splitContainerBottom.TabIndex = 1;
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(listViewWorksheets);
			splitContainer1.Panel1.Controls.Add(label1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(textBox1);
			splitContainer1.Panel2.Controls.Add(label4);
			splitContainer1.Size = new Size(330, 710);
			splitContainer1.SplitterDistance = 357;
			splitContainer1.TabIndex = 3;
			// 
			// listViewWorksheets
			// 
			listViewWorksheets.Dock = DockStyle.Fill;
			listViewWorksheets.FullRowSelect = true;
			listViewWorksheets.GridLines = true;
			listViewWorksheets.Location = new Point(0, 15);
			listViewWorksheets.Name = "listViewWorksheets";
			listViewWorksheets.Size = new Size(330, 342);
			listViewWorksheets.TabIndex = 2;
			listViewWorksheets.UseCompatibleStateImageBehavior = false;
			listViewWorksheets.View = View.Details;
			listViewWorksheets.SelectedIndexChanged += listViewWorksheets_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.BackColor = Color.Lavender;
			label1.Dock = DockStyle.Top;
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(330, 15);
			label1.TabIndex = 1;
			label1.Text = "워크시트 목록";
			// 
			// textBox1
			// 
			textBox1.Dock = DockStyle.Fill;
			textBox1.Location = new Point(0, 15);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.ScrollBars = ScrollBars.Both;
			textBox1.Size = new Size(330, 334);
			textBox1.TabIndex = 3;
			// 
			// label4
			// 
			label4.BackColor = Color.LavenderBlush;
			label4.Dock = DockStyle.Top;
			label4.Location = new Point(0, 0);
			label4.Name = "label4";
			label4.Size = new Size(330, 15);
			label4.TabIndex = 2;
			label4.Text = "추가 정보";
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.BackgroundColor = Color.LightGray;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.Location = new Point(0, 192);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Red;
			dataGridView1.RowTemplate.Height = 23;
			dataGridView1.ShowCellErrors = false;
			dataGridView1.ShowEditingIcon = false;
			dataGridView1.ShowRowErrors = false;
			dataGridView1.Size = new Size(946, 491);
			dataGridView1.TabIndex = 2;
			dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;
			dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
			// 
			// panelMergeHunksOff
			// 
			panelMergeHunksOff.BackColor = Color.LemonChiffon;
			panelMergeHunksOff.Dock = DockStyle.Top;
			panelMergeHunksOff.Location = new Point(0, 126);
			panelMergeHunksOff.Name = "panelMergeHunksOff";
			panelMergeHunksOff.Size = new Size(946, 66);
			panelMergeHunksOff.TabIndex = 13;
			panelMergeHunksOff.Visible = false;
			// 
			// panelMergeHunksOn
			// 
			panelMergeHunksOn.BackColor = Color.LemonChiffon;
			panelMergeHunksOn.Controls.Add(groupBox1);
			panelMergeHunksOn.Dock = DockStyle.Top;
			panelMergeHunksOn.Location = new Point(0, 60);
			panelMergeHunksOn.Name = "panelMergeHunksOn";
			panelMergeHunksOn.Size = new Size(946, 66);
			panelMergeHunksOn.TabIndex = 5;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(checkBoxNavigateOnlyConflictHunks);
			groupBox1.Controls.Add(label12);
			groupBox1.Controls.Add(labelTotalDiffHunks);
			groupBox1.Controls.Add(labelCurrentDiffHunkIdx);
			groupBox1.Controls.Add(buttonNavPrev);
			groupBox1.Controls.Add(linkLabelChangeMergeOrder);
			groupBox1.Controls.Add(labelCurrentMergeOrder);
			groupBox1.Controls.Add(buttonNavNext);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label9);
			groupBox1.Location = new Point(6, 6);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(929, 51);
			groupBox1.TabIndex = 11;
			groupBox1.TabStop = false;
			groupBox1.Text = "직접 머지하기";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(114, 19);
			label12.Name = "label12";
			label12.Size = new Size(12, 15);
			label12.TabIndex = 11;
			label12.Text = "/";
			// 
			// labelTotalDiffHunks
			// 
			labelTotalDiffHunks.AutoSize = true;
			labelTotalDiffHunks.Location = new Point(132, 19);
			labelTotalDiffHunks.Name = "labelTotalDiffHunks";
			labelTotalDiffHunks.Size = new Size(13, 15);
			labelTotalDiffHunks.TabIndex = 11;
			labelTotalDiffHunks.Text = "?";
			// 
			// labelCurrentDiffHunkIdx
			// 
			labelCurrentDiffHunkIdx.AutoSize = true;
			labelCurrentDiffHunkIdx.Location = new Point(71, 19);
			labelCurrentDiffHunkIdx.Name = "labelCurrentDiffHunkIdx";
			labelCurrentDiffHunkIdx.Size = new Size(13, 15);
			labelCurrentDiffHunkIdx.TabIndex = 11;
			labelCurrentDiffHunkIdx.Text = "?";
			// 
			// buttonNavPrev
			// 
			buttonNavPrev.BackColor = Color.LightYellow;
			buttonNavPrev.Location = new Point(259, 16);
			buttonNavPrev.Name = "buttonNavPrev";
			buttonNavPrev.Size = new Size(37, 23);
			buttonNavPrev.TabIndex = 2;
			buttonNavPrev.Text = "<<";
			buttonNavPrev.UseVisualStyleBackColor = false;
			buttonNavPrev.Click += buttonNavPrev_Click;
			// 
			// linkLabelChangeMergeOrder
			// 
			linkLabelChangeMergeOrder.AutoSize = true;
			linkLabelChangeMergeOrder.Location = new Point(420, 19);
			linkLabelChangeMergeOrder.Name = "linkLabelChangeMergeOrder";
			linkLabelChangeMergeOrder.Size = new Size(40, 15);
			linkLabelChangeMergeOrder.TabIndex = 9;
			linkLabelChangeMergeOrder.TabStop = true;
			linkLabelChangeMergeOrder.Text = "변경...";
			linkLabelChangeMergeOrder.LinkClicked += linkLabelChangeMergeOrder_LinkClicked;
			// 
			// labelCurrentMergeOrder
			// 
			labelCurrentMergeOrder.BorderStyle = BorderStyle.FixedSingle;
			labelCurrentMergeOrder.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelCurrentMergeOrder.Location = new Point(466, 15);
			labelCurrentMergeOrder.Name = "labelCurrentMergeOrder";
			labelCurrentMergeOrder.Size = new Size(295, 25);
			labelCurrentMergeOrder.TabIndex = 10;
			labelCurrentMergeOrder.Text = "---";
			// 
			// buttonNavNext
			// 
			buttonNavNext.BackColor = Color.LightYellow;
			buttonNavNext.Location = new Point(302, 15);
			buttonNavNext.Name = "buttonNavNext";
			buttonNavNext.Size = new Size(37, 23);
			buttonNavNext.TabIndex = 2;
			buttonNavNext.Text = ">>";
			buttonNavNext.UseVisualStyleBackColor = false;
			buttonNavNext.Click += buttonNavNext_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 20);
			label3.Name = "label3";
			label3.Size = new Size(59, 15);
			label3.TabIndex = 3;
			label3.Text = "변경 위치";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(344, 19);
			label9.Name = "label9";
			label9.Size = new Size(70, 15);
			label9.TabIndex = 8;
			label9.Text = "현재 동작 : ";
			// 
			// panel1
			// 
			panel1.Controls.Add(labelCurrentWorksheetMergeMode);
			panel1.Controls.Add(linkLabelChangeWorksheetMergeMode);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label2);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(946, 60);
			panel1.TabIndex = 3;
			// 
			// labelCurrentWorksheetMergeMode
			// 
			labelCurrentWorksheetMergeMode.BorderStyle = BorderStyle.FixedSingle;
			labelCurrentWorksheetMergeMode.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelCurrentWorksheetMergeMode.Location = new Point(173, 29);
			labelCurrentWorksheetMergeMode.Name = "labelCurrentWorksheetMergeMode";
			labelCurrentWorksheetMergeMode.Size = new Size(239, 25);
			labelCurrentWorksheetMergeMode.TabIndex = 7;
			labelCurrentWorksheetMergeMode.Text = "---";
			// 
			// linkLabelChangeWorksheetMergeMode
			// 
			linkLabelChangeWorksheetMergeMode.AutoSize = true;
			linkLabelChangeWorksheetMergeMode.Location = new Point(127, 32);
			linkLabelChangeWorksheetMergeMode.Name = "linkLabelChangeWorksheetMergeMode";
			linkLabelChangeWorksheetMergeMode.Size = new Size(40, 15);
			linkLabelChangeWorksheetMergeMode.TabIndex = 6;
			linkLabelChangeWorksheetMergeMode.TabStop = true;
			linkLabelChangeWorksheetMergeMode.Text = "변경...";
			linkLabelChangeWorksheetMergeMode.LinkClicked += linkLabelChangeWorksheetMergeMode_LinkClicked;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(3, 32);
			label5.Name = "label5";
			label5.Size = new Size(122, 15);
			label5.TabIndex = 5;
			label5.Text = "워크시트 머지 모드 : ";
			// 
			// label2
			// 
			label2.BackColor = Color.Honeydew;
			label2.Dock = DockStyle.Top;
			label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(0, 0);
			label2.Name = "label2";
			label2.Size = new Size(946, 29);
			label2.TabIndex = 0;
			label2.Text = "선택한 워크시트 : ";
			// 
			// panel3
			// 
			panel3.Controls.Add(buttonCopyTableContents);
			panel3.Controls.Add(checkBoxHideRemovedLines);
			panel3.Controls.Add(checkBoxHideEqualLines);
			panel3.Controls.Add(label7);
			panel3.Controls.Add(checkBoxShowFirstRowContentsOnTop);
			panel3.Dock = DockStyle.Bottom;
			panel3.Location = new Point(0, 683);
			panel3.Name = "panel3";
			panel3.Size = new Size(946, 27);
			panel3.TabIndex = 4;
			// 
			// buttonCopyTableContents
			// 
			buttonCopyTableContents.BackColor = Color.Snow;
			buttonCopyTableContents.Location = new Point(826, 1);
			buttonCopyTableContents.Name = "buttonCopyTableContents";
			buttonCopyTableContents.Size = new Size(211, 23);
			buttonCopyTableContents.TabIndex = 11;
			buttonCopyTableContents.Text = "위에 표시된 테이블 클립보드로 복사";
			buttonCopyTableContents.UseVisualStyleBackColor = false;
			buttonCopyTableContents.Click += buttonCopyTableContents_Click;
			// 
			// checkBoxHideRemovedLines
			// 
			checkBoxHideRemovedLines.AutoSize = true;
			checkBoxHideRemovedLines.Location = new Point(331, 5);
			checkBoxHideRemovedLines.Name = "checkBoxHideRemovedLines";
			checkBoxHideRemovedLines.Size = new Size(158, 19);
			checkBoxHideRemovedLines.TabIndex = 9;
			checkBoxHideRemovedLines.Text = "삭제된 행 표시하지 않기";
			checkBoxHideRemovedLines.UseVisualStyleBackColor = true;
			checkBoxHideRemovedLines.CheckedChanged += checkBoxHideRemovedLines_CheckedChanged;
			// 
			// checkBoxHideEqualLines
			// 
			checkBoxHideEqualLines.AutoSize = true;
			checkBoxHideEqualLines.Location = new Point(491, 5);
			checkBoxHideEqualLines.Name = "checkBoxHideEqualLines";
			checkBoxHideEqualLines.Size = new Size(158, 19);
			checkBoxHideEqualLines.TabIndex = 10;
			checkBoxHideEqualLines.Text = "동일한 행 표시하지 않기";
			checkBoxHideEqualLines.UseVisualStyleBackColor = true;
			checkBoxHideEqualLines.CheckedChanged += checkBoxHideEqualLines_CheckedChanged;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(1, 6);
			label7.Name = "label7";
			label7.Size = new Size(59, 15);
			label7.TabIndex = 8;
			label7.Text = "보기 옵션";
			// 
			// checkBoxShowFirstRowContentsOnTop
			// 
			checkBoxShowFirstRowContentsOnTop.AutoSize = true;
			checkBoxShowFirstRowContentsOnTop.Location = new Point(79, 5);
			checkBoxShowFirstRowContentsOnTop.Name = "checkBoxShowFirstRowContentsOnTop";
			checkBoxShowFirstRowContentsOnTop.Size = new Size(246, 19);
			checkBoxShowFirstRowContentsOnTop.TabIndex = 1;
			checkBoxShowFirstRowContentsOnTop.Text = "base 문서 첫 행의 내용을 열 이름에 표시";
			checkBoxShowFirstRowContentsOnTop.UseVisualStyleBackColor = true;
			checkBoxShowFirstRowContentsOnTop.CheckedChanged += checkBoxShowFirstRowContentsOnTop_CheckedChanged;
			// 
			// saveFileDialog1
			// 
			saveFileDialog1.DefaultExt = "xlsx";
			saveFileDialog1.Filter = "Excel 파일(*.xls*)|*.xls*|모든 파일|*.*";
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth8Bit;
			imageList1.ImageSize = new Size(16, 16);
			imageList1.TransparentColor = Color.Transparent;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
			// 
			// checkBoxNavigateOnlyConflictHunks
			// 
			checkBoxNavigateOnlyConflictHunks.AutoSize = true;
			checkBoxNavigateOnlyConflictHunks.Location = new Point(169, 19);
			checkBoxNavigateOnlyConflictHunks.Name = "checkBoxNavigateOnlyConflictHunks";
			checkBoxNavigateOnlyConflictHunks.Size = new Size(90, 19);
			checkBoxNavigateOnlyConflictHunks.TabIndex = 14;
			checkBoxNavigateOnlyConflictHunks.Text = "충돌 지점만";
			checkBoxNavigateOnlyConflictHunks.UseVisualStyleBackColor = true;
			// 
			// FormMainDiff
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1284, 781);
			Controls.Add(splitContainerBottom);
			Controls.Add(panelTop);
			Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 4, 3, 4);
			Name = "FormMainDiff";
			Text = "XlsxMerge";
			WindowState = FormWindowState.Maximized;
			Load += FormMainDiff_Load;
			panelTop.ResumeLayout(false);
			panel2.ResumeLayout(false);
			splitContainerBottom.Panel1.ResumeLayout(false);
			splitContainerBottom.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainerBottom).EndInit();
			splitContainerBottom.ResumeLayout(false);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panelMergeHunksOn.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			ResumeLayout(false);
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
		private CheckBox checkBoxNavigateOnlyConflictHunks;
	}
}