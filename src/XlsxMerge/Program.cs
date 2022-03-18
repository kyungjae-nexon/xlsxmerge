namespace NexonKorea.XlsxMerge
{
    internal static class Program
    {
        [STAThread]
        static int Main()
        {
            ApplicationConfiguration.Initialize();

            var args = Environment.GetCommandLineArgs();

            MergeArgumentInfo? argumentInfo = null;
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
            string? exeFolderPath = Path.GetDirectoryName(path: System.Reflection.Assembly.GetEntryAssembly()?.Location);
            if (String.IsNullOrEmpty(exeFolderPath) == false)
                Directory.SetCurrentDirectory(exeFolderPath);

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