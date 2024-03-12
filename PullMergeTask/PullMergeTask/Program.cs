#region Task1
//int[] nums = { 4, 2, 0, 13, 67, 48, 60, 3, 7,9 };
//int count = 0;
//foreach (int num in nums)
//{
//    if (num % 2 == 1)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
#endregion


#region Task2
//int[] arr = { 4, 2, -10, 5, 12, 56, 1, 0, 43 };
//int minNum = arr[0];
//int maxNum = arr[0];
//int sum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < minNum)
//    {
//        minNum = arr[i];
//    }
//    if (arr[i] > maxNum)
//    {
//        maxNum = arr[i];
//    }
//}
//sum = minNum + maxNum;
//Console.WriteLine($"{minNum}+{maxNum}={sum}");
#endregion


#region Task3
//int[] arr = { 6, 18, 2, 79, 24, 12, 9, 3 };
//int minNum = arr[0];
//int maxNum = arr[0];
//int difference = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < minNum)
//    {
//        minNum = arr[i];
//    }
//    if (arr[i] > maxNum)
//    {
//        maxNum = arr[i];
//    }
//}
//difference = maxNum - minNum;
//Console.WriteLine($"{maxNum}-{minNum}={difference}");
#endregion


#region Task4
//int[] nums1 = { 3, 2, 0, -6, 13, 9, 5 };
//int firstNum = nums1[0];
//for (int i = 0; i < nums1.Length; i++)
//{
//    for (int j = i + 1; j < nums1.Length; j++)
//    {
//        if (nums1[i] > nums1[j])
//        {
//            firstNum = nums1[i];
//            nums1[i] = nums1[j];
//            nums1[j] = firstNum;
//        }
//    }
//}
//foreach (int num in nums1)
//{
//    Console.WriteLine(num);
//}
#endregion


#region Task5
//int[] nums = { 3, 9, 10,23,12,45,90 };
//int sumOdd = 0;
//int sumEven = 0;
//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 2 == 0)
//    {
//        sumEven += nums[i];
//    }
//    else
//    {
//        sumOdd += nums[i];
//    }
//}
//Console.WriteLine($"Sum of odd numbers:{sumOdd}");
//Console.WriteLine($"Sum of even numbers:{sumEven}");
#endregion



#region Practice
//int[] nums = { -9, 2, 7, 13, 5, 22, 10 };
//int sum = 0;
//for (int i = 0; i < nums.Length; i++)
//{
//    sum+= nums[i];
//}
//Console.WriteLine($"Sum:{sum}");
//Console.WriteLine($"Mean:{sum/nums.Length}");



Console.WriteLine("Noqteleri daxil edek");
Console.WriteLine("x1-i daxil edin:");
int x1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1-i daxil edin:");
int y1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("x2-ni daxil edin:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y2-ni daxil edin:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("x3-u daxil edin:");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y3-u daxil edin:");
int y3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Duz xettin qurulmasinin formuluna baxaq:");
Console.WriteLine("(y2-y1)/(x2-x1)=(y3-y2)/(x3-x2)=(y3 - y2)/(x3 - x2)=(y3-y1)/(x3-x1)");
if ((y2-y1)/(x2-x1)==(y3-y2)/(x3-x2) && (y3 - y2)/(x3 - x2)==(y3-y1)/(x3-x1))
{
    Console.WriteLine("Hamisi eyni duz xett uzerindedir..");
}
else
{
    Console.WriteLine("Eyni duz xett uzerinde deyiller..");
}

#endregion


