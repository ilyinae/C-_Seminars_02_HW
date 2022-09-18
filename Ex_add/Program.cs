//Дополнительная задача
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=113&id_problem=695
//


  // Открываем текстовый файл, используя StreamReader.
    var sr = new StreamReader("input.txt");
    // Количество кустов - в первой строке - непонятно зачем оно вообще - будем работать через длину массива из второй строки. Но раз дано в условии задачи - пусть будет в отдельной переменной
    int bushCount = Convert.ToInt32(sr.ReadLine());
    // Урожай каждого куста - в виде массива - во второй строке
    string initialString = sr.ReadLine();
    string[] bushCapArr = initialString.Split(' ');


int summ3 = 0, //сумма ягод с трех кустов - считаем на каждой итерации цикла
    max = 0,   // максимальное значение суммы - присваиваем на каждой итерации цикла, если сумма его превышает
    bushCou = bushCapArr.Count(); // количество кустов (длина массива)

for (int i = 0; i <= bushCou-1; i++)
{
    if (i == 0) //для первого куста - обрабатываем отдельно
    {
        summ3 = Convert.ToInt32(bushCapArr[i]) + Convert.ToInt32(bushCapArr[i+1]) + Convert.ToInt32(bushCapArr[bushCou-1]);
        max = summ3;
    }
    else
    {
        if (i == bushCapArr.Count()-1) //для последнего куста - обрабатываем отдельно
        {
            summ3 = Convert.ToInt32(bushCapArr[i]) + Convert.ToInt32(bushCapArr[i-1]) + Convert.ToInt32(bushCapArr[0]);
            if (summ3 > max)
                max = summ3;
        }    
        else // для всех остальных кустов
        { 
            summ3 = Convert.ToInt32(bushCapArr[i]) + Convert.ToInt32(bushCapArr[i-1]) + Convert.ToInt32(bushCapArr[i+1]);
            if (summ3 > max)
                max = summ3;
        }
    }
}

string outString = "Максимальное суммарное значение трех соседних элементов закольцованного массива  [" + initialString + "] равняется: " + max;
Console.WriteLine(outString);

// // Используя StreamWriter перезаписываем содержимое файла output.txt
 using (StreamWriter writer = new StreamWriter("output.txt", false))
     await writer.WriteAsync(outString);