using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NexonKorea.XlsxMerge
{
    public class MergeArgumentInfo
    {
        public MergeArgumentInfo(String[] args)
        {
            ParseArgument(args);

            ComparisonMode = ComparisonMode.Unknown;
            if (String.IsNullOrEmpty(BasePath) == false
                && String.IsNullOrEmpty(MinePath) == false)
            {
                ComparisonMode = ComparisonMode.TwoWay;
                if (String.IsNullOrEmpty(TheirsPath) == false)
                    ComparisonMode = ComparisonMode.ThreeWay;
            }
        }

        private void ParseArgument(String[] args)
        {
            // -<타입>=<경로> 형태. 타입 = b,d,s,r. 경로는 따옴표가 있을 수 있음.
            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/quantifiers-in-regular-expressions
            var regex = "^-([bBdDsSrRxX])=" + "\"{0,1}" + "([^\"]+)" + "\"{0,1}$";

            if ((args.Length > 1) && args[1].ToLower().StartsWith("-order="))
            {
                List<string> newArgs = new List<string>();
                string argOrder = args[1].ToLower().Substring("-order=".Length);
                for (int i = 0; i < argOrder.Length; i++)
                {
                    int argIndex = 2 + i;
                    if (argIndex < args.Length)
                        newArgs.Add("-" + argOrder[i] + "=\"" + args[argIndex] + "\"");
                }
                ParseArgument(newArgs.ToArray());
                return;
            }

            foreach (var eachArg in args)
            {
                var trimmedArg = eachArg.Trim();
                var m = Regex.Match(trimmedArg, regex);
                if (m.Success == false)
                    continue;

                string filePath = System.IO.Path.GetFullPath(m.Groups[2].Value);
                string pathFor = m.Groups[1].Value.ToLower();
                if (pathFor == "b")
                    BasePath = filePath;
                if (pathFor == "d")
                    MinePath = filePath;
                if (pathFor == "s")
                    TheirsPath = filePath;
	            if (pathFor == "r")
		            ResultPath = filePath;
				if (pathFor == "x")
					ExtraInfoPath = filePath;
            }
		}
        public string BasePath = null;
        public string MinePath = null;
        public string TheirsPath = null;
	    public string ResultPath = null;
		public string ExtraInfoPath = null; // PSCM 추가 정보가 담긴 파일.
        public readonly ComparisonMode ComparisonMode = ComparisonMode.Unknown;
    }

    public enum ComparisonMode
    {
        Unknown,
        TwoWay,
        ThreeWay
    }
}
