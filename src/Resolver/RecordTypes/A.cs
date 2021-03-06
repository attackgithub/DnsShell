﻿using System;
using System.Text;
using System.Net;
using DnsShell.Resolver;
using System.IO;

namespace DnsShell.Resolver
{
    public class A : ResourceRecord
    {
        //                                    1  1  1  1  1  1
        //      0  1  2  3  4  5  6  7  8  9  0  1  2  3  4  5
        //    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
        //    |                    ADDRESS                    |
        //    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

        public IPAddress IPAddress { get; private set; }

        internal A(EndianBinaryReader Reader)
        {
            base.UpdateProperties(Reader);

            IPAddress = Reader.ReadIPAddress();

            base.RecordData = IPAddress.ToString();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
