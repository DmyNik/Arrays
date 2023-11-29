
// Тема 3: Массивы.
// Задачи 1-4.
// Все задачи решены при помощи методов. Один метод - одна задача.

//--- Блок методов ---------------------------------------

// Задача 1

static void FindVolElemFrom20to90(int j) {

    Random rnd = new();

    int[] array = new int[j];

    byte cnt = 0;

    for ( int i = 0; i < j; i++ ) {

        array[i] = rnd.Next(1, 101);

        Console.Write("> Элемент массива {0} = {1}", i, array[i]);

        if (array[i] > 19 && array[i] < 91) {
            cnt++;
            Console.Write(" *");
        }

        Console.Write("\n");

    }

    Console.WriteLine("\n> Количество элементов массива, значения которых лежат в отрезке [20, 90] = {0}", cnt);

}

// Задача 2

static void NumberOfEvenValues(int j) {

    Random rnd = new();

    int[] array = new int[j];

    byte cnt = 0;

    for ( int i = 0; i < j; i++ ) {

        array[i] = rnd.Next(1, 101);

        Console.Write("> Элемент массива {0} = {1}", i, array[i]);

        if (array[i] % 2 == 0) { 
            cnt++;
            Console.Write(" *");
        }
        
        Console.Write("\n");

    }

    Console.WriteLine("\n> Количество чётных чисел в массиве = {0}", cnt);

}

// Задача 3

static void DiffBetweenMinAndMaxValue(int j) {

    if (j > 0) { 

        Random rnd = new();

        double[] array = new double[j];

        double min = 0;
        double max = 0;

        array[0] = rnd.Next(1, 101) + rnd.NextDouble();

        min = array[0];

        for ( int i = 1; i < j; i++ ) {

            array[i] = rnd.Next(1, 101) + rnd.NextDouble();

            //Console.Write("Элемент массива {0} = {1}", i, array[i]);

            if (array[i] < min ) min = array[i];
            if (array[i] > max ) max = array[i];
            
            //Console.Write("\n");

        }

        for ( int i = 0; i < j; i++ ) {

            Console.Write("> Элемент массива {0} = {1}", i, array[i]);

            if (array[i] == min || array[i] == max) Console.Write(" *");

            Console.Write("\n");

        }

        Console.WriteLine("\n> Разница между между максимальным и минимальным элеменом в массиве = " + (max - min));
    }

}

// Задача 4

static void DecompNumIntoAnArray(int num) {

    if (num > 0 && num < 100001) { 

        int num1 = num;
        int[] array;
        int cnt = 0;
        int order;
    
        while( num1 > 0 ) {

            num1 /= 10;
            cnt++;

        }

        array = new int[cnt];
        num1 = num;
        
        for ( int i = 0; i < cnt; i++ ) {

            order = 1;

            while( num1 > 10 ) {

                num1 /= 10;
                order *= 10;

            }

            array[i] = num1;

            Console.Write("Элемент массива {0} = {1}\n", i, array[i]);

            num1 = num - num1 * order;

        }

        Console.Write("\n");

    }

}

//----------------------------------------------------end

//--- Основной блок --------------------------------------

string? str;
string str1;
//string str2;

// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

Console.Write("\n> Задача 1\n\n");

Console.Write("> Для продолжения введите любой символ... ");
Console.ReadKey();
Console.Write("\n\n");

FindVolElemFrom20to90(10);

// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, 
// которая определяет количество чётных чисел в массиве.

Console.Write("\n> Задача 2\n\n");

Console.Write("> Для продолжения введите любой символ... ");
Console.ReadKey();
Console.Write("\n\n");

NumberOfEvenValues(10);

// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("\n> Задача 3\n\n");

Console.Write("> Введите требуемое количество элментов в массиве: ");
str = Console.ReadLine();
str1 = str ?? ""; 
Console.Write("\n");

DiffBetweenMinAndMaxValue(Convert.ToInt32(str1));

// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, 
// младший – на последнем. Размер массива должен быть равен количеству цифр.

Console.Write("\n> Задача 4\n\n");

Console.Write("> Введите натуральное число от 1 до 100 000: ");
str = Console.ReadLine();
str1 = str ?? ""; 
Console.Write("\n");

DecompNumIntoAnArray(Convert.ToInt32(str1));

//----------------------------------------------------end

Console.WriteLine("\nРабота программы завершена!\n");

Console.Write("> Для продолжения введите любой символ... ");
Console.ReadKey();
Console.Write("\n\n");