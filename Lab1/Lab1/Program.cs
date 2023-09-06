using System;
using System.Text;

namespace Lab1NameSpace
{
    class Lab1
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Задание 1 a");
            Console.WriteLine("----------");

            bool a = true;
            byte b = 255;             // 0 до 255
            sbyte s = -128;           // -128 до 127
            char c = 's';
            decimal dec = 1.5E6m;     // decimel - десятичная структура, диапозон ±1,0 х 10^(-28) до ±7.9228 x 10^28 // output: 1500000, где m - это литерал для типа decimal
            double dd = 111111.7777;  // ±5.0 × 10^−324 to ±1.7 × 10^308
            float f = 123213.123123F; // ±1.5 x 10−45 to ±3.4 x 1038
            int i = 13;               // -2,147,483,648 to 2,147,483,647
            uint u = 4294967295;      // 0 to 4,294,967,295
            nint n = 42;              // Интегральные числовые типы
            nuint nui = 420;          // предназначен для целого числа, размер которого равен размеру указателя
            long l = 100000;          // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong r = 1000000;        // 0 to 18,446,744,073,709,551,615
            short sh = 32767;         // -32,768 to 32,767
            ushort ush = 65500;       // 0 to 65,535


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(s);
            Console.WriteLine(c);
            Console.WriteLine(dec);
            Console.WriteLine(dd);
            Console.WriteLine(f);
            Console.WriteLine(i);
            Console.WriteLine(u);
            Console.WriteLine(n);
            Console.WriteLine(nui);
            Console.WriteLine(l);
            Console.WriteLine(r);
            Console.WriteLine(sh);
            Console.WriteLine(ush);

/*            Console.WriteLine("Введите ваше имя");
            string? name = Console.ReadLine();
            Console.WriteLine("Введите вашу группу");
            int number = Console.Read();
            Console.WriteLine("Группа: {0}", (char)number);
            Console.WriteLine();*/

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 1 b");
            Console.WriteLine("-----------");

            // Неявное преобразование
            byte t_1_b = 18;
            short s1 = t_1_b;
            ushort s2 = t_1_b;
            int i1 = t_1_b;
            long l1 = t_1_b;
            ulong l2 = t_1_b;

            // Явное преобразование
            short s3 = 54;
            long l_2 = 1200;
            byte b2 = (byte)s3;
            ushort ush2 = (ushort)b2;
            long l3 = (long)l_2;
            char sym = (char)s3;
            int num = (int)'a';

            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", b2, ush2, l3, sym, num);
            
            // Convert
            byte b3 = Convert.ToByte(s3);
            int i2 = Convert.ToInt32(l3);
            int i3 = Convert.ToInt16(l3);

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 1 c");
            Console.WriteLine("-----------");

            // Упаковка подразумевает сохранение типа значения как объекта = тип значения поля в System.Object.
            // Распаковка = прочитать значение из объекта = распаковать значение из объекта
            int for_pack = 123;
            // Упаковка представляет преобразование объекта значимого типа(например, типа int) к типу object
            object obj = for_pack;
            Console.WriteLine("Операция упаковки: for_pack = {0}, obj = {1}", for_pack, obj);
            obj = 345;
            // Распаковка (unboxing) представляет преобразование объекта типа object к значимому типу.
            for_pack = (int)obj;
            Console.WriteLine("Операция распаковки: for_pack = {0}, obj = {1}", for_pack, obj);

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 1 d");
            Console.WriteLine("-----------");

            // Скомпилированы как int, string
            var i5 = 5;
            var s4 = "Hello";
            Console.WriteLine("Неявно типизированные переменные: Type of var i5 = {0}, var s4 = {1}", i5.GetType(), s4.GetType());

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 1 e");
            Console.WriteLine("-----------");

            // тип int? - тип, переменные/параметры которого могут принимать как значения типа int, так и значение
            // null. В данном случае мы передаем ей значение null. Но также можно передать и значение типа int:

            int? val = null;
            if (val == null) Console.WriteLine("obj = null");
            val = 22;
            Console.WriteLine("val = {0}", val);

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 1 f");
            Console.WriteLine("-----------");

            var task_f = 32;
            //task_f = "task_f";
            // C# - язык со строгой типизацией, ее нельзя менять в ходе выполнения программы

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 2 а");
            Console.WriteLine("-----------");

            string animal1 = "Cat";
            string animal2 = "Dog";
            int result;

            // 0 - строки равны
            // > 0 - первая меньше второй
            // < 0 - первая больше второй или вторая равна null
            result = animal1.CompareTo("Cat"); // результат равен нулю
            Console.WriteLine(result);
            result = animal2.CompareTo("Cat"); // результат больше нуля
            Console.WriteLine(result);
            result = animal1.CompareTo(animal2); // результат меньше нуля
            Console.WriteLine(result);

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 2 b");
            Console.WriteLine("-----------");

            String strr3 = "Belarus";
            String strr4 = "USA";
            String strr5 = "Australia";

            // сцепление
            Console.WriteLine($"Сцепление: {String.Concat(strr3, strr4, strr5)}");

            // копирование
            String strr3_copy = String.Copy(strr3);
            Console.WriteLine($"Копирование: {strr3_copy}");

            // выделение подстроки
            Console.WriteLine($"Выделение подстроки: {strr5.Substring(3, 4)}");   // начало, количество

            // разделение строки на слова
            Console.WriteLine($"Разделение строки на слова:");
            String sententce = "My name is Sergey";
            string[] words2 = sententce.Split(' '); // ["My","name","is","Sergey"]

            // вставка подстроки в заданную позицию
            Console.WriteLine($"Вставка подстроки: {strr3.Insert(1, "Minsk")}");

            // удаление заданной подстроки
            Console.WriteLine($"Удаление подстроки: {strr3.Remove(5)}"); // c 5 до конца
            Console.WriteLine($"Удаление подстроки: {strr3}");

            // интерполяция строк ($"{value}")
            Console.WriteLine($"Интерполяция строк: 1-st word: {strr4}, 2-nd word: {strr3}");

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 2 c");
            Console.WriteLine("-----------");

            string stEmpty = ""; // пустая строка
            String stNull = null;

            Console.WriteLine($"stEmpty is empty: {string.IsNullOrEmpty(stEmpty)}");
            Console.WriteLine($"stNull is null: {string.IsNullOrEmpty(stNull)}");

            string answer1 = "based";
            while (!string.IsNullOrEmpty(answer1))
            {
                Console.WriteLine("Введите ваше имя: ");
                answer1 = Console.ReadLine();
            }

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 2 d");
            Console.WriteLine("-----------");

            // StringBuilder - динамическая строка, используется чаще чем System.String когда нужно обработать больше строк
            // и больше методов над ними.

            StringBuilder strbuid = new StringBuilder("BUILDER", 50);
            Console.WriteLine($"Исходная строка: {strbuid}");

            //Удалите определенные позиции
            strbuid.Remove(1, 1);
            Console.WriteLine($"Строка без второго символа: {strbuid}");

            //добавьте новые символы
            //в начало
            strbuid.Insert(0, "String Builder ");
            Console.WriteLine($"Строка с новыми символами: {strbuid}");

            //и конец строки
            strbuid.Append(" in use ");
            Console.WriteLine($"Строка с новыми символами: {strbuid}");

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 3 а");
            Console.WriteLine("-----------");

            int[,] dbArray = new int[3, 3] { {1, 2 ,3}, {4, 5, 6}, {7, 8, 9} };
            Console.WriteLine("Элементы массива: ");
            int count1 = 0;
            foreach (var item in dbArray)
            {
                count1++;
                Console.Write($"{item}  ");
                if (count1 % 3 == 0)
                {
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 3 b");
            Console.WriteLine("-----------");

            String[] myStr = new String[] { "I", "like", "dogs" };
            Console.WriteLine("Введите позицию изменяемого элемента: ");
            int pos1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите его значение: ");
            string value1 = Console.ReadLine();

            myStr[pos1] = value1;

            foreach (var item in myStr)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine($", длина массива = {myStr.Length}");

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 3 c");
            Console.WriteLine("-----------");

            int[][] stairsArray = new int[3][];
            stairsArray[0] = new int[2];
            stairsArray[1] = new int[3];
            stairsArray[2] = new int[4];

            Console.WriteLine("Введите элементы массива");

/*            for (int item = 0; item < 3; item++)
            {
                for (int y = 0; y < stairsArray[item].Length; y++)
                    stairsArray[item][y] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }*/

            for (var item = 0; item < stairsArray.Length; item++)
            {
                for (int y = 0; y < stairsArray[item].Length; y++)
                    Console.Write(stairsArray[item][y] + " ");
                Console.WriteLine("");
            }

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 3 d");
            Console.WriteLine("-----------");

            var myArrray = new[] {"I", "You"};
            var myString = "String";
            foreach (var item in myArrray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 4 a");
            Console.WriteLine("-----------");

            // Кортеж — набор из нескольких значений, возможно, разного типа.
            // Кортежи состоят как минимум из двух элементов.Тип значений можно указывать явно и неявно

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 4 b");
            Console.WriteLine("-----------");

            // В дальнейшем мы можем обращаться к каждому из этих значений через поля с названиями:
            // Item[порядковый_номер_поля_в_кортеже]

            var myTuple_1 = Tuple.Create(2, "name", 'a', "age", 130000UL);
            Console.WriteLine($"Полный кортеж: {myTuple_1.Item1}, {myTuple_1.Item2}, {myTuple_1.Item3}, {myTuple_1.Item4}, {myTuple_1.Item5}");
            Console.WriteLine($"Его второй элемент: {myTuple_1.Item2}");

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 4 c");
            Console.WriteLine("-----------");

            var myTuple_2 = Tuple.Create(2, "name", 'a', "age", 130000UL);

            (string name, string age) = (myTuple_2.Item2, myTuple_2.Item4);
            Console.WriteLine($"Name: {name}, age: {age}");

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 4 d");
            Console.WriteLine("-----------");

            // Кортеж - ссылочный тип. Отдельный экземпляр - отдельный обьект, не равный другому.

            if (myTuple_2 == myTuple_1)
            {
                Console.WriteLine("Кортежи равны");
            }
            else
            {
                Console.WriteLine("Кортежи не равны");
            }


            Console.WriteLine("-----------");
            Console.WriteLine("Задание 5");
            Console.WriteLine("-----------");

            (int, int, int, char) Task5(int[] intArr, string str)
            {
                char firstL = str[0];
                int max = intArr.Max();
                int min = intArr.Min();
                int sum = intArr.Sum();
                (int, int, int, char) kortej = (min, max, sum, firstL);
                return kortej;
            }

            int[] numArr = { 10, 20, 30 };
            Console.WriteLine("Элементы массива: ");
            foreach (var piece in numArr)
                Console.Write(piece + " ");
            Console.WriteLine("");

            Console.WriteLine($"(min, max, sum, firstL) = {Task5(numArr, "С#")}");

            Console.WriteLine("-----------");
            Console.WriteLine("Задание 6");
            Console.WriteLine("-----------");


            // результаты некоторых видов арифметических вычислений могут превышать диапазон представления чисел для типа данных,
            // используемого в вычислении. В этом случае происходит так называемое переполнение.

            //  Так, если требуется указать, что выражение будет проверяться на переполнение, следует использовать ключевое слово checked,
            //  а если требуется проигнорировать переполнение — ключевое слово unchecked.
            //  В последнем случае результат усекается, чтобы не выйти за пределы диапазона представления чисел для целевого типа выражения.

            void func_checked()
            {
                int q = int.MaxValue;
                try
                {
                    checked
                    {
                        q++;
                    }
                }
                catch
                {
                    Console.WriteLine("Переполнение в checked");
                }
            }
            void func_unchecked()
            {
                int q = int.MaxValue;
                try
                {
                    unchecked
                    {
                        q++;
                    }
                }
                catch
                {
                    Console.WriteLine("Переполнение в unchecked");
                }
            }

            func_unchecked();
            func_checked();
        }
    }
}






