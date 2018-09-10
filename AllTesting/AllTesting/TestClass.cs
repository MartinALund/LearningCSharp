using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AllTesting
{
    public class TestClass
    {

        [Fact]
        void PositiveTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        void NegativeTest()
        {
            Assert.Equal(4, Add(2, 3));
        }
   

        int Add(int a, int b)
        {
            return a + b;
        }
    }
}
