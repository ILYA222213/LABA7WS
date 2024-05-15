using System;

public class GenericArray<T>
{
    / Приватные поля для хранения массива и его длины
    private T[] array;
    private int length;

    // Конструктор, принимающий размер массива и инициализирующий поля
    public GenericArray(int size)
    {
        array = new T[size];
        length = size;
    }

    // Метод для добавления элемента в массив
    public void Adding_data(int index, T element)
    {
        // Проверка допустимости индекса
        if (index >= 0 && index < length)
        {
            array[index] = element;
        }
        else
        {
            // Вывод сообщения об ошибке
            Console.WriteLine("Недопустимый индекс.");
        }
    }

    // Метод для удаления элемента из массива
    public void Remove_items(int index)
    {
        // Проверка допустимости индекса
        if (index >= 0 && index < length)
        {
            // Установка элемента по указанному индексу в значение по умолчанию для типа T
            array[index] = default(T);
        }
        else
        {
            // Вывод сообщения об ошибке
            Console.WriteLine("Недопустимый индекс.");
        }
    }

    // Метод для получения элемента массива по индексу
    public T GetElement(int index)
    {
        // Проверка допустимости индекса
        if (index >= 0 && index < length)
        {
            // Возврат элемента массива по указанному индексу
            return array[index];
        }
        else
        {
            // Вывод сообщения об ошибке
            Console.WriteLine("Недопустимый индекс.");
            // Возврат значения по умолчанию для типа T
            return default(T);
        }
    }

    // Метод для получения длины массива
    public int GetLength()
    {
        // Возврат длины массива
        return length;
    }
}

// Класс Program, содержащий точку входа в приложение
class Program
{
    static void Main()
    {
        // Создание обобщенного массива целых чисел
        GenericArray<int> intArray = new GenericArray<int>(3);

        // Добавление элементов в массив целых чисел
        intArray.Adding_data(0, 14);
        intArray.Adding_data(1, 21);
        intArray.Adding_data(2, 52);

        // Вывод длины массива целых чисел
        Console.WriteLine($"Длина целочисленного массива: {intArray.GetLength()}");

        // Получение элемента массива целых чисел по индексу
        Console.WriteLine($"Элемент масива с индексом 2 равен: {intArray.GetElement(2)}");

        // Создание обобщенного массива строк
        GenericArray<string> stringArray = new GenericArray<string>(2);

        // Добавление элементов в массив строк
        stringArray.Adding_data(0, "Hello");
        stringArray.Adding_data(1, "World");

        // Вывод длины массива строк
        Console.WriteLine($"Длина строкового массива: {stringArray.GetLength()}");

        // Получение элемента массива строк по индексу
        Console.WriteLine($"Элемент масива с индексом 1 равен: {stringArray.GetElement(1)}");

        // Создание обобщенного массива чисел с плавающей точкой
        GenericArray<double> doubleArray = new GenericArray<double>(4);

        // Добавление элементов в массив чисел с плавающей точкой
        doubleArray.Adding_data(0, 3.14);
        doubleArray.Adding_data(1, 1.618);
        doubleArray.Adding_data(2, 2.718);
        doubleArray.Adding_data(3, 2.72222);

        // Вывод длины массива чисел с плавающей точкой
        Console.WriteLine($"Длина массива чисел с плавающей точкой: {doubleArray.GetLength()}");

        // Получение элемента массива чисел с плавающей точкой по индексу
        Console.WriteLine($"Элемент масива с индексом 3 равен: {doubleArray.GetElement(3)}");
    }
}
