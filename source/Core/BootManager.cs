/*
 * BootManager in saor.Core
 * 
 * The saor project
 * © 2024 Giovanni Voltan
 * Code released under the BSD 3-Clause "New" or "Revised" License
 * License information: https://github.com/g1opto/saor/blob/main/LICENSE
 * Project link: https://github.com/g1opto/saor
 */


using System;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;

namespace saor.Core
{
    public static class BootManager
    {
        public static void Boot()
        {
            // Initialize the console
            CustomConsole.WriteDebug("Initializing console...");
            try
            {
                VGAScreen.SetFont(PCScreenFont.Default.CreateVGAFont(), PCScreenFont.Default.Height);
                CustomConsole.WriteSuccess("Console initialized");
            }
            catch (Exception ex)
            {
                CustomConsole.WriteError("Failed to initialize console: " + ex.Message);
            }
            // Initialize the sound manager
            CustomConsole.WriteDebug("Initializing sound manager...");
            try
            {
                Program.soundManager = new();
                CustomConsole.WriteSuccess("Sound manager initialized");
            }
            catch (Exception ex)
            {
                // If the sound manager fails to initialize, the system will continue to boot without sound
                CustomConsole.WriteError("Failed to initialize sound manager: " + ex.Message);
            }

        }
    }
}
