/*
 * Program in saor.Core
 * 
 * The saor project
 * © 2024 Giovanni Voltan
 * Code released under the BSD 3-Clause "New" or "Revised" License
 * License information: https://github.com/giovol/saor/blob/main/LICENSE
 * Project link: https://github.com/giovol/saor
 */

using Cosmos.System;

namespace saor.Core
{
    public class Program : Kernel
    {
        public static string OS_Name = "saor";
        public static string OS_Version = "debug channel";
        protected override void BeforeRun()
        {
            Mirage.DE.DesktopEnvironment.Start(OS_Name, OS_Version);
        }

        protected override void Run()
        {
        }
    }
}
