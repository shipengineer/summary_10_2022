# Текстовый файл в рамках контрольной работы за первые три месяца в GeekBrains

## 11.10.2022

### Условие задачи

- Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
  > 1.  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
  > 2.  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Ход решения задачи

1. Была нарисована схема (алгоритм) программы в draw.io

   ![Получившаясясхема](https://s1.hostingkartinok.com/uploads/images/2022/10/9cbe9ac52e76a971b8bf9418f162fa1b.png)

2. Описывая алгоритм можно сказать следующее

   - Для начала определялся исходный массив. Я решил задать его из разных букв и цифр в различном регистре. Сделано это для упрощения проверки решения. Проблем задать перебором введения значений каждого предлагаемого массива и определения длины не покажет мое "невероятное знание языка", а лишь усложнит работу проверяющего.
   - Задав стартовый массив была опеределена функция поиска трехсимвольных строк **SearchForThrdCharString**

     > (прим. Название считаю достаточным для понимания)

   - Понимая, что каждый элемент массива это строка, а в языке C# она, эта строка, будет представленна как массив (Вот такой массив массивов 😏), Я использовал условие на проверку количества элементов(символов) в массиве-строке.

   - Отлавливая все массивы-строки с количеством элеметов 3 или менее конструкцией **_if_** я присваивал значения в новом массиве **_out_mas_** по адресу **_j_**.
     -Отдельная интересная история с выъодным массивом. Я не мог обойтись вторым счетчиком конструкции **_for_**. Нужно было, что бы элемент наращивался только при нахождении подходящей строки. И не было понятно, какого объема должен был быть выходной массив.
     > Здесь на помощь пришел метод Array.Resize и вынесения **_j_** за цикл.
     > Каждую итерацию, при нахождении элемента, я переопределяю длину выходного массива на величину **_1 + j_**. И правда, таким образом вводимый массив может быть любым. А выходной массив будет без пустых клеток.

### Если вы, все таки, читаете этот ридми, а не проверяете мои навыки написания в MarkDown

Я благодарю Вас за проделанную работу по проверке. Вы долго и упорно все проверяли и теперь заслужили свою маленькую награду в благодарность за потраченное на Меня время. Я очень надеюсь, что Вы ее оцените и она поднимет вам настроение.

## [👍Награда👍](https://www.youtube.com/watch?v=xvFZjo5PgG0&ab_channel=Duran)
