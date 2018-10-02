using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //param   (StockList)listToMerge : second list to be merged 
    //summary      : merge two different list into a single result list
    //return       : merged list
    //return type  : StockList
    public StockList MergeList(StockList listToMerge)
    {
      StockList resultList = new StockList();
            // write your implementation here
            
            // Check for empty list
            if (this.IsEmpty())
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                //Assign head pointer to the first stocklist
                StockNode current_1 = this.head;
                while ( current_1 != null)
                {
                    resultList.AddStock(current_1.StockHolding);
                    current_1 = current_1.Next;
                }
            }
                if (this.IsEmpty())
                {
                    Console.WriteLine("List is empty!");
                }
                else
                //head of the mergelist is assigned to pointer of the second stocklist
                   {
                    StockNode current_2 = listToMerge.head;
                    while (current_2 != null)
                    {
                        resultList.AddStock(current_2.StockHolding);
                        current_2 = current_2.Next;
                    }

                    }
     
                return resultList;
    }

    //param        : NA
    //summary      : finds the stock with most number of holdings
    //return       : stock with most shares
    //return type  : Stock
    public Stock MostShares()
    {
      Stock mostShareStock = null;
     // write your implementation here
     StockNode current = this.head;
       if (this.IsEmpty())
       {
         Console.WriteLine("List is empty!");
       }
       mostShareStock = current.StockHolding;
       current = current.Next;
       while (current!=null)
        {
            if(current.StockHolding.Holdings>mostShareStock.Holdings)
                {
                    mostShareStock = current.StockHolding;
                }
                current = current.Next;
        }

       return mostShareStock;
    }

    //param        : NA
    //summary      : finds the number of nodes present in the list
    //return       : length of list
    //return type  : int
    public int Length()
    {
      int length = 0;
            // write your implementation here
            if (this.IsEmpty())
            {
                Console.WriteLine("List is empty!");
            }
            StockNode current = this.head;
            while (current != null)
            {
                length++;
                current = current.Next;
            }
            return length;
    }
  }
}