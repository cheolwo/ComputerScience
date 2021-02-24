using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetworkModule.Model
{
    public class Network 
    {
        [Key] public int NetworkNo { get; set; }
        public Address Address { get; set; }
        public List<Wan> Wans { get; set; }
    }

    public class Lan 
    {
        [Key] public int LanNo { get; set; }
        public Address Address { get; set; }
        public List<Node> Nodes { get; set; }
        public Wan Wan { get; set; }
    }

    public class Wan 
    {
        [Key] public int WanNo { get; set; }
        public Address Address { get; set; }
        public List<Lan> Lans { get; set; }
    }

    public class Router
    {
        
    }

    public enum Country { Korea = 0, China = 1, Japan = 2, America = 3, Canada = 4, France = 5, 
                   Mongol = 6, Rusia = 7, Taiwan = 8, India = 9, England = 10}

    /// <summary>
    /// Computer
    /// </summary>
    /// 
    public class Address
    {
        [Key] public string MacAddress { get; set; }
        public string IpAddress { get; set; }
        public string DomainName { get; set; }
        public Country Country { get; set; }
    }

    public class Node
    {
        [Key] public int NodeNo { get; set; }
        public Address Address { get; set; }
        public string IpAddress { get; set; }

        public Lan Lan { get; set; }
    }

    public class IPv6BasicHeader
    {
        public IpVersion Version { get; set; }
        public Priority Priority { get; set; }
        public string FlowLabe { get; set; }
        public int PayloadLength { get; set; }
        public NextHeader NextHeader { get; set; }
        public string SouceAddress { get; set; }
        public string DestinationAdress { get; set; }
    }

    

    public enum IpVersion { IPv4 = 4, IPv6 = 6}
    public enum Priority { Emergency = 0, Normal = 1, Easy = 2}
    public enum NextHeader { HopbyBop = 0, Destination = 60, SourceRouting = 43, Framentation = 44, 
        AH = 51, UDP = 17, TCP = 6 }
}
