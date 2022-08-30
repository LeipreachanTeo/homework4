Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int copy_number = number;
int result = 0;
try
{
   while(copy_number > 0)
   {
      int last_digit = copy_number % 10;
      if(number % last_digit == 0)
      {
         result += last_digit;
      } 
      copy_number /= 10;
   }
}
catch
{}
Console.WriteLine(result);
