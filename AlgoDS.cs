namespace AlgoDS.DataStructures
{

    public class LinkedList { }
    public class Stack { }
    public class Queue { }
    public class HashTable { }

    public class LinkedList<T> { }
    public class Stack<T> { }
    public class Queue<T> { }
    public class HashTable<K, V> { }


}

namespace AlgoDS.Sorting
{
    public class QuickSort { }
    public class QuickSort<T> { }

}

namespace AlgoDS.Searching
{
    public class LinearSearch {
        public static int IntLinearSearch(int[] arr, int key) {
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == key) return i;
                }
            return -1;
        }
     }
    public class BinarySearch { 
        public static int IntBinarySearch(int[] arr, int key) {
            int left = 0, right = arr.Length - 1;
            while (left <= right) {
                int mid = left + (right - left) / 2;
                // Found the key, return its position
                if (arr[mid] == key) return mid;
                // If the middle element is less than the key, search in the right hal
                if (arr[mid] < key) left = mid + 1;
                else right = mid - 1; // Otherwise, search in the left half
            }
            return -1; // negative index signals not found
        }


    }
    public class LinearSearch<T> {
        public static int Search(T[] arr, T key) {
            for (int i = 0; i < arr.Length; i++) {
                if (Comparison<T>.Equals(arr[i], key)) return i;
                }
            return -1;
        }

     }
    public class BinarySearch<T> where T : IComparable<T> {
        public static int Search(T[] arr, T key) {
            int left = 0, right = arr.Length - 1;
            while (left <= right) {
                int mid = left + (right - left) / 2;
                // Found the key, return its position
                if (Comparison<T>.Equals(arr[mid], key)) return mid;
                // If the middle element is less than the key, search in the right hal
                if ((key.CompareTo(arr[mid])) > 0) left = mid + 1;
                else right = mid - 1; // Otherwise, search in the left half
            }
            return -1; // negative index signals not found
        }
    }
}