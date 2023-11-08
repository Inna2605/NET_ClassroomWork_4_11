//Створіть класс Button та подію Click.
//Створіть пару підписників на цю подію.
//Тип делегату можна створити самостійно, а можете використовувати EventHandler.
//При появі подій показувати ім'я кнопки, яка нібито була нажата

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_ClassroomWork_21_10
{
    internal class Subscriber2
    {
        public static void PressingButton(string text)
        {
            Console.WriteLine("Subscriber2 " + text);
        }
    }
}
