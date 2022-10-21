/*  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 
*/

int [] GetArray(int size){
    int [] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(-100,101);
        Console.Write(res[i]+ " ");
    }
    Console.WriteLine();
    return res;
}

Console.Write("Введите размер одномерного массива: ");
int s = int.Parse(Console.ReadLine());
int [] array = GetArray(s);


int Sum(){
    int sum = 0;
    for (int i = 1; i < s;){
    sum += array[i];
    i += 2;
    }
    return sum;
}

Console.WriteLine("Сумма элементов на нечётных позициях: " + Sum());