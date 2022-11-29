int numberA = new Random().Next(1, 10); // 1, 2, 3, 4, ... 9 Слово Next говорит о том что число у нас целое
Console.WriteLine(numberA);
int numberB = new Random().Next (1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);