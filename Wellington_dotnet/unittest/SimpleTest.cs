using System;
using bll;
using Xunit;

namespace unittest
{
    public class  SimpleTest
    {   private readonly SimpleClass s;
        public SimpleTest(){
            this.s  = new SimpleClass();
        }
        [Fact]
        public void Test1()
        {
            
            Assert.Equal(s.isPar(2),true);
            

        }
    }
}
