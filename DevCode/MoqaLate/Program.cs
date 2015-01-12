﻿using System;
using MoqaLate.Common;
using MoqaLate.Infastructure;
using Ninject;

namespace MoqaLate
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var kernel = new StandardKernel(new DefaultNinjectModule());

                var logger = kernel.Get<ILogger>();

                logger.Write("MoqaLate Starting...");

                var sourceDir = "C:\\Development\\Windows\\EIM_moqa\\varna_windows\\EIM\\EIM.Shared";
                var destinationDir = "C:\\Development\\Windows\\EIM_moqa\\varna_windows\\EIMWindowsUnitTests\\MoqaLateGeneratedMocks";

                logger.Write("Source dir = " + sourceDir);
                logger.Write("Destination dir = " + destinationDir);

                kernel.Get<Engine>().Process(sourceDir, destinationDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Environment.Exit(-1);                
            }
        }
    }
}
