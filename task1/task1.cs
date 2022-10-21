/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2  
*/


int [] GetArray(int size){
    int [] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(100,1000);
        Console.Write(res[i]+ " ");
    }
    Console.WriteLine();
    return res;
}

Console.Write("Введите размер массива: ");
int s = int.Parse(Console.ReadLine());
int [] array = GetArray(s);

int Gualitity(){
    int quantity = 0;
    foreach (int el in array){
        if ((el%2) == 0) quantity++;
    }
    return quantity;
}
Console.WriteLine("Сумма чётных чисел в массиве: " + Gualitity());