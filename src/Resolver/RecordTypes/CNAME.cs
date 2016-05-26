﻿using System;
using System.Text;
using System.Net;
using DnsShell.Resolver;
using System.IO;

namespace DnsShell.Resolver
{
    public class CNAME : ResourceRecord
    {
        //                                    1  1  1  1  1  1
        //      0  1  2  3  4  5  6  7  8  9  0  1  2  3  4  5
        //    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
        //    /                     CNAME                     /
        //    /                                               /
        //    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

        public String Hostname { get; private set; }

        internal CNAME(EndianBinaryReader Reader)
        {
            base.UpdateProperties(Reader);
            Hostname = DnsPacket.DecodeName(Reader);
            base.RecordData = Hostname.ToString();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}