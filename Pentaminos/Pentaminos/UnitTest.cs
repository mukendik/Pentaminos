using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentaminos
{
    class UnitTest
    {
        [Test]
        public void TestDescription()
        {
            Assert.That(Program.Description.Length,Is.GreaterThan(0));
        }

    }
}
