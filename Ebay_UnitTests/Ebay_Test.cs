using Ebay_API2.EbayApi;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebay_UnitTests
{
    [TestFixture]
    public class Ebay_UnitTest
    {
        [Test]
        public async Task Ebay_SandBoxBrowse()
        {
            var result = await Ebay_API.SandBoxBrowse();
            Assert.IsNotEmpty(result);
           
        }
    }
}
