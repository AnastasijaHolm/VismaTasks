using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VismaTasks.Framework;
using static VismaTasks.Framework.Document;

namespace VismaTasks
{
    internal class Program
    {
        //Task number 3 and 4
        static void Main(string[] args)
        {
            Print("Document Date: " + MondayOfCurrentWeek().ToString("dd.MM.yyyy."));
            int itemQuantity = Int32.Parse(maxNumber) / 3;
            EnterDocumentData(itemQuantity);
            Print("Max Number: " + maxNumber);
            Print("Row count: " + itemQuantity.ToString());
        }
    }
}
