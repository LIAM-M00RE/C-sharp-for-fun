using System;

class GfG
{
    //function to perform binary search
    static bool binarySearch(int[] arr, int left, int right, int target)
    {
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return true;
            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false;
    }
    static bool twoSum(int[] arr, int target)
    {
        Array.Sort(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];

            //use binary search to find the complement
            if (binarySearch(arr, i + 1, arr.Length - 1, complement))
                return true;
        }
        //if no pair is found
        return false;
    }
    static void Main()
    {
        int[] arr = { 0, -1, 2, -3, 1 };
        int target = -2;

        if (twoSum(arr, target))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}