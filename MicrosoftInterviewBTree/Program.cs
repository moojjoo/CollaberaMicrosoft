using System;
using System.Collections.Generic;

namespace MicrosoftInterviewBTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int nodeValue = 1;

            printBTree(nodeValue);
        }

        private string printBTree(int nodeValue)
        {
            Queue<int> bQueue = new Queue<int>();
            int currentNodeLevel = 1;
            int rootLevel = currentNodeLevel;       


            bQueue.Enqueue(nodeValue);

            



            return bTreeString;
        }
    }
}