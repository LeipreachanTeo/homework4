int N = new Random().Next(0,10);
int[] array = new int[N];
int summa_last_digit = 0;
int product_last_digit = 1;

for (int i =0; i < array.Length; i++)
{
    while(array[i] == 0)
    {
        int B = new Random().Next(0, 9999999);
        int copy_B = B;
        while(B > 0)
        {
            int last_digit = B % 10;
            summa_last_digit += last_digit;
            product_last_digit *= last_digit;
            B /= 10;
        }
        if(product_last_digit % summa_last_digit == 0)
        {
            array[i] = copy_B;
        }
        else
        {
            array[i] = 0;
        }
    }
Console.WriteLine(array[i]);
}


