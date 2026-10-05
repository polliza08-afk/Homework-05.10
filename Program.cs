// See https://aka.ms/new-console-template for more information

using MyCollection;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("-- Колекція об'єктів --");

MyGeneric myList = new MyGeneric();

myList.Add(12);
myList.Add(23);
myList.Add(16);
myList.Add("Світлана");
myList.Add("Надія");
myList.Add(false);

Dog barbos = new Dog("Барбос", 3);
myList.Add(barbos);

myList.ViewItems();

//1. Search
int index = myList.Search("Надія");
Console.WriteLine($"\nІндекс елемента \"Надія\": {index}");

//2. Delete
Console.WriteLine("\nВидаляємо елемент 16:");
myList.Delete(16);
myList.ViewItems();

//3. RemoveRange
Console.WriteLine("\nВидаляємо елементи з індексу 1 по 3 включно:");
myList.RemoveRange(1, 3);
myList.ViewItems();
