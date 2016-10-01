using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApplication
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine(@"Running Windows Service ist not possible on the command line. "
                              + @"Use InstallUtil.exe from dotnet framework to install the service!");

            #if DEBUG
            Thread.Sleep(10000);
            #endif

            System.ServiceProcess.ServiceBase.Run(new WinService());
        }
    }
}