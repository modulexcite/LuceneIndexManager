﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuceneIndexManager.Util
{
    public static class LogExtensions
    {
        public static void Info(this string message, params object[] p)
        {
            System.Diagnostics.Debug.WriteLine(String.Format(message, p));
        }

        public static void Error(this string message, params object[] p)
        {
            System.Diagnostics.Debug.WriteLine(String.Format(message, p));
        }

        public static void Debug(this string message, params object[] p)
        {
            System.Diagnostics.Debug.WriteLine(String.Format(message, p));
        }
    }
}
