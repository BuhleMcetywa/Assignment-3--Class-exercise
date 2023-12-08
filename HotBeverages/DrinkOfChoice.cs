using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotBeverages
{
    internal class DrinkOfChoice
    {
       private  string BeverageType;
        private int Sugar;
        private bool MilkOrNoMilk;

        public DrinkOfChoice(string beveragetype, int sugar, bool milkornoMilk)
        {
            BeverageType = beveragetype;
            Sugar = sugar;
            MilkOrNoMilk = milkornoMilk;

        }

        public string GetBeverageType()
        {
            return BeverageType;
        }

        public int GetSugar()
        {
            return Sugar;
        }

        public bool GetMilkOrNoMilk() 
        { 
            return MilkOrNoMilk; 
        }  
    }
}
