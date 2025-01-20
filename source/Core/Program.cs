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
using PrismAPI.Hardware.GPU;
using saor.GUI.DE;

namespace saor.Core
{
    public class Program : Kernel
    {
        public static string OS_Name = "saor";
        public static string OS_Version = "debug channel";
        public static string Username = "user";
        public static string Copyright = "(c) 2025 Giovanni Voltan";
        public static Display Canvas;
        public static string Path = "0:\\";
        protected override void BeforeRun()
        {
            Resources.Initialize();
            WindowManager.Start();
        }

        protected override void Run()
        {
        }
    }
}
