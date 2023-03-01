
double x1;
double x2;
Console.WriteLine("введите кофеецент a (не равный 0)");
double a = Convert.ToDouble(Console.ReadLine());
if (a == 0)
{ Console.WriteLine("сказал же не 0!"); }
else
{ Console.WriteLine("введите кофеецент b ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("введите кофеецент c");
    double c = Convert.ToDouble(Console.ReadLine());
    double x0 = -b / (2 * a);
    double y0 = a * Math.Pow(x0, 2) + b * x0 + c;
    double D = Math.Pow(b, 2) - 4 * a * c;
    if (D <= 0) Console.WriteLine(a > 0 ? $"функиция всегда положетельна" : $"функиция всегда отрицательна");
    else
    {x1 = (-b + Math.Pow(D, 0.5)) / 2 * a;
    x2 = (-b - Math.Pow(D, 0.5)) / 2 * a;
    Console.WriteLine(a > 0 ? $"функция положительна при (-бесконечности,{x1})({x2} бесконечности+) функция отрицательна при ({x1},{x2})" : $"функция отрицательна при (-бесконечности,{x1})({x2} бесконечности+) функция положительна при ({x1},{x2})");}
    Console.WriteLine($"кординаты вершины парабалы ({x0};{y0})");
    Console.WriteLine(a > 0 ? $"направлинна вверх" : $"направлинна ввниз");
    Console.WriteLine(a > 0 ? $"y минимальное = {y0}" : $"y максимальное = {y0}");
    Console.WriteLine(a > 0 ? $"функция убывает  (-бесконечности , {x0}) функция возрастает  ({x0} , бесконечности+) " : $"функция убывает ({x0} , -бесконечности) функция возрастает  (бесконечности+ , {x0})");
}