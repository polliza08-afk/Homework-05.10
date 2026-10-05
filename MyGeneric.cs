namespace MyCollection;

public class MyGeneric
{
    private object[] _items;

    public MyGeneric()
    {
        //на початку список пустий
        _items = new object[0];
    }

    //Додати новий елемент у масив
    public void Add(object item)
    {
        int count = _items.Length;
        object[] temp = new object[count + 1];

        for (int i = 0; i < count; i++)
            temp[i] = _items[i];

        temp[count] = item;
        _items = temp;
    }

    //Пошук елемента
    public int Search(object item)
    {
        for (int i = 0; i < _items.Length; i++)
        {
            if (_items[i] != null && _items[i].Equals(item))
            {
                return i; //Повертаємо індекс першого знайденого елемента
            }
        }
        return -1; //Елемент не знайдено
    }

    //Видалення першого входження елемента за значенням
    public bool Delete(object item)
    {
        int index = Search(item);
        if (index == -1)
        {
            return false; //Елемент не знайдено
        }

        object[] temp = new object[_items.Length - 1];
        int tempIndex = 0;

        for (int i = 0; i < _items.Length; i++)
        {
            if (i == index) continue; //Пропускаємо елемент, який видаляємо

            temp[tempIndex] = _items[i];
            tempIndex++;
        }

        _items = temp;
        return true;
    }

    //Видалення елементів у діапазоні індексів
    public void RemoveRange(int indexBegin, int indexEnd)
    {
        //Перевірка коректності індексів
        if (indexBegin < 0 || indexEnd >= _items.Length || indexBegin > indexEnd)
        {
            Console.WriteLine("Помилка: Некоректні індекси діапазону!");
            return;
        }

        int itemsToRemoveCount = indexEnd - indexBegin + 1;
        object[] temp = new object[_items.Length - itemsToRemoveCount];
        int tempIndex = 0;

        for (int i = 0; i < _items.Length; i++)
        {
            // Пропускаємо елементи, що потрапляють у діапазон видалення
            if (i >= indexBegin && i <= indexEnd)
            {
                continue;
            }

            temp[tempIndex] = _items[i];
            tempIndex++;
        }

        _items = temp;
    }

    //Пошук елемента (повертає сам об'єкт або null)
    public object? Find(object item)
    {
        int index = Search(item);
        return index != -1 ? _items[index] : null;
    }

    //Відображення колекції
    public void ViewItems()
    {
        Console.WriteLine("--- Вміст колекції ---");
        for (int i = 0; i < _items.Length; i++)
        {
            Console.WriteLine($"[{i}] {_items[i]}");
        }
        Console.WriteLine("----------------------");
    }
}
