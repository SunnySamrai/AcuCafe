using System;
using System.Collections.Generic;
using AcuCafe.Constants;

namespace AcuCafe
{
    public class AcuCafe
    {
        public Drink OrderDrink(Enumerations.DrinkType type, bool hasMilk, bool hasSugar, bool isChocolatey = false)
        {
            Drink drink;
            switch (type)
            {
                case Enumerations.DrinkType.Expresso:
                    drink = new Expresso
                    {
                        HasMilk = hasMilk,
                        HasSugar = hasSugar,
                        ChocolateTopping = isChocolatey
                    };
                    break;
                case Enumerations.DrinkType.IceTea:
                    drink = new IceTea
                    {
                        HasMilk = hasMilk,
                        HasSugar = hasSugar,
                    };
                    break;
                case Enumerations.DrinkType.HotTea:
                    drink = new HotTea
                    {
                        HasMilk = hasMilk,
                        HasSugar = hasSugar,
                    };
                    break;
                default:
                    throw new ApplicationException("Unable to prepare drink.  Unrecognised drink type");
            }
            
            drink.Prepare(drink);;
            return drink;
        }
    }
}