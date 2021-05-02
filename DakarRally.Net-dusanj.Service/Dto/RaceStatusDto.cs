using DakarRally.Net_dusanj.Common.Enum;

namespace DakarRally.Net_dusanj.Service.Dto
{
    public class RaceStatusDto
    {
        public RaceStatusEnum RaceStatus { get; set; }
        public int CarNumber { get; set; }
        public int TruckNumber { get; set; }
        public int MotorcycleNumber{ get; set; }
    }
}
