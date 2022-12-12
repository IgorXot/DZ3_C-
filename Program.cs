//---------------------------------DZ3-------------------------------------------------------

//1. Напишите программу, которая принимает на вход 
//   пятизначное число и проверяет, является ли оно палиндромом.

bool isPalindrom(int num)
{
    int n = num;
    int rev = 0;

    while(n > 0)
        {              
        int r = n % 10;
        rev = rev * 10 + r;
        n = n / 10;
        }   
        if(num == rev)
        {
            return true;
        }
        else 
        {
            return false;    
        }
       
}        
Console.Write("Enter а number: ");
int Number = Convert.ToInt32(Console.ReadLine());
bool reply = isPalindrom(Number);
Console.WriteLine(reply);


// 2. Напишите программу, которая принимает на вход координаты двух точек
//    и находит расстояние между ними в 3D пространстве.

/*
double FindDistance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double distance = Math.Sqrt(Math.Pow(xA-xB,2) + Math.Pow(yA-yB,2) + Math.Pow(zA-zB,2));
    return distance;
}
Console.Write("Input first x: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input first y: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input first z: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second x: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second y: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second z: ");
double zB = Convert.ToDouble(Console.ReadLine());

double distance = FindDistance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Distance = {distance}");
*/

// Задача 3. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

/*
void cube(int n)
{
    int result = 1;
    while (result <= n)
    {
    Console.Write(Math.Pow(result,3)+ " ");
    result++; 
    }
}
Console.Write($"Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

cube(n);
*/
