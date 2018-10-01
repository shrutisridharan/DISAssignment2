using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    public partial class StockList
    {
        //param        : NA
        //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
        //return       : total value
        //return type  : decimal
        public decimal Value()
        {
            int var = 0;
            decimal value = 0.0m;

            // write your implementation here

            return value;
        }

        //param  (StockList) listToCompare     : StockList which has to comared for similarity index
        //summary      : finds the similar number of nodes between two lists
        //return       : similarty index
        //return type  : int
        public int Similarity(StockList listToCompare)
        {
            int similarityIndex = 0;

            StockNode current_2 = null;
            if (this.IsEmpty())
            {

                return 0;
            }
            if (listToCompare.IsEmpty())
            {
                return 0;
            }
            StockNode current_1 = head; // head pointer is assigned to the first stocklist
            while (current_1 != null) // traversing through the list until the pointer is pointing to empty location
            {
                current_2 = listToCompare.head; //head of the comparable list is assigned to current 2
                while (current_2 != null)
                {
                    if (current_1.StockHolding.Name == current_2.StockHolding.Name) // checking if the value both ponters are pointing to are the same.
                    {
                        similarityIndex = similarityIndex + 1; //incrementing the similarity index every ime the stockholding name is the same
                    }
                    current_2 = current_2.Next; // moving to th epointer to next stock in stocklist until stocklist is empty
                }
                current_1 = current_1.Next;
            }

                return similarityIndex; // count of similar nodes
            
            
        }


        //param        : NA
        //summary      : Print all the nodes present in the list
        //return       : NA
        //return type  : NA
        public void Print()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("List is empty");

            }
            else
            {
                StockNode current = head;
                while (current != null)
                {
                    Console.WriteLine(current.StockHolding);
                    current = current.Next;
                }
            }

        }
    }
}