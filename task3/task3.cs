/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76  */

/*  Метод "Создание и заполнение массива вещественными числами"
    чтобы разница между элементами была существеннее, чем нуль целых столько-то сотых,
    было добавлено два
*/
double [] GetArray(int size){
    double [] res = new double[size];
    for (int i = 0; i < size; i++){
        res[i] = (Elements() * Value10_100() + 2);
        Console.Write("{0:0.00}    ", res[i]);
    }
    Console.WriteLine();
    return res;
}

// Метод получения вещественных элементов. Примечание: функция Next.Double возвращает значения между 0,0 и 1,0, поэтому...
double Elements() {
    Random rnd = new Random();
    double el = rnd.NextDouble();
    return el;
}

// ...был создан метод генерации рандомного числа кратного десяти, чтобы элементы массива были двузначными (так же можно увеличить до многозначных)
int Value10_100(){
    Random rnd = new Random();
    int[] arr = new int[2] { 10, 100 };
    int i = rnd.Next(arr.Length);
    return arr[i];
}

Console.Write("Введите размер одномерного массива: ");
int s = int.Parse(Console.ReadLine());
double [] array = GetArray(s);

double Min(){
    double min = array[0];
    foreach (double el in array){
        if (el < min) min = el;
    }
    return min;
}

double Max(){
    double max = array[0];
    foreach (double el in array){
        if (el > max) max = el;
    }
    return max;
}

double Subtraction(double min, double max){
    double sub = max - min;
    return sub;
}

Console.Write("Разница между максимальным и минимальным равна: " + "{0:0.00}", Subtraction(Min(), Max()));