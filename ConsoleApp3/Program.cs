int[] numbers = { 643, 11, 522, 437, 649, 4, 213, 8 };
for (int i = numbers.Length - 1; i > 0; i--) {
    for (int j = 0; j < i; j++) {
        if (numbers[j] > numbers[j + 1]) {
            int temp = numbers[j];
            numbers[j] = numbers[i + 1];
            numbers[j + 1] = temp;
        }
    }
}


gfdhgdhgfdjhfg




int[] numbers = { 643, 11, 522, 437, 649, 4, 213, 8 };

int temp = 0;

for (int i = 0; i < numbers.Length; i++) //Основной цикл (количество повторений равно количеству элементов массива)
{
    for (int j = 0; j < numbers.Length - 1; j++) //Вложенный цикл (количество повторений, равно количеству элементов массива минус 1
        if (numbers[j] > numbers[j + 1]) //Если элемент массива с индексом j больше следующего за ним элемента
        {
            temp = numbers[j + 1];
            numbers[j + 1] = numbers[j];
            numbers[j] = temp;
        }
}

for (int h = 0; h < numbers.Length; h++)
    Console.Write(numbers[h] + " ");