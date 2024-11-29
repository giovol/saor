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

namespace saor.Core
{
    public static class BootManager
    {
        public static void Boot()
        {
            // Initialize the sound manager
            try
            {
                Program.soundManager = new();
            }
            catch (Exception ex)
            {
                // If the sound manager fails to initialize, the system will continue to boot without sound
                Console.WriteLine("Failed to initialize the sound manager: " + ex.Message);
            }
        }
    }
}
