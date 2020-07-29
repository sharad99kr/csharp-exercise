using System;
namespace Exercise {
    public class SelectionSort {
        public static void Main4() {
            int[] arr = { 4, 9, 5, 1, 6, 2, 8, 10, 3 };

            Console.Write("Un sorted array : ");

            foreach (int item in arr) {
                Console.Write(item+" ");
            }

            int min = -1;
            int index = -1;
            for(int i = 0; i < arr.Length; i++) {
                index = i;
                min = arr[i];
                for(int j = i + 1; j < arr.Length; j++) {
                    if (arr[j] < min) {
                        min = arr[j];
                        index = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
            }

            Console.WriteLine(" ");
            Console.Write("sorted array : ");

            foreach (int item in arr) {
                Console.Write(item + " ");
            }
        }
    }
}
