

using IL2CPU.API.Attribs;

namespace saor.Core
{
    public class Resources
    {
        [ManifestResourceStream(ResourceName = "saor.Resources.bootSound.wav")]
        public static byte[] bootSound;
    }
}
