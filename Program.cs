using System.Globalization;
double km, m, cm;

CultureInfo cultura = new CultureInfo("pt-BR");

Console.WriteLine("+---------+");
Console.WriteLine("| Medidas |");
Console.WriteLine("+---------+");

Console.Write("Informe o valor em metros: ");
m = Convert.ToDouble(Console.ReadLine(), cultura!);

cm = m * 100;
km = m / 1000;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("\n----Correspondência----");
Console.ResetColor();

Console.WriteLine($"{cm.ToString("N2", cultura)} cm");
Console.WriteLine($"{m.ToString("N2", cultura)} m");
Console.WriteLine($"{km.ToString("N2", cultura)} km");
