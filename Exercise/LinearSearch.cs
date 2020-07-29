using System;
namespace Exercise {
    public class LinearSearch {
        public static void Main() {
            int[] arr = { 4, 9, 5, 1, 6, 2, 8, 10, 3, 12, 15, 17, 19, 11, 13, 16, 14 };
            Console.Write("Un sorted array : ");

            int key = 6;
            foreach (int item in arr) {
                Console.Write(item + " ");
            }
            int index = 0;
            foreach (int item in arr) {
                
                if (key == item) {
                    Console.Write("item found at index : "+index);
                    break;
                }
                index++;
            }

        }
    }
}
