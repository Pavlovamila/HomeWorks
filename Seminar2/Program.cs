 //Задача 1.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
 int CutDigit(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    int result = sot * 10 + ed;
    return result;
}

int randNum = new Random(). Next(100, 1000);
int newNum = CutDigit(randNum);

Console.WriteLine($"New version of{randNum} is {newNum}");

bool IsEven(int number)
{
    if(number % 2 == 0)
        return true;
    else 
        return false;
}

bool result = IsEven(newNum);
Console.WriteLine(result);
*/

//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Write("Input a number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("third number -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> third number not");
}
*/


//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Input a number is day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("(it is day off) -> yes");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("it is not day of the week");
  }
  else Console.WriteLine("(it is not day off) -> no");
}
