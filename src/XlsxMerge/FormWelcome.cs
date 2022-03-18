using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NexonKorea.XlsxMerge;

namespace NexonKorea.XlsxMerge
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void textBoxPathBase_TextChanged(object sender, EventArgs e)
        {
            previewCommandLine();
        }

        private void previewCommandLine()
        {
            var resultArgs = buildArguments();
            if (resultArgs == null)
                textBoxCommandline.Text = "모든 경로를 입력한 후에 예제를 확인할 수 있습니다.";
            else
                textBoxCommandline.Text = String.Join(" ", resultArgs);
        }

        private List<string> buildArguments()
        {
            var args = new List<string>();

            args.Add(Path.GetFileName(Assembly.GetEntryAssembly().Location));
            args.Add($"-b={AddDoubleQuote(textBoxPathBase.Text)}");
            args.Add($"-d={AddDoubleQuote(textBoxPathMine.Text)}");
            if (checkBoxUse3WayMerge.Checked)
                args.Add($"-s={AddDoubleQuote(textBoxPathTheirs.Text)}");
            if (string.IsNullOrEmpty(textBoxPathResult.Text) == false)
                args.Add($"-r={AddDoubleQuote(textBoxPathResult.Text)}");

            string resultArgs = String.Join(" ", args);
            if (resultArgs.Contains("=\"\""))
                return null;

            return args;
        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {
            this.Text = VersionName.GetFormTitleText();
            previewCommandLine();
        }

        private void buttonPathXlsx_Click(object sender, EventArgs e)
        {
            TextBox targetTextbox = null;
            foreach (var childControl in (sender as Control).Parent.Controls)
            {
                targetTextbox = childControl as TextBox;
                if (targetTextbox != null)
                    break;
            }

            if (targetTextbox == null)
                return;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            targetTextbox.Text = openFileDialog1.FileName;
        }

        private void checkBoxUse3WayMerge_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTheirs.Enabled = checkBoxUse3WayMerge.Checked;
            previewCommandLine();
        }

        private void buttonPathResult_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            textBoxPathResult.Text = saveFileDialog1.FileName;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            var resultArgs = buildArguments();
            if (resultArgs == null)
            {
                MessageBox.Show("모든 경로를 입력한 후에 실행이 가능합니다.");
                return;
            }
            var argumentInfo = new MergeArgumentInfo(resultArgs.ToArray());
            var formMainDiff = new FormMainDiff();
            formMainDiff.MergeArgs = argumentInfo;
            formMainDiff.ShowDialog();
            Close();
        }

        private static string AddDoubleQuote(string s)
        {
            if (s.StartsWith("\"") && s.EndsWith("\""))
                return s;
            return "\"" + s + "\"";
        }
    }
}
