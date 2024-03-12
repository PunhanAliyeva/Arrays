
#region Task1

//int[] nums = { 4, -9, 1, 5, 4, 5 };

////method 1st

//for (int i = 0; i < nums.Length; i++)
//{
//	bool IsUnique = true;
//	for (int j = 0; j < nums.Length; j++)
//	{
//		if (nums[i] == nums[j] && i != j)
//		{
//			IsUnique = false;
//			break;
//		}
//	}
//	if (IsUnique)
//	{
//		Console.WriteLine(nums[i]);
//	}
//}


////method 2nd

//foreach (int num in nums)
//{
//    int count = 0;
//    foreach (int i in nums)
//    {
//        if (num == i)
//        {
//            count++;
//        }
//    }
//    if (count == 1)
//    {
//        Console.WriteLine(num);
//    }
//}
#endregion


#region Task2

//int[] arr1 = { 2, 5, 1, 9, 23, 12, 98, 34 };
//int[] arr2 = new int[arr1.Length];
//for (int i = 0; i < arr1.Length; i++)
//{
//    arr2[i] = arr1[i];
//    Console.WriteLine(arr2[i]);
//}

#endregion


#region Task3

int[] arr1 = { 4, 1, 1,4,1,1,1,5,2,7,8,1 };
for (int i = 0; i < arr1.Length; i++)
{
    int count = 0;
    bool CheckNum = false;
    for (int j = 0; j < arr1.Length; j++)
    {
        if (arr1[i] == arr1[j])
        {
            if (i < j)
            {
                CheckNum = true;
                break;
            }
            count++;
        }
    };
    if (!CheckNum)
    {
        Console.WriteLine($"{arr1[i]} => {count}");
    }
}
#endregion