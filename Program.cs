//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] input = new string[4] {"Rock", "Lion", "Cat", "441"};
string[] output = new string[input.Length];

void NewArray(string[] input, string[] output)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if(input[i].Length <= 3)
        {
           output[count] = input[i];
            count++;
        }
    }
}
void Printarray(string[] array)
{
    {
        Console.WriteLine($"[{string.Join(", ", input)}] -> [{string.Join(", ", output)}]");
    }
    Console.WriteLine();
}

NewArray(input,output);
Printarray(output);