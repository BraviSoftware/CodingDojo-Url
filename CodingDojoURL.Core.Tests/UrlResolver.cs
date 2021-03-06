﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingDojoURL.Core.Tests
{
    class UrlResolver
    {
        public readonly string Url;

        public UrlResolver(string url)
        {
            Url = url;
        }

        public string Protocol
        {
            get
            {
                var protocol = Url.Substring(0, Url.IndexOf(':'));
                return protocol;
            }
        }

        public string Domain
        {
            get
            {
                if (IsProtocolSsh())
                    return Url.Split('@')[1].Replace("/", string.Empty);

                var split = Url.Split('/');
                return split[2].Replace("www.", string.Empty);
            }
        }

        public string Host
        {
            get
            {
                if (IsProtocolSsh())
                    return string.Empty;    

                var split = Url.Split('/');
                return split[2].Split('.')[0];
            }
        }

        public string Path
        {
            get { return string.Empty; }
        }

        private bool IsProtocolSsh()
        {
            return Protocol.ToLower().Equals("ssh");
        }
    }
}
