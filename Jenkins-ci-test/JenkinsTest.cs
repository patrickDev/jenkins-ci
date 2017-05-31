using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Jenkins_ci_test
{
    public  class JenkinsTest
    {
        [Fact]
        public  void FirstTest()
        {
            Assert.True(true);
        }



        [Fact]
        public void SecondTest()
        {
            Assert.True(false);
        }

    }
}
