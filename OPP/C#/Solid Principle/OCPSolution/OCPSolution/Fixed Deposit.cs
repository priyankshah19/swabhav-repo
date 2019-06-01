using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolution
{
    class FixedDeposit
    {
        private string _name;
        private double _principalamount;
        private int _duration;
        private IFestivalRate _festivaltype;
        public FixedDeposit(string name, double principalamount, int duration, IFestivalRate festivaltype)
        {
            this._name = name;
            this._principalamount = principalamount;
            this._duration = duration;
            this._festivaltype = festivaltype;
        }
        public string Name { get { return _name; } }
        public double PrincipalAmount { get { return _principalamount; } }
        
        public double CalculateSimpleInterest()
        {
            double simpleinterest = _principalamount *_festivaltype.Rate() * _duration;
            return simpleinterest;
        }
    }
}
