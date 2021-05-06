using AutoMapper;
using DakarRally.NetDusanj.Service.AutoMapper.Profiles;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DakarRally.NetDusanj.Test
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
                config.AddProfile<RaceProfile>();
            });

            configuration.AssertConfigurationIsValid();
        }
    }
}
