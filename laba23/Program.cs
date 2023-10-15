Console.WriteLine("Введите вес");
double m=double.Parse(Console.ReadLine());
Console.WriteLine("Введите рост");
double h=double.Parse(Console.ReadLine());
if (h - 100 > m) Console.WriteLine("Надо похудеть");
else if (h - 100 < m) Console.WriteLine("Надо поправится");
else(h-100==m) Console.WriteLine("Вы идеальны");