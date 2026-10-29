//начало - 29.10.2026

Console.WriteLine("Hello, World!");
//для вывода информации используется Console.WriteLine()



string name; // определение переменной
name = "Tom"; // присваивание

Console.WriteLine($"Hello, {name}"); 
//Для вывода переменной с текстом можно использовтаь так называемую интерполяцию (знак доллара $) как в примере выше.


string anotherName = "Ben"; // инициализация переменной 
Console.WriteLine($"Hello, {anotherName}");

const int constanta  = 15; // константа неизменна и должна быть только инициализирована
Console.WriteLine($"{constanta} is a constanta");


//                   ТИПЫ ДАННЫХ
//все вещественные числа воспринимаются как double, поэтому нужын суффиксы

float a = 3.14f; //или F
Console.WriteLine($"{a} is float");

decimal b = 1005.17m; //M
Console.WriteLine($"{b} is decimal");

//все целые числа воспринимаются как int, поэтому нужны суффиксы
uint c = 1005u; //U
Console.WriteLine($"{c} is uint");

long d = 12345L; //также есть l, но лучше использоваьть заглавную, чтобы не путать с единицей 
Console.WriteLine($"{d} is long");

ulong e = 12345ul; // UL
Console.WriteLine($"{e} is ulong");


//                  НЕЯВНАЯ ТПИПИЗАЦИЯ
//var нужен когда неизвестен тип данных переменной. По базе числа будут int, вещественные double, а строки string. можно использовать суффиксы
var f = 3.14; //double
Console.WriteLine($"{f} is double");
var newF = 3.14F; //float
Console.WriteLine($"{newF} is float");

/*
var c;
c = 3;
не будет работать, неявную переменную надо сразу инициализировать

также не сработает 
var something = null;
*/

//для считывания ввода юзера используется:

string? userText = Console.ReadLine() ?? "Burmalda"; //всегда оставлять скобки пустыми, он не принимает текст как в пайтон
//? после string значит, что если пользователь ничего не введет, то переменная получит значение null
//?? "Burmalda" значит, что если переменная будет null, то в нее автоматически вставится значение "Burmalda"
Console.WriteLine($"{userText} is a string");

//Console.ReadLine() все считывает как string, поэтому для считывания нужных данных есть методы


Console.Write("Enter your age: "); //Console.Write() не перекидывает на следуюущю строку, что удобно для запроса данных
int age = Convert.ToInt32(Console.ReadLine()); //преобразует к типу int
Console.WriteLine($"Your age is {age}");


Console.Write("Enter your height: ");
double height = Convert.ToDouble(Console.ReadLine()); //преобразует к типу double
Console.WriteLine($"Your height is {height}");

Console.Write("Enter your salary: ");
decimal salary = Convert.ToDecimal(Console.ReadLine()); //преобразует к типу decimal
Console.WriteLine($"Your salary is {salary}");


//                                           ПРЕОБРАЗОВАНИЕ БАЗОВЫХ ТИПОВ ДАННЫХ

/*
byte a = 4;
int b = a + 70p;
     тут получится 74, нормалды
     
НО
byte a = 4;ом
byte b = a + 70p; 
- это ошибка, потому что при любой арифметической операции с типами данных по разрядности меньше или равных int, результату автоматически становится типом int, а он занимает 4 байта.
так как в 1 байт b не влезет 4 байта, то код не выполнится.
*/


//                      СУЖАЮЩИЕ (NARROWING) И РАСШИРЯЮЩИЕ (WIDENING) ПРЕОБРАЗОВАНИЯ






































