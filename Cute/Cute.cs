using System;

namespace CuteNamespace
{
    public class Cute
    {
        private readonly Girl _girl;
        // why shes not cute
        public string Reason { get; set; }

        public Cute(Girl girl)
        {
            _girl = girl;
        }

        public Boolean IsCute()
        {
            if (_girl.Languages.Contains("Spanish"))
            {
                return true;
            }
            if (_girl.Weight > GirlConstants.MAX_WEIGHT)
            {
                Reason = "overweight";
                return false;
            }

            if (_girl.Height > GirlConstants.MAX_HEIGHT)
            {
                Reason = "Too tall";
                return false;
            }

            if (_girl.Waist > GirlConstants.MAX_WAIST)
            {
                Reason = "Waist too big";
                return false;
            }
            if (_girl.Hips > GirlConstants.MAX_HIPS)
            {
                Reason = "Hips too big";
                return false;
            }

            double WHR = _girl.Waist / _girl.Hips;
            if (WHR > GirlConstants.MAX_WHR)
            
            {
                Reason = "WHR too big";
                return false;
            }
            if (WHR < GirlConstants.MIN_WHR)
            {
                Reason = "WHR too small";
                return false;
            }


            return true;
        }
    }
}
