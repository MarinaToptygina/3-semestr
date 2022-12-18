int[] mas = new int[12] { 5, 1, 24, 4, 1, 41, 2, 32, 4, 4, 1, 333 };
int max = 0, max_i = 0;

for (int i = 0; i < mas.Length; i++)
{
    for (int j = 0; j < mas.Length; j++)
    {
       
        if (((mas[j] - mas[i]) > max) && (mas[i] < mas[j]))
        {
            max = mas[j] - mas[i];
            max_i = mas[i];
        }
    }
}
int max_j = max_i + max;

int[] output_nums = new int[2] { max_i, max_j };

for (int i = 0; i < output_nums.Length; i++)
    Console.WriteLine(output_nums[i]);