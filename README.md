# Простые программы в процессе изучения C#

[1.fuel_calc](https://github.com/nomadpyn/CSharp_Study/tree/master/fuel_calc)

Программа запрашивает у пользователя пройденное расстояние, а также израсходованный объем топлива. Далее выводит средний расход топлива.

[2.max_value](https://github.com/nomadpyn/CSharp_Study/tree/master/max_value)

Программа запрашивает у пользователя три числа и выводит на экран максимальное число.

[3.procent](https://github.com/nomadpyn/CSharp_Study/tree/master/procent)

Пользователь вводит с клавиатуры два числа. Первое число — это значение, второе число процент, который необходимо посчитать. Например, мы ввели с клавиатуры 90 и 10.Требуется вывести на экран 10 процентов от 90. Результат: 9.

[4.fizz_buzz](https://github.com/nomadpyn/CSharp_Study/tree/master/fizz_buzz)

Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без остатка) нужно вывести слово Fizz. Если число кратно 5 нужно вывести слово Buzz. Если число кратно 3 и 5 нужно вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно вывести само число. Если пользователь ввел значение не в диапазоне от 1 до 100 требуется вывести сообщение об ошибке.

[5.quad_eq](https://github.com/nomadpyn/CSharp_Study/tree/master/quad_eq)

Программа вычисляет корни квадратного уравнения.

[6.leap_year](https://github.com/nomadpyn/CSharp_Study/tree/master/leap_year)

Программа проверяет, является ли год високосным или нет.

[7.arrays](https://github.com/nomadpyn/CSharp_Study/tree/master/arrays)

Объявить одномерный (5 элементов) массив с именем А и двумерный массив (3 строки, 4 столбца) дробных чисел с именем В. Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а двумерный массив В случайными числами с помощью циклов. Вывести на экран значения массивов:
* массив А в одну строку;
* массив В в виде матрицы.

Также найти и вывести:
* общий максимальный элемент;
* общий минимальный элементы;
* общую сумму всех элементов;
* общее произведение всех элементов;
* сумму четных элементов массива А;
* сумму нечетных столбцов массива В.

[8.strings_hw](https://github.com/nomadpyn/CSharp_Study/tree/master/strings_hw)

Пользователь с клавиатуры вводит некоторый текст. Приложение должно изменять регистр первой буквы каждого предложения на букву в верхнем регистре.

[9.seven_wonders](https://github.com/nomadpyn/CSharp_Study/tree/master/seven_wonders)

Разработйте приложение "7 чудес света", где каждое чудо будет представлено отдельным классом, в отдельном файле. Создайте дополнительный класс, в котором будут объекты каждого класса. Распределите приложение по файлам проекта и с помощью простраства имен обеспечьте возможность отображение всех чудес в дополнительном классе.

[10.garage](https://github.com/nomadpyn/CSharp_Study/tree/master/garage)

Создать класс Автомобиль с полями Название, Цвет, Максимальная скорость. Создать класс гараж и добавить в него несколько автомобилей. Далее использую стандартные интерфейсы, реализовать сортировки машин в гараже по названию, по цвету и по скорости. Вывести состояние гаража после каждой сортировки.

[11.byte_exception](https://github.com/nomadpyn/CSharp_Study/tree/master/byte_exception)

Создать приложение, которое получает две переменных типа byte. Создать методы для их сложения, разности, умножения и деления. В каждом методе сделать необходимые проверки на выход значения за границу, деления на ноль, с отлавливанием исключения. Также предусмотреть checked и unchecked.

[12.line](https://github.com/nomadpyn/CSharp_Study/tree/master/line)

Создать обобщенный класс прямой на плоскости. В классе предусмотреть 2 поля типа обобщенной точки - точки, через которые проходит прямая. Реализовать в классе:
* конструктор, который принимает 2 точки;
* конструктор, который принимает 4 координаты ( X и Y координаты первой и второй точки);
* метод ToString()\

[13.point3D](https://github.com/nomadpyn/CSharp_Study/tree/master/point3D)

Создать необобщенный класс точки в трехмерном прострастве с целочисленными координатами, который наследуется от generic-класса Point2D<T>, рассмотренного в уроке. Реализовать в классе:
* конструктор с параметрами, который принимает начальные значения для координат точки
* метод ToString()

[14.country_dict](https://github.com/nomadpyn/CSharp_Study/tree/master/country_dict)

Создать примитивный англо-русский и русско-английский словарь, содержащий пары слов - названий стран на русском и английском языках. Пользователь должен иметь возможность выбирать направления перевода и запрашивать перевод.