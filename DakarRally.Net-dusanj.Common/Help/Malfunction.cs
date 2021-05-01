using DakarRally.Net_dusanj.Common.Enum;
using System;

namespace DakarRally.Net_dusanj.Common.Help
{
    public static class Malfunction
    {
        public static MalfunctionTypeEnum Probability(int light, int heavy)
        {
            MalfunctionTypeEnum result;

            result = MalfunctionType(light);

            if (result == MalfunctionTypeEnum.None)
            {
                result = MalfunctionType(heavy);
            }
            return result;
        }


        private static MalfunctionTypeEnum MalfunctionType(int param)
        {
            if (IsMalfunction(param))
            {
                return MalfunctionTypeEnum.Light;
            }

            if (IsMalfunction(param))
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
