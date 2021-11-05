// Console.Write("a = ");
// Console.Write(a);
// Console.Write("b = ");
// Console.WriteLine(b);
//Console.Write("Hello");

// Console.WriteLine("a= " + a + "\nb= " + b);  //конкатинация
// int a = 123;
// int b = 321;
// Console.WriteLine($"Было   a = {a} b = {b}"); // a = 123, b = 321

// int c;
// c = a;
// a = b;
// b = c;

// a = a+b;
// b = a-b;
// a=a-b;

// Console.WriteLine($"Стало  a = {a} b = {b}"); // a = 321, b = 123

// int a = 5;
// int b = 2;
// int res = a & b;
// Console.WriteLine($"res = {res}");

// if(условие)
// {
// // условие истина
// }
// else()
// {
// // условие ложно
// }

// int a = new Random().Next(1,100);
// int b = new Random().Next(1,100);
// Console.WriteLine($"First number = {a}");
// Console.WriteLine($"Second number = {b}");

// if(a>b)
// {
// Console.WriteLine($"Max is {a}");
// }
// else
// {
//     Console.WriteLine($"Max is {b}");
// }


// int current = 1;
// while (current <=10)
// {
//      double result = Math.Pow(current, 2);
//      Console.WriteLine($"{current,3}^2 = {result,-4}");
//      current++;
// }


int number = 2;
int a = 100;
int b = 500;
int end = 10000;
while (number <= end)
{
    bool flag = number % a ==0 && number % b == 0;
     if (flag)
     {
         Console.WriteLine($"{number} - {flag}");
     }
     number++;
}


// void DrawRectanglle(int posX, int posY, int width, int height)
// {
//     int row = 0;
//     while (row < height)
//     {
//         Console.SetCursorPosition(posX, posY + row);
//         int count = 0;
//         while (count < width)
//         {
//             Console.Write("+");
//             count++;
//         }
//         row++;
//     }
// }
// DrawRectanglle(5, 10, 9, 4);
// int i = 0;

// while (i<10)
// {
//      i += 2;
//      Console.WriteLine(i);
// }