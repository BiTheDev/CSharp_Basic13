using System;
using System.Collections.Generic;
namespace Basic13
{
    class Program
    {

        public static void Main(string[] args)
        {
            // Print 1- 255
            // for (int i = 0; i < 256; i++)
            // {
            //     System.Console.WriteLine(i);
            // }

            // Print odd numbers between 1 - 255
            // for (int i = 1; i < 256; i+=2)
            // {
            //     System.Console.WriteLine(i);
            // }

            // // Print Sum
            // int sum = 0;
            // for (int i = 0; i < 256; i++)
            // {
            //     System.Console.WriteLine("New number: "i + " Sum:" + (sum += i));
            // }

            //iterating through an Array
            // int [] x = {1,3,5,7,9,13};
            // IteratingArray(x);

            //Find Max
            // int [] arr  = {-3,-5,-7};
            // System.Console.WriteLine(FindMax(arr)); 

            //Get Average
            // int [] arr = {2,10,3};
            // System.Console.WriteLine(GetAverage(arr));

            //Array with Odd Numbers
            // OddArray();

            //Greater Than Y
            // int[] arr = {1,3,5,7};
            // System.Console.WriteLine(GreaterThanY(arr, 3)); 

            // Square the Values
            // int [] arr = {1,5,10,-2};
            // Square(arr);

            // Min Max Average
            // int[] arr = {1,5,10,-2};
            // MinMaxAvg(arr);
            
            //Elimainate Negative Numbers
            // int[] x = {1,5,10,-2};
            // foreach (var item in RemoveNegative(x))
            // {
            //     System.Console.Write(item);
            // }
            // System.Console.WriteLine();

            //Shift value in the array
            // int[] arr = {1,5,10,7,-2};
            // foreach (var item in ShiftValue(arr))
            // {
            //     System.Console.Write(item + " ");
            // }

            //Number to String
            // object[] arr= {-1,-3,2};
            // foreach (var item in NumberToString(arr))
            // {
            //     System.Console.Write(item + " ");
            // }
            // System.Console.WriteLine();
        }


        // Iterating through an Array
        public static void IteratingArray(int[] arr){
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write(arr[i] + " ");
            }
            System.Console.WriteLine();
        }

        //Find Max
        public static int FindMax(int[] arr){
            int Max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if ( arr[i] > Max)
                {
                    Max = arr[i];
                }
            }
            return Max;
        }
        
        //Find Min
        public static void FindMin(int[] arr){
            int Min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if( Min > arr[i]){
                    Min = arr[i];
                }
            }
            System.Console.WriteLine(Min);
        }

        //get Average
        public static double GetAverage(int[] arr){
            int sum = 0;
            double average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            
            average = (sum / arr.Length);
            return average;
        }
        
        // Odd Array
        public static void OddArray(){
            int[] arr = new int[256];
            for (int i = 0; i <arr.Length; i++)
            {
                if(i % 2 == 1){
                    arr[i] = i;
                System.Console.WriteLine(arr[i]);
                }
            } 
        }
        
        //Greater than Y
        public static int GreaterThanY(int[] arr, int y){
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > y){
                    count ++;
                }
            }
            return count;
        }

        // Square the Values
        public static void Square(int[] arr){
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= arr[i] ;
                System.Console.Write(arr[i] + " ");
            }
            System.Console.WriteLine();
        }
        public static int[] RemoveNegative(int[] arr){
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0){
                    arr[i] = 0;
                }
            
            }
            return arr;
        }

        // Min Max Average
        public static void MinMaxAvg(int[] arr){
            int Max = arr[0];
            int Min = arr[0];
            int sum = 0;
            double avg = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
                if(arr[i] > Max){
                    Max = arr[i];
                }else if( Min > arr[i]){
                    Min = arr[i];
                }
                avg = sum / arr.Length;
            }
            System.Console.WriteLine("Max : " + Max);
            System.Console.WriteLine("Min : " + Min);
            System.Console.WriteLine("Average : " + avg);
        }

        //Shift value in the array
        public static int[] ShiftValue(int [] arr){
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = arr[i+1];
            }
            arr[arr.Length-1] = 0;

            return arr;
        }

        public static object[] NumberToString(object[] arr){
            for (int i = 0; i < arr.Length; i++)
            {
                if((int)arr[i] < 0){
                    arr[i] = "Dojo";
                }
            }
            return arr;
        }
    }
        
}




// Sigma(5);
// public static void Sigma(int val){
//             int sum = 0;
//             for (int i = val; i >=0; i--)
//             {
//                 sum += i;
//                 if( i == 0){
//                     System.Console.Write(i + " = ");
//                 }else{
//                     System.Console.Write(i + " + ");
//                 }
//             }
//             System.Console.WriteLine(sum);
//         }


// object[] arr = {1,-5,2,-5,2};
//             System.Console.WriteLine("[ " );
//             foreach (var item in NegativeToDojo(arr))
//             {
//                 System.Console.WriteLine(item + " " ); 
//             }
//             System.Console.WriteLine("]" );

// Negative to Dojo
        // public static object[] NegativeToDojo(object[] arr){
        //     for (int i = 0; i < arr.Length; i++)
        //     {
        //         if((int)arr[i] < 0){
        //             arr[i] = "Dojo";
        //         }
        //     }
        //     return arr;
        // }