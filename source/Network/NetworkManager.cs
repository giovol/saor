/*
 * NetworkManager in saor.Network
 * 
 * The saor project
 * © 2024 Giovanni Voltan
 * Code released under the BSD 3-Clause "New" or "Revised" License
 * License information: https://github.com/g1opto/saor/blob/main/LICENSE
 * Project link: https://github.com/g1opto/saor
 */

using Cosmos.System.Network.IPv4.UDP.DHCP;

namespace saor.Network
{
    public class NetworkManager
    {
        public NetworkManager()
        {
            _ = new DHCPClient().SendDiscoverPacket();

        }
    }
}
