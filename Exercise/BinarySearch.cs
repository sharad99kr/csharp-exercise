using System;
namespace Exercise {
    public class BinarySearch {
        public static void Main5() {
            int[] arr = { 4, 9, 5, 1, 6, 2, 8, 10, 3, 12, 15, 17, 19, 11, 13, 16, 14 };
            Console.Write("Un sorted array : ");

            foreach (int item in arr) {
                Console.Write(item + " ");
            }
            BinarySearch bs = new BinarySearch();
            bs.SortArray(arr);

            Console.WriteLine("");
            Console.Write("sorted array : ");

            foreach (int item in arr) {
                Console.Write(item + " ");
            }

            int firstIndex = 0;
            int lastIndex = arr.Length - 1;
            int key = 6;
            bool found = false;

            while (!found) {
                Console.WriteLine("");
                Console.WriteLine("first index : " + firstIndex);
                Console.WriteLine("last index : " + lastIndex);
                
                int midIndex = firstIndex + ( lastIndex- firstIndex) / 2;
                Console.WriteLine("mid index : " + midIndex);
                if (arr[midIndex] == key) {

                    found = true;
                    Console.WriteLine("");
                    Console.Write("element found at index : " + midIndex);

                }
                else if ( key < arr[midIndex]) {

                    lastIndex = midIndex - 1;
                }
                else if( key > arr[midIndex]) {

                    firstIndex = midIndex + 1;
                }
                
                
            }
        }

        void SortArray(int [] unsorted) {
            //insertion sort
            for (int x = 1; x < unsorted.Length; x++) {
                int i = x;
                int j = i - 1;
                bool stop = false;
                while (j >= 0 && !stop) {

                    if (unsorted[i] < unsorted[j]) {
                        int temp = unsorted[j];
                        unsorted[j] = unsorted[i];
                        unsorted[i] = temp;
                        i = j;
                    }
                    else {
                        stop = true;
                    }
                    j--;
                }
            }

            
        }
    }
}

