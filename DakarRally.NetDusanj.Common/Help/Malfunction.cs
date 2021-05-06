using DakarRally.NetDusanj.Common.Enum;
using System;

namespace DakarRally.NetDusanj.Common.Help
{
    public static class Malfunction
    {
        public static MalfunctionTypeEnum Probability(int light, int heavy)
        {
            MalfunctionTypeEnum result;

            result = MalfunctionType(light, MalfunctionTypeEnum.Light);

            if (result == MalfunctionTypeEnum.None)
            {
                result = MalfunctionType(heavy, MalfunctionTypeEnum.Heavie);
            }
            return result;
        }


        private static MalfunctionTypeEnum MalfunctionType(int param, MalfunctionTypeEnum type)
        {
            if (IsMalfunction(param) && type == MalfunctionTypeEnum.Light)
            {
                return MalfunctionTypeEnum.Light;
            }

            if (IsMalfunction(param) && type == MalfunctionTypeEnum.Heavie)
            {
                return MalfunctionTypeEnum.Heavie;
            }

            return MalfunctionTypeEnum.None;
        }

        private static bool IsMalfunction(int param)
        {
            Random gen = new Random();
            int prob = gen.Next(100);
            return prob <= param;
        }
    }
}
