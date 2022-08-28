// Ctrl +K+C для закомментирования кода
// Ctrl +K+U и для раcкомментирования кода

// Виды методов в программировании
// Вид1 - ничего не принимает,ничего не возвращает

void Method1()
{
    Console.WriteLine("Автор ...");
}
// чтобы вызвать метод:
// Method1();

// Вид2 - что-то принимает, ничего не возвращает

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg:"текст сообщения");

void Method21(string msg, int count)
{
int i=0;
while(i<count)
{
    Console.WriteLine(msg);
    i++;
}
}
// Method21(msg:"текст", count: 4);
// или
// Method21(count: 4, msg:"н текст");

// Вид3 - что-то возвращает, ничего не принимает 
// если метод что-то возвращает, мы должны указать тип данных, кот. возвращаются

int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Console.WriteLine(year);

// Вид4 - что-то принимает, что-то возвращает 
// string Method4(int count, string text)
// {
//      int i=0;
//      string result = String.Empty;

//      while(i<count)
//      {
//         result =result + text;
//         i++;
//      }
//      return result;

// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);


// цикл for

// string Method4(int count, string text)
// {
//      string result = String.Empty;
//      for(int i=0; i<count; i++)
//      {
//         result =result + text;
//      }
//      return result;

// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

//вывести таблицу умножения (вложенный цикл)

for(int i = 2; i<=10; i++) // счетчик для числителя
     {
        for(int j = 2; j<=10; j++) // счетчик для знаменателя
        {
            Console.WriteLine($"{i} x {j} = {i * j}");
        }
        Console.WriteLine();
     }
     

