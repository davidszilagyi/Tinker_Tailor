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
            Assert.AreEqual(new int[] { 3 }, test1.Solve(6, 1, 2, 3, 4));
            Assert.AreEqual(new int[] { 1 }, test1.Solve(4, 1, 2, 3, 4, 5, 6, 7, 8, 9));
            Assert.AreEqual(new string[] { "Coding" }, test2.Solve(3, "Codecool","Miskolc","2017","Coding", "Programming"));
            Assert.AreEqual(new string[] { "2017" }, test2.Solve(8, "Codecool", "Miskolc", "2017", "Coding"));
            Assert.AreEqual(new string[] { "Developer" }, test2.Solve(1, "Codecool", "Miskolc", "2017", "Coding", "Programming", "Sofware", "Developer"));
        }

    }
}
