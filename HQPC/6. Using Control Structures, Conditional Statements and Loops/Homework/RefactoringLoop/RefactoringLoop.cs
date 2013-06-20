using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringLoop
{
    class RefactoringLoop
    {
        static void LoopForRefactoring()
        {
            int arrayLength = 0;
            int[] array = new int[arrayLength];
            int expectedValue = 0;

            bool expectedValueFound = false;
            
            for (int index = 0; index < 100; index++)
            {
                Console.WriteLine(array[index]);
                if (index % 10 == 0)
                {
                    if (array[index] == expectedValue)
                    {
                        expectedValueFound = true;
                        break;
                    }
                }
            }
            // More code here
            if (expectedValueFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
