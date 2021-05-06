using DakarRally.NetDusanj.Common.Enum;

namespace DakarRally.NetDusanj.Service.Dto
{
    public class RaceStatusDto
    {
        public RaceStatusEnum RaceStatus { get; set; }
        public int CarNumber { get; set; }
        public int TruckNumber { get; set; }
        public int MotorcycleNumber{ get; set; }
    }
}
