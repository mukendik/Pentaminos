using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentaminos
{
    [TestFixture]
    public class TestListePentaminos
    {
        [Test]
        public void TestTotalPentaminos()
        {
            Assert.That(FabriqueDePentaminos.ListeDePentaminos().Count,Is.EqualTo(63));
        }
    }
}
