using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NexonKorea.XlsxMerge;

namespace XlsxMerge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var args = Environment.GetCommandLineArgs();

            MergeArgumentInfo argumentInfo = null;
            if (args.Length > 1)
            {
                argumentInfo = new MergeArgumentInfo(args);
                if (argumentInfo.ComparisonMode == ComparisonMode.Unknown)
                {
                    argumentInfo = null;
                    MessageBox.Show("명령줄 인수에 잘못되거나 누락된 값이 있습니다.");
                }
            }

            // 폴더 변경은 args 해석 이후에 합니다.
            string exeFolderPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            System.IO.Directory.SetCurrentDirectory(exeFolderPath);
            if (argumentInfo != null)
            {
                var formMainDiff = new FormMainDiff();
                formMainDiff.MergeArgs = argumentInfo;
                Application.Run(formMainDiff);
                if (formMainDiff.MergeSuccessful)
                    return 0;
            }
            else
            {
                Application.Run(new FormWelcome());
            }

            return 1;
        }
    }
}
