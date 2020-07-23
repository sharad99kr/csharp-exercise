﻿using System;

namespace Exercise {
    public class InsertionSort {
        public static void Main() {
            int[] unsorted = { 14,4,1,8,7,3,9,6,2};
            Console.WriteLine("Un sorted array : ");

            foreach (int item in unsorted) {
                Console.WriteLine(item);
            }
            int mainCount = 0;
            for(int x = 1; x < unsorted.Length; x++) {
                int i = x;
                int j = i-1;
                bool stop = false;
                while (j >= 0 && !stop) {
                    mainCount++;
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

            Console.WriteLine("sorted array : "+ mainCount);

            foreach (int item in unsorted) {
                Console.WriteLine(item);
            }

        }
    }
}