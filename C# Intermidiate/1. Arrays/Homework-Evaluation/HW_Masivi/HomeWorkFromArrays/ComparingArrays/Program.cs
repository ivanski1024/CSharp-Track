using System;

namespace ComparingArrays
{
    class ComparingArrays
    {
        static void Main(string[] args)
        {
            
            int[] array1;
            int[] array2;
            int sizeOfArray1=0, sizeOfArray2=0, counter=0;
            
            Console.WriteLine("Enter the size of first array");
            sizeOfArray1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of second array");
            sizeOfArray2 = Int32.Parse(Console.ReadLine());
            
            array1 = new int[sizeOfArray1];
            array2 = new int[sizeOfArray2];
            
            for(int i=0;i<=sizeOfArray1-1;i++)
            {
                Console.WriteLine("Enter digits for first array:");
                array1[i]=Int32.Parse(Console.ReadLine());
            }
            for(int j=0;j<=sizeOfArray2-1;j++)
            {
                Console.WriteLine("Enter digits for second array:");
                array2[j]=Int32.Parse(Console.ReadLine());
            }

            if (sizeOfArray1 == sizeOfArray2) 
            {
                Console.WriteLine("Two arrays are with equal sizes");
                
                for (int i = 0; i < array1.Length - 1; i++)
                {
                    if (array1[i] == array2[i])
                    {
                        counter++;
                    }
                }
                if ((counter == 0) || (counter < array2.Length-1 || counter < array1.Length-1))
                {

                Console.WriteLine("There are no equal elements so arrays are not equal "+counter);

                }
                else if (counter == array1.Length || counter == array2.Length)
                {
                
                    Console.WriteLine("Two arrays are with equal elements and equal length so they are equal");
                
                }
            }else
            {
                
                Console.WriteLine("Two arrays are not with equal sizes so two arrays are not equal");
                
            }
                
            }
        }
    }

