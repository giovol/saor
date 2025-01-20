#pragma warning disable CS0649

using IL2CPU.API.Attribs;
using PrismAPI.Graphics;
using PrismAPI.Graphics.Fonts;

namespace saor.Core
{
    public static class Resources
    {
        [ManifestResourceStream(ResourceName = "saor.Resources.Mouse.bmp")] private static byte[] rawMouse;
        public static Canvas Mouse = Image.FromBitmap(rawMouse);
        [ManifestResourceStream(ResourceName = "saor.Resources.wallpaper.bmp")] private static byte[] rawBackground;
        public static Canvas Background = Image.FromBitmap(rawBackground);
        [ManifestResourceStream(ResourceName = "saor.Resources.program.bmp")] private static byte[] rawProgram;
        public static Canvas Program = Image.FromBitmap(rawProgram);
    }
}