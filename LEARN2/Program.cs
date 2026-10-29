//начало - 29.10.2026
//коснпект написан с пониманием основ Python




//29.10.2026
/*                 ВЫВОД
для вывода информации используется Console.WriteLine()
*/
Console.WriteLine("Hello, World!");

/*                        ПЕРЕМЕННЫЕ И КОНСТАНТЫ
*/
string boy; // определение переменной
boy = "Tom"; // присваивание

Console.WriteLine($"Hello, {boy}"); 
//Для вывода переменной с текстом можно использовтаь так называемую интерполяцию (знак доллара $) как в примере выше.


string anotherBoy = "Ben"; // инициализация переменной 
Console.WriteLine($"Hello, {anotherBoy}");

const int constanta = 15; // константа неизменна и должна быть только инициализирована
Console.WriteLine($"{constanta} is a constanta");


/*                  ТИПЫ ДАННЫХ
все вещественные числа воспринимаются как double, поэтому нужын суффиксы
*/

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


/*                НЕЯВНАЯ ТПИПИЗАЦИЯ
var нужен когда неизвестен тип данных переменной. По базе числа будут int, вещественные double, а строки string. можно использовать суффиксы
*/
var f = 3.14; //double
Console.WriteLine($"{f} is double");
var newF = 3.14F; //float
Console.WriteLine($"{newF} is float");

/*ОШИБКИ
var c;
c = 3;
не будет работать, неявную переменную надо сразу инициализировать

также не сработает 
var something = null;
*/

//для считывания ввода юзера используется:
string /*?*/ userText = Console.ReadLine() ?? "Burmalda"; //всегда оставлять скобки пустыми, он не принимает текст как в пайтон
//? после string значит, что если пользователь ничего не введет, то переменная получит значение null
//?? "Burmalda" значит, что если переменная будет null, то в нее автоматически вставится значение "Burmalda"
Console.WriteLine($"{userText} is a string");


//Console.ReadLine() все считывает как string, поэтому для считывания нужных данных есть методы:

Console.Write("Enter your age: "); //Console.Write() не перекидывает на следуюущю строку, что удобно для запроса данных
int age = Convert.ToInt32(Console.ReadLine()); //преобразует к типу int
Console.WriteLine($"Your age is {age}");

Console.Write("Enter your height: ");
double height = Convert.ToDouble(Console.ReadLine()); //преобразует к типу double
Console.WriteLine($"Your height is {height}");

Console.Write("Enter your salary: ");
decimal salary = Convert.ToDecimal(Console.ReadLine()); //преобразует к типу decimal
Console.WriteLine($"Your salary is {salary}");


/*                                          ПРЕОБРАЗОВАНИЕ БАЗОВЫХ ТИПОВ ДАННЫХ


byte a = 4;
int b = a + 70;
- тут получится 74, нормалды
     
НО
byte a = 4;
byte b = a + 70; 
- это ошибка, потому что при любой арифметической операции с типами данных по разрядности меньше или равных int, результату автоматически становится типом int, а он занимает 4 байта.
так как в 1 байт b не влезет 4 байта, то код не выполнится.



                     РАСШИРЯЮЩИЕ (WIDENING) И СУЖАЮЩИЕ (NARROWING) ПРЕОБРАЗОВАНИЯ


расширяющие преобразования расширяют размер объекта в памяти:
byte a = 4; 
- здесь тип переменная a типа byte занимает 1 байт/ 8 бит
ushort b = a;
- здесь мы переменную a с одного байта/8 бит (тип byte) расширяем до двух байт/16 бит (тип ushort)


сужающие преобразования наоборот сокращают занимаемую память:
ushort a = 4;
byte b = (byte) a;

в сужении Я написал тип данных в скобках повторно, это называется явное преобразование (explicit conversion). это сделано, чтобы кодер точно знал что делает и данные не потерялись при сужении

в расширении происходит неявное преобразование (implicit conversion) без скобок, так как при расширении данные не потеряются 

от меньшего к БОЛЬШЕМУ - неявно
от БОЛЬШЕГО к меньшему - явно, самому через скобки
*/


//                                  IF/ELSE И ТЕРНАРНАЯ ОПЕРАЦИЯ

//if/else

string name = "Alex";

if (name == "Tom")
    Console.WriteLine("Your name is Tom");

else if  (name == "Ben")
    Console.WriteLine("Your name is Ben");

else if   (name == "Dundrik")
    Console.WriteLine("Your name is Dundrik");

else
    Console.WriteLine("Unknown name");


/*тернарная операция
(тернарная операция - это операция, работающая сразу с тремя объектами - условие, правда, ложь.
также есть унарная, как i++, и бинарная, как a + b)

суть тернарной операции в том, чтобы заменить длинный блок кода с условием и двумя исходами на одну строку.

вместо:*/
int x = 3;
int y = 2;
if (x < y)
    Console.WriteLine(x + y);
else
    Console.WriteLine(x - y);

//можно сделать:
int z = x < y ? (x + y) : (x - y);
//переменная z будет равна результату проверки. условие для x + y это x < y, если условие неверно, то работает else (в тернаре это двоеточик) x - y
Console.WriteLine(z); //будет 1

/*
УПРАЖНЕНИЕ 1, 2 + РЕШЕНИЕ
1. В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. 
Напишите консольную программу, в которую пользователь вводит сумму вклада. 
Если сумма вклада меньше 100, то начисляется 5%. 
Если сумма вклада от 100 до 200, то начисляется 7%. 
Если сумма вклада больше 200, то начисляется 10%. 
В конце программа должна выводить сумму вклада с начисленными процентами.
Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine())
*/
Console.Write("Enter a deposit: ");
double deposit = Convert.ToDouble(Console.ReadLine());
if (deposit < 100)
    deposit *= 1.05;
else if (deposit is >= 100 and <= 200) //нельяз написать (100 < deposit < 200), надо разделять на две операции. для этого есть логический оператор "и" - &&. либо делать как у меня в решении.
    deposit *= 1.07;
else
    deposit *= 1.1;
Console.WriteLine($"Your deposit is {deposit}");

/*
2.Изменим предыдущую задачу. 
Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. 
И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы. 
Измените программу таким образом, чтобы к финальной сумме до начислялись бонусы.
*/
Console.Write("Enter a second deposit: ");
double deposit2 = Convert.ToDouble(Console.ReadLine());
if (deposit2 < 100)
    deposit2 *= 1.05;
else if (deposit2 is >= 100 and <= 200)
    deposit2 *= 1.07;
else
    deposit2 *= 1.1;
Console.WriteLine($"Your deposit is {deposit2 + 15}");


/*               ОПЕРАТОР ВЫБОРА (SWITCH CASE)
пример использования:
*/
int number = 13;
switch (number) //switch(---) - то, с чем надо сравнить
{
    case 1: //case (---) - то, что сравнивается. вместо единицы могут быть любые значения и даже проверка на сходство типов данных
        Console.WriteLine("Your number is 1.");
        break; //break - завершает работу оператора
    case 3:
        Console.WriteLine("Your number is 3.");
        break;
    case 13:
        Console.WriteLine("Your number is 13. Go to the 14th case.");
        goto case 14; //передаёт управление кейсу 14, go to case 14
        
    case 14:
        Console.WriteLine("You reached the 14th case.");
        break;
    
    default: //default - выполнится, если никакие другие кейсы не выполнилиись
        Console.WriteLine("Your number is unknown.");
        break;
}

/*            ЦИКЛЫ
в C# есть четыре вида циклов:
for
foreach
while
do ... while
*/

/*for
- работает по индексу и используется для, например, перебора с изменением значений, как здесь:*/

for (int i = 0; i < 5; i++) //int i - создаю счетчик, i < 5 - условие цикла, i++ - анлог i+=1
{
    Console.WriteLine($"Индекс: {i}");
}
//если for содержит только одну инструкцию, то можно убрать фигурные скобки:
for (int i =  0; i < 5; i++) 
    Console.WriteLine(i);
//или
for (int i =  0; i < 5; i++) Console.WriteLine(i);

/*foreach
- Read-Only цикл. Работает по элементам, а не индексам. С помощью него нельзя изменить, только вывести*/
string[] sports = { "Football", "Burmaldaball", "Basketball" };

foreach (string sport in sports)
{
    Console.WriteLine($"Let's play {sport}");
}
//также как и с for можно сокращать до одной строки без фигурных скобок
foreach (string sport in sports) Console.WriteLine($"Let's play {sport}");

/*while
- принципиально ничем не отличается от while в Python*/
int j = 6;
while (j > 0)
{
    Console.WriteLine(j);
    j--;
}

/*do...while
- тот же while, но он в любом случае выполнится хотя бы один раз*/
int bigNum = 10;
do
{
    Console.WriteLine("Этот текст выведется один раз");
    bigNum--;
} 
while (bigNum < 5); 
//пример использования do...while - запрос данных пользователя. в любом случае хотя бы один раз надо запросить данный

/*     CONTINUE И BREAK
в C# они ничем не отличаются от своих версий в Python. continue пропускает текущую итерацию, break - Xпредварительно завершает цикл
в C# оператора pass нет, так как пустые фигурные скобки после цикла и есть заглушка*/
string klan = "Black Dice";
if (klan == "333")
{
    //пустота и есть заглушка, pass не нужен
}
else
{
    Console.WriteLine("Not 333");
}

//текущий слайд - 43. следующая тема - массивы
























