using ExtensionMehods.Library;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace ExtensionMethods.Tests
{
    public class ConfigurationTests
    {
        [Fact]
        public void IsLoaded()
        {
            IConfiguration config = null;
            Assert.False(config.IsLoaded());
        }

        [Fact]
        public void AddStandardProviders()
        {
            var builder = new ConfigurationBuilder();
            var config = builder.AddStandardProviders().Build();

            Assert.Equal(4, config.Providers.Count());
            Assert.True(config.IsLoaded());
        }
    }
}
