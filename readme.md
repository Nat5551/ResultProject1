# Описание решения задачи
В итоговом проекте решается **Задача:**

*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.*

### Решение задачи содержит два файла:
1. shared.cs
2. hw.cs

**Файл shared.cs** содержит методы:
* **Input** - Ввод целочисленного числа
* **CreateArray** - Создание строкового массива
* **FillBy** - Заполнение данными массива, ручным вводом элементов массива
* **PrintArray** - Печать массива строк
* **MyFuncItog** - Метод, который решает задачу проекта

**Файл hw.cs**  - результирующий файл, использует методы из второго файла.

Первоначально в файле *hw.cs* пользователю нужно ввести размерность первоначального строкового массива. Затем ввести его элементы. Для этого используем методы *Input*,*CreateArray*,*FillBy*.
Затем печатаем полученный массив при помощи метода *PrintArray*. И вызываем *MyFuncItog*, чтобы вывести на печать новый массив, состоящий из элементов, длина которых меньше либо равна 3 символа.

## Описание метода **MyFuncItog**:
1. Метод получает во входном параметре первоначальный массив строк.
2. В теле метода формируем новый пустой строковый массив при помощи метода *CreateArray*.
3. При помощи цикла перебираем все элементы первоначального массива. Если длина элемента меньше либо равна 3, то добавляем этот элемент  в новый массив. 
4. Печатаем новый массив, используя метод *PrintArray*.



