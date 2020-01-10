using ExtensionMehods.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExtensionMethods.Tests
{
    public class TargetTests
    {
        [Fact]
        public void StandardizedId()
        {
            var obj = new Target("id01");
            Assert.Equal("ID01", obj.GetStandardizedId());
        }
    }
}
