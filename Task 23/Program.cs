/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/



// Console.WriteLine("Введите число N больше 1: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cube)
// {
//     int counter = 0;
//     int length = cube.Length;
//     while (counter < length)
//     {
//         cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//         counter++;
//     }
// }

// void PrintArry(int[] coll)
// {
//     int count = coll.Length;
//     int index = 1;
//     while (index < count)
//     {
//         Console.Write(coll[index] + " ");
//         index++;
//     }
//     Console.WriteLine("");
// }

// int[] arry = new int[cube + 1];
// Cube(arry);
// PrintArry(arry);

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

string LineNum(int numN, int p)
{
    string outLine = "1";
    for (int i = 2; i <= numN; i++)
    {
        outLine = outLine + " " + Math.Pow(i, p);
    }
    return outLine;
}

int numN = ReadData("Введите число N: ");

string lineTop = LineNum(numN,1);
string lineDown = LineNum(numN,3);

PrintData("",lineTop);
PrintData("",lineDown);