/*
 * NetworkManager in saor.Network
 * 
 * The saor project
 * © 2024 Giovanni Voltan
 * Code released under the BSD 3-Clause "New" or "Revised" License
 * License information: https://github.com/g1opto/saor/blob/main/LICENSE
 * Project link: https://github.com/g1opto/saor
 * Part of the code in this file is copied from AuraOS, wich is licensed under the BSD 3-Clause "New" or "Revised" License
 * Source: https://github.com/aura-systems/Aura-Operating-System/blob/02b557b19cc2f6e93303769d2b2628495b5689ec/SRC/Aura_OS/System/Network/Http.cs
 */

/*
* PROJECT:          Aura Operating System Development
* CONTENT:          Http utils class
* PROGRAMMER(S):    Valentin Charbonnier <valentinbreiz@gmail.com>
*/

using System;
using System.Net;
using System.Net.Sockets;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using Cosmos.System.Network.IPv4.UDP.DNS;
using CosmosHttp.Client;

namespace saor.Network
{
    public class NetworkManager
    {
        public DnsClient DNSClient;
        public NetworkManager()
        {
            _ = new DHCPClient().SendDiscoverPacket();
            DNSClient.Connect(new(1, 1, 1, 1));
        }
        public static ulong Ping(string address)
        {
            DateTime T = DateTime.Now;
            new TcpClient().Connect(address, 80);
            return (ulong)(DateTime.Now - T).TotalMilliseconds;
        }
        public static string DownloadFile(string url)
        {
            if (url.StartsWith("https://"))
            {
                throw new WebException("HTTPS currently not supported, please use http://");
            }

            string path = ExtractPathFromUrl(url);
            string domainName = ExtractDomainNameFromUrl(url);

            var dnsClient = new DnsClient();

            dnsClient.Connect(DNSConfig.DNSNameservers[0]);
            dnsClient.SendAsk(domainName);
            Address address = dnsClient.Receive();
            dnsClient.Close();

            HttpRequest request = new()
            {
                IP = address.ToString(),
                Domain = domainName,
                Path = path,
                Method = "GET"
            };
            request.Send();

            return request.Response.Content;
        }
        private static string ExtractDomainNameFromUrl(string url)
        {
            int start;
            if (url.Contains("://"))
            {
                start = url.IndexOf("://") + 3;
            }
            else
            {
                start = 0;
            }

            int end = url.IndexOf("/", start);
            if (end == -1)
            {
                end = url.Length;
            }

            return url[start..end];
        }


        private static string ExtractPathFromUrl(string url)
        {
            int start;
            if (url.Contains("://"))
            {
                start = url.IndexOf("://") + 3;
            }
            else
            {
                start = 0;
            }

            int indexOfSlash = url.IndexOf("/", start);
            if (indexOfSlash != -1)
            {
                return url[indexOfSlash..];
            }
            else
            {
                return "/";
            }
        }
    }
}
