using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using XlsxMerge.Properties;

namespace NexonKorea.XlsxMerge
{
    partial class FormWelcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcome));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxBase = new System.Windows.Forms.GroupBox();
            this.buttonPathBase = new System.Windows.Forms.Button();
            this.textBoxPathBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxUse3WayMerge = new System.Windows.Forms.CheckBox();
            this.groupBoxMine = new System.Windows.Forms.GroupBox();
            this.buttonPathMine = new System.Windows.Forms.Button();
            this.textBoxPathMine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxTheirs = new System.Windows.Forms.GroupBox();
            this.buttonPathTheirs = new System.Windows.Forms.Button();
            this.textBoxPathTheirs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCommandline = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.buttonPathResult = new System.Windows.Forms.Button();
            this.textBoxPathResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxBase.SuspendLayout();
            this.groupBoxMine.SuspendLayout();
            this.groupBoxTheirs.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "환영합니다! 비교할 엑셀 파일을 아래에서 선택해 주세요.";
            // 
            // groupBoxBase
            // 
            this.groupBoxBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBase.Controls.Add(this.buttonPathBase);
            this.groupBoxBase.Controls.Add(this.textBoxPathBase);
            this.groupBoxBase.Controls.Add(this.label2);
            this.groupBoxBase.Location = new System.Drawing.Point(15, 159);
            this.groupBoxBase.Name = "groupBoxBase";
            this.groupBoxBase.Size = new System.Drawing.Size(876, 74);
            this.groupBoxBase.TabIndex = 1;
            this.groupBoxBase.TabStop = false;
            this.groupBoxBase.Text = "Base 파일 경로";
            // 
            // buttonPathBase
            // 
            this.buttonPathBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPathBase.Location = new System.Drawing.Point(833, 37);
            this.buttonPathBase.Name = "buttonPathBase";
            this.buttonPathBase.Size = new System.Drawing.Size(37, 23);
            this.buttonPathBase.TabIndex = 1;
            this.buttonPathBase.Text = "...";
            this.buttonPathBase.UseVisualStyleBackColor = true;
            this.buttonPathBase.Click += new System.EventHandler(this.buttonPathXlsx_Click);
            // 
            // textBoxPathBase
            // 
            this.textBoxPathBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPathBase.Location = new System.Drawing.Point(6, 37);
            this.textBoxPathBase.Name = "textBoxPathBase";
            this.textBoxPathBase.Size = new System.Drawing.Size(821, 23);
            this.textBoxPathBase.TabIndex = 0;
            this.textBoxPathBase.TextChanged += new System.EventHandler(this.textBoxPathBase_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "수정하기 전 버전의 엑셀 파일 경로를 입력해 주세요.";
            // 
            // checkBoxUse3WayMerge
            // 
            this.checkBoxUse3WayMerge.AutoSize = true;
            this.checkBoxUse3WayMerge.Checked = true;
            this.checkBoxUse3WayMerge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUse3WayMerge.Location = new System.Drawing.Point(15, 334);
            this.checkBoxUse3WayMerge.Name = "checkBoxUse3WayMerge";
            this.checkBoxUse3WayMerge.Size = new System.Drawing.Size(115, 19);
            this.checkBoxUse3WayMerge.TabIndex = 3;
            this.checkBoxUse3WayMerge.Text = "3-way 머지 사용";
            this.checkBoxUse3WayMerge.UseVisualStyleBackColor = true;
            this.checkBoxUse3WayMerge.CheckedChanged += new System.EventHandler(this.checkBoxUse3WayMerge_CheckedChanged);
            // 
            // groupBoxMine
            // 
            this.groupBoxMine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMine.Controls.Add(this.buttonPathMine);
            this.groupBoxMine.Controls.Add(this.textBoxPathMine);
            this.groupBoxMine.Controls.Add(this.label3);
            this.groupBoxMine.Location = new System.Drawing.Point(15, 239);
            this.groupBoxMine.Name = "groupBoxMine";
            this.groupBoxMine.Size = new System.Drawing.Size(876, 74);
            this.groupBoxMine.TabIndex = 2;
            this.groupBoxMine.TabStop = false;
            this.groupBoxMine.Text = "Mine (Destination, Current) 파일 경로";
            // 
            // buttonPathMine
            // 
            this.buttonPathMine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPathMine.Location = new System.Drawing.Point(833, 37);
            this.buttonPathMine.Name = "buttonPathMine";
            this.buttonPathMine.Size = new System.Drawing.Size(37, 23);
            this.buttonPathMine.TabIndex = 1;
            this.buttonPathMine.Text = "...";
            this.buttonPathMine.UseVisualStyleBackColor = true;
            this.buttonPathMine.Click += new System.EventHandler(this.buttonPathXlsx_Click);
            // 
            // textBoxPathMine
            // 
            this.textBoxPathMine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPathMine.Location = new System.Drawing.Point(6, 37);
            this.textBoxPathMine.Name = "textBoxPathMine";
            this.textBoxPathMine.Size = new System.Drawing.Size(821, 23);
            this.textBoxPathMine.TabIndex = 0;
            this.textBoxPathMine.TextChanged += new System.EventHandler(this.textBoxPathBase_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "수정한 버전의 엑셀 파일 경로를 입력해 주세요.";
            // 
            // groupBoxTheirs
            // 
            this.groupBoxTheirs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTheirs.Controls.Add(this.buttonPathTheirs);
            this.groupBoxTheirs.Controls.Add(this.textBoxPathTheirs);
            this.groupBoxTheirs.Controls.Add(this.label6);
            this.groupBoxTheirs.Location = new System.Drawing.Point(15, 359);
            this.groupBoxTheirs.Name = "groupBoxTheirs";
            this.groupBoxTheirs.Size = new System.Drawing.Size(876, 74);
            this.groupBoxTheirs.TabIndex = 4;
            this.groupBoxTheirs.TabStop = false;
            this.groupBoxTheirs.Text = "Theirs (Source, Others) 파일 경로";
            // 
            // buttonPathTheirs
            // 
            this.buttonPathTheirs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPathTheirs.Location = new System.Drawing.Point(833, 37);
            this.buttonPathTheirs.Name = "buttonPathTheirs";
            this.buttonPathTheirs.Size = new System.Drawing.Size(37, 23);
            this.buttonPathTheirs.TabIndex = 1;
            this.buttonPathTheirs.Text = "...";
            this.buttonPathTheirs.UseVisualStyleBackColor = true;
            this.buttonPathTheirs.Click += new System.EventHandler(this.buttonPathXlsx_Click);
            // 
            // textBoxPathTheirs
            // 
            this.textBoxPathTheirs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPathTheirs.Location = new System.Drawing.Point(6, 37);
            this.textBoxPathTheirs.Name = "textBoxPathTheirs";
            this.textBoxPathTheirs.Size = new System.Drawing.Size(821, 23);
            this.textBoxPathTheirs.TabIndex = 0;
            this.textBoxPathTheirs.TextChanged += new System.EventHandler(this.textBoxPathBase_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "수정 전 버전의 엑셀 파일 경로를 입력해 주세요.";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LightCyan;
            this.buttonStart.Location = new System.Drawing.Point(403, 547);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(97, 42);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "비교 시작";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 609);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(488, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Command Line 예제 : 다음과 같이 명령줄에서 입력하면 동일한 결과를 얻을 수 있습니다.";
            // 
            // textBoxCommandline
            // 
            this.textBoxCommandline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommandline.Font = new System.Drawing.Font("Consolas", 11F);
            this.textBoxCommandline.Location = new System.Drawing.Point(15, 627);
            this.textBoxCommandline.Multiline = true;
            this.textBoxCommandline.Name = "textBoxCommandline";
            this.textBoxCommandline.ReadOnly = true;
            this.textBoxCommandline.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCommandline.Size = new System.Drawing.Size(876, 64);
            this.textBoxCommandline.TabIndex = 8;
            this.textBoxCommandline.WordWrap = false;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResult.Controls.Add(this.buttonPathResult);
            this.groupBoxResult.Controls.Add(this.textBoxPathResult);
            this.groupBoxResult.Controls.Add(this.label5);
            this.groupBoxResult.Location = new System.Drawing.Point(15, 467);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(876, 74);
            this.groupBoxResult.TabIndex = 5;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "결과 파일 경로 미리 지정";
            // 
            // buttonPathResult
            // 
            this.buttonPathResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPathResult.Location = new System.Drawing.Point(833, 37);
            this.buttonPathResult.Name = "buttonPathResult";
            this.buttonPathResult.Size = new System.Drawing.Size(37, 23);
            this.buttonPathResult.TabIndex = 2;
            this.buttonPathResult.Text = "...";
            this.buttonPathResult.UseVisualStyleBackColor = true;
            this.buttonPathResult.Click += new System.EventHandler(this.buttonPathResult_Click);
            // 
            // textBoxPathResult
            // 
            this.textBoxPathResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPathResult.Location = new System.Drawing.Point(6, 37);
            this.textBoxPathResult.Name = "textBoxPathResult";
            this.textBoxPathResult.Size = new System.Drawing.Size(821, 23);
            this.textBoxPathResult.TabIndex = 1;
            this.textBoxPathResult.TextChanged += new System.EventHandler(this.textBoxPathBase_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(573, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "결과를 저장할 엑셀 파일의 경로를 입력해 주세요. 입력하지 않을 경우 최종 저장 시 경로를 입력받습니다.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel 파일(*.xls*)|*.xls*|모든 파일|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "xlsx";
            this.saveFileDialog1.Filter = "Excel 파일(*.xls*)|*.xls*|모든 파일|*.*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XlsxMerge.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(121, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(418, 45);
            this.label7.TabIndex = 0;
            this.label7.Text = "XlsxMerge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.label8.Location = new System.Drawing.Point(124, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(332, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "2-way diff / 3-way merge tool for Excel";
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 728);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxCommandline);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.checkBoxUse3WayMerge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxTheirs);
            this.Controls.Add(this.groupBoxMine);
            this.Controls.Add(this.groupBoxBase);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormWelcome";
            this.Text = "XlsxMerge";
            this.Load += new System.EventHandler(this.FormWelcome_Load);
            this.groupBoxBase.ResumeLayout(false);
            this.groupBoxBase.PerformLayout();
            this.groupBoxMine.ResumeLayout(false);
            this.groupBoxMine.PerformLayout();
            this.groupBoxTheirs.ResumeLayout(false);
            this.groupBoxTheirs.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBoxBase;
        private Button buttonPathBase;
        private TextBox textBoxPathBase;
        private Label label2;
        private CheckBox checkBoxUse3WayMerge;
        private GroupBox groupBoxMine;
        private Button buttonPathMine;
        private TextBox textBoxPathMine;
        private Label label3;
        private GroupBox groupBoxTheirs;
        private Button buttonPathTheirs;
        private TextBox textBoxPathTheirs;
        private Label label6;
        private Button buttonStart;
        private Label label4;
        private TextBox textBoxCommandline;
        private GroupBox groupBoxResult;
        private Button buttonPathResult;
        private TextBox textBoxPathResult;
        private Label label5;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
    }
}

