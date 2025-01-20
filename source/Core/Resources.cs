#pragma warning disable CS0649

using IL2CPU.API.Attribs;
using PrismAPI.Graphics;
using PrismAPI.Graphics.Fonts;

namespace saor.Core
{
    public static class Resources
    {
        [ManifestResourceStream(ResourceName = "saor.Resources.DefaultFont.btf")] public static byte[] rawFont;
        public static Font Font = new Font(rawFont, 16);

        [ManifestResourceStream(ResourceName = "saor.Resources.Mouse.bmp")] private static byte[] rawMouse;
        public static Canvas Mouse;

        [ManifestResourceStream(ResourceName = "saor.Resources.MouseText.bmp")] private static byte[] rawMouseText;
        public static Canvas MouseText;

        [ManifestResourceStream(ResourceName = "saor.Resources.MouseDrag.bmp")] private static byte[] rawMouseDrag;
        public static Canvas MouseDrag;

        [ManifestResourceStream(ResourceName = "saor.Resources.Busy.bmp")] private static byte[] rawBusy;
        public static Canvas Busy;

        [ManifestResourceStream(ResourceName = "saor.Resources.Link.bmp")] private static byte[] rawLink;
        public static Canvas Link;

        [ManifestResourceStream(ResourceName = "saor.Resources.Error.bmp")] private static byte[] rawError;
        public static Canvas Error;

        [ManifestResourceStream(ResourceName = "saor.Resources.Background.bmp")] private static byte[] rawBackground;
        public static Canvas Background;

        public static void GenerateFont() => Font = new Font(rawFont, 16);

        public static void Initialize()
        {
            Mouse = Image.FromBitmap(rawMouse, false);
            MouseText = Image.FromBitmap(rawMouseText, false);
            MouseDrag = Image.FromBitmap(rawMouseDrag, false);
            Busy = Image.FromBitmap(rawBusy, false);
            Link = Image.FromBitmap(rawLink, false);
            Error = Image.FromBitmap(rawError, false);
            Background = Image.FromBitmap(rawBackground, false);
        }
    }
}