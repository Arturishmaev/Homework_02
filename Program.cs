//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//   и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число: ");
int Numbers = Convert.ToInt32(Console.ReadLine());
string anyNumber = Convert.ToString(Numbers);
if (anyNumber.Length > 2)
{
    Console.WriteLine("вторая цифра :  " + anyNumber[1]);
}


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
            что третьей цифры нет.*/

Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра  " + anyNumber[2]);
}
else {
  Console.WriteLine(" третьей цифры нет");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

string[] weekDays = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
System.Console.WriteLine("Введите день недели : ");
for ( int i = 0; i < weekDays.Length; i++)
{
    System.Console.WriteLine(i+1 + " - " + weekDays[i] + ", ");
          }
          int dayweek = Convert.ToInt32(Console.ReadLine());
          if(dayweek ==6 || dayweek == 7)
          {
            System.Console.WriteLine("да, " + dayweek + " - выходной день .");
          }
          else
          {
            System.Console.WriteLine("нет, " + dayweek + " - будний день ");
          }
          