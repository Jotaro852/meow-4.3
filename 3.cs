using System;
using System.IO;
class work_4_3
{
    static void Main()
    {
        string file = "numsTask3.txt"; // читаем файл
        string[] fileNumbers = File.ReadAllText(file).Split(','); // разделяем числа по символу
        int[] nums = fileNumbers.Select(int.Parse).ToArray(); // перобразования строк в числа
        int max = nums[0];
        int min = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                Console.WriteLine(min);
                Console.WriteLine(max);
                Console.WriteLine($"Отношение минимального ({min}) к макисмальному ({max}) = {((float)min / (float)max)}"); // вывод
                break;
            }
            else if (nums[i] > max)
            {
                max = nums[i];
            }
            else if (nums[i] < min)
            {
                min = nums[i];
            }
        }
    }
}       