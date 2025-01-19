/*
 * BootManager in saor.Core
 * 
 * The saor project
 * © 2024 Giovanni Voltan
 * Code released under the BSD 3-Clause "New" or "Revised" License
 * License information: https://github.com/giovol/saor/blob/main/LICENSE
 * Project link: https://github.com/giovol/saor
 */


using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;

namespace saor.Core
{
    public static class BootManager
    {
        public static void Boot()
        {
            // Initialize font
            VGAScreen.SetFont(PCScreenFont.Default.CreateVGAFont(), PCScreenFont.Default.Height);
        }
    }
}
