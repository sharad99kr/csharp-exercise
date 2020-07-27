using System;

namespace Exercise {
    public class InsertionSort {
        public static void Main3() {
            int[] unsorted = { 14,4,1,8,7,3,9,6,2};
            Console.WriteLine("Un sorted array : ");

            foreach (int item in unsorted) {
                Console.WriteLine(item);
            }
           
            for(int x = 1; x < unsorted.Length; x++) {
                int i = x;
                int j = i-1;
                bool stop = false;
                while (j >= 0 && !stop) {
                   
                    if (unsorted[i] < unsorted[j]) {
                        int temp= unsorted[j];
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

            Console.WriteLine("sorted array : ");

            foreach (int item in unsorted) {
                Console.WriteLine(item);
            }

        }
    }
}
