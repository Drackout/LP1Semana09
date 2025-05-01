using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        public bool Order{get;set;}

        
        public CompareByName(){}

        public CompareByName(bool order)
        {
            Order = order;
        }

        public int Compare(Player x, Player y)
        {
            if (Order == true)
                return x.Score.CompareTo(y.Score);
            if (Order == false)
                return (x.Score.CompareTo(y.Score))*(-1);

            return x.Name.CompareTo(y.Name);
        }
    }
}