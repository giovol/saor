using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IL2CPU.API.Attribs;
using PrismAPI.Graphics;
using PrismAPI.Graphics.Fonts;

namespace saor.Core
{
    public static class Resources
    {
        [ManifestResourceStream(ResourceName = "saor.Resources.DefaultFont.btf")]
        public static byte[] rawFont;
        public static Font Font = new Font(rawFont, 16);
        [ManifestResourceStream(ResourceName = "saor.Resources.Pointer.bmp")]
        public static byte[] rawPointer;
        public static Canvas Link = Image.FromBitmap(rawPointer);
        public static Canvas MouseText = Image.FromBitmap(rawPointer);
        public static Canvas Mouse = Image.FromBitmap(rawPointer);
        public static Canvas Background;
        [ManifestResourceStream(ResourceName = "saor.Resources.Error.bmp")]
        public static Canvas Error;
    }
}
