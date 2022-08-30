Console.WriteLine("Введите число, которое нужно возвести в степень: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число степени, в которую нужно возвести: ");
int B = int.Parse(Console.ReadLine());
int result = 1;
for ( int i = 0; i < B; i++)
{
    result *= A;
}
Console.WriteLine(result);
