/*
 * SoundManager in saor.Audio
 * 
 * The saor project
 * © 2024 Giovanni Voltan
 * Code released under the BSD 3-Clause "New" or "Revised" License
 * License information: https://github.com/g1opto/saor/blob/main/LICENSE
 * Project link: https://github.com/g1opto/saor
 */

using Cosmos.HAL.Drivers.Audio;
using Cosmos.System.Audio;

namespace saor.Audio
{
    public class SoundManager
    {
        public readonly AudioMixer Mixer;
        private readonly AudioManager Manager;
        public bool Enabled;
        public SoundManager()
        {
            Mixer = new();
            Manager = new()
            {
                Output = AC97.Initialize(4096),
                Stream = Mixer
            };
            Manager.Enable();
        }
        public void Play(AudioStream stream)
        {
            Mixer.Streams.Add(stream);
        }
    }
}
