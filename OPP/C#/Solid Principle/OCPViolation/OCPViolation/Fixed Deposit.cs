using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolation
{
    class FixedDeposit
    {
        private string _name;
        private double _principalamount;
        private int _duration;
        private Festivaltype _festivaltype;
        public FixedDeposit(string name, double principalamount, int duration, Festivaltype festivaltype)
        {
            this._name = name;
            this._principalamount = principalamount;
            this._duration = duration;
            this._festivaltype = festivaltype;
        }
        public string Name { get { return _name; } }
        public double PrincipalAmount { get { return _principalamount; } }
        public enum Festivaltype
        {
            Diwali, Holi, Normal
        }
        public double CalculateSimpleInterest()
        {
            double simpleinterest = 0;
            if (_festivaltype == Festivaltype.Normal)
            {
                return simpleinterest = _principalamount * _duration * 0.07;
            }
            else if (_festivaltype == Festivaltype.Diwali)
            {
                return simpleinterest = _principalamount * _duration * 0.09;

            }
            else if (_festivaltype == Festivaltype.Holi)
            {
                return simpleinterest = _principalamount * _duration * 0.08;

            }
            return 0;
        }
    }
}
