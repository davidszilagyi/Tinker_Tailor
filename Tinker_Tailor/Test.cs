using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tinker_Tailor
{
    [TestFixture]
    class Test
    {
        private Solver<int> test1 = new Solver<int>();
        private Solver<string> test2 = new Solver<string>();

        [Test]
        public void TestSolution()
        {
            Assert.AreEqual(new int[] { 4 }, test1.Solve(3, 1, 2, 3, 4, 5));
        }

    }
}
