Console.WriteLine("Determine o A ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Determine o X");

int x= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Determine o B");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Determine o C");

int c = Convert.ToInt32(Console.ReadLine());

int y;

if (x < a)

{

y = a * x * x + b * x + c;

}

else if (x > a)

{

y = a * x * x + b * x - c;

}

else

{

y=a*x+b;

}

Console.WriteLine("O Y é: " + y); 
