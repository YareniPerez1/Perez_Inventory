using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perez_Inventory
{
    internal class Shipper
    {
       decimal CCrackers = 0;
       decimal CBaseball = 0;
       decimal CLawnM = 0;
       decimal CBicycles = 0;
       decimal tencap = 0;
       decimal AddedAmounts = 0;
        private decimal Bicycle;
        private decimal LawnMower;
        private decimal Cracker;
        private decimal Baseballg;




        IShippable[] shipped = new IShippable[10];

        public decimal AddedShippedAmounts (decimal choice)
        {
            for (int i = 0; i < 10; i++)
            {
                if (choice == 1)
                {
                    shipped[i] = new Bicycles();
                    CBicycles++;
                    tencap++;
                    Bicycle = shipped[i].shipcost;
                    return (Bicycle);

                }

                if (choice == 2)
                {
                    shipped[i] = new LawnMower();
                    CLawnM++;
                    tencap++;
                    LawnMower = shipped[i].shipcost;
                    return (LawnMower);
                }
                if (choice == 3)
                {
                    shipped[i] = new BaseballGloves();
                    CBaseball++;
                    tencap++;
                    Baseballg= shipped[i].shipcost;
                    return (Baseballg);

                }

                if (choice == 4)
                {
                    shipped[i] = new Crackers();
                    CCrackers++;
                    tencap++;
                    Cracker = shipped[i].shipcost;
                    return (Cracker);

                }
                
                if (choice == 6)
                {
                    AddedAmounts = Bicycle * CBicycles + LawnMower * CLawnM + Cracker * CCrackers + Baseballg * CBaseball;
                    return (AddedAmounts);
                }

               
            }

            return AddedAmounts;

        }

        public decimal AddedAmount
        {


            get { return AddedAmounts; }


        }

        public string Add(IShippable shipped)
        {
            if (tencap >= 10)
            {
               
               
                
                return "You have now reached the max amount of items to compute charges";
            }


            if (shipped.Product == "Bicycles")
            {
                
                return " 1 Bicycle has been added";
                
            }

            if (shipped.Product == "Lawn Mowers")
            {
                
                return " 1 Lawn Mower has been added";
            }
            if (shipped.Product == "Baseball Gloves")
            {
              
                return "1 Baseball Glove has been added";
            }


            if (shipped.Product == "Crackers")
            {
              
                return " 1 Crackers has been added";
            }

            


            return "";
        }

        public string list()
        {


            return ("Shipment manifest: ")+
                ($"{CBicycles} Bicycle{(CBicycles == 1 ? "" : "s")}, ") +
                   ( $"{CLawnM} Lawn Mower{(CLawnM == 1 ? "" : "s")}, ") +
                   ( $"{CBaseball} Baseball Glove{(CBaseball == 1 ? "" : "s")}, ") +
                   ( CCrackers + " Crackers");




        }

   







}
}
