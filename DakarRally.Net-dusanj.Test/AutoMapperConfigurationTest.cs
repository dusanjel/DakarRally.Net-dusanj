using AutoMapper;
using DakarRally.Net_dusanj.Service.AutoMapper.Profiles;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DakarRally.Net_dusanj.Test
{
    [TestClass]
    public class AutoMapperConfigurationTest
    {
        [TestMethod]
        public void AssertConfigurationIsValid()
        {
            var configuration = new MapperConfiguration(config =>
            {
                config.AddProfile<VehicleProfile>();
            });

            configuration.AssertConfigurationIsValid();
        }
    }
}
