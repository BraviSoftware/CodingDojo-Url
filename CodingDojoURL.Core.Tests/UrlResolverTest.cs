using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodingDojoURL.Core.Tests
{
    [TestFixture]
    public class UrlResolverTest
    {
        private UrlResolver _httpResolver;
        private UrlResolver _sshResolver;

        [SetUp]
        public void Setup()
        {
            _httpResolver = new UrlResolver("http://www.google.com/mail/user=fulano");
            _sshResolver = new UrlResolver("ssh://fulano%senha@git.com/");
        }

        [Test]
        public void GivenUrlShouldResolveProtocol_WhenItIs_HTTP()
        {
            Assert.That("http", Is.EqualTo(_httpResolver.Protocol));
        }
        [Test]
        public void GivenUrlShouldResolveDomain_WhenItIs_Http()
        {
            Assert.That("google.com", Is.EqualTo(_httpResolver.Domain));
        }
        [Test]
        public void GivenUrlShouldResolveHost_WhenItIs_Http()
        {
            Assert.That("www", Is.EqualTo(_httpResolver.Host));
        }
        [Test]
        public void GivenUrlShouldResolvePath_WhenItIs_Http()
        {
            Assert.That("mail", Is.EqualTo(_httpResolver.Path));
        }

        [Test]
        public void GivenUrlShouldResolveAnotherPath_WhenItIs_Http()
        {
            _httpResolver = new UrlResolver("http://www.google.com/mail232/user=fulano");
            Assert.That("mail232", Is.EqualTo(_httpResolver.Path));
        }

        [Test]
        public void GivenUrlShouldResolveAnotherAnotherPath_WhenItIs_Http()
        {
            _httpResolver = new UrlResolver("http://www.google.com/mail/curriculum/user=fulano");
            Assert.That("mail/curriculum", Is.EqualTo(_httpResolver.Path));
        }


        [Test]
        public void GivenUrlShouldResolveProtocol_WhenItIs_SSH()
        {
            Assert.That("ssh", Is.EqualTo(_sshResolver.Protocol));
        }
        [Test]
        public void GivenUrlShouldResolveHost_WhenItIs_Ssh()
        {
            Assert.That(string.Empty, Is.EqualTo(_sshResolver.Host));
        }
        [Test]
        public void GivenUrlShouldResolveDomain_WhenItIs_Ssh()
        {
            Assert.That("git.com", Is.EqualTo(_sshResolver.Domain));
        }
      

    }
}
