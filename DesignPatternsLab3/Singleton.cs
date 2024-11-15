using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Singleton
{
    private static Singleton instance; // Хранит единственный экземпляр

    // Приватный конструктор предотвращает создание экземпляров извне
    private Singleton()
    {
        Console.WriteLine("Экземпляр Singleton создан!");
    }

    // Глобальная точка доступа
    public static Singleton GetInstance()
    {
        if (instance == null) // Если экземпляр еще не создан
        {
            instance = new Singleton();
        }
        return instance;
    }

    public void ShowMessage()
    {
        Console.WriteLine("Привет из Singleton!");
    }
}

