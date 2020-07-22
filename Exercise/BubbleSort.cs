using System;

namespace Exercise {
    class MainClass {
        public static void Main(string[] args) {
            
            int[] unsortedArray = { 3, 2, 1, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Un sorted array : ");

            foreach (int item in unsortedArray) {
                Console.WriteLine(item);
            }
            bool isSorted = false;
            while (!isSorted) {
                isSorted = true;
                for (int i=0;i< unsortedArray.Length-1; i++) {
                    if(unsortedArray[i]> unsortedArray[i + 1]) {
                        int temp = unsortedArray[i];
                        unsortedArray[i] = unsortedArray[i + 1];
                        unsortedArray[i + 1] = temp;
                        isSorted = false;
                    }
                }
            }

            Console.WriteLine(" sorted array : ");

            foreach (int item in unsortedArray) {
                Console.WriteLine(item);
            }

        }
    }
}
