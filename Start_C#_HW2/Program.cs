/*
Дан двумерный массив.
732
496
185
Отсортировать данные в нем по возрастанию.
123
456
789
Вывести результат на печать.
class Program
{
static void Main(string[] args)
{
int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
}
}
*/


namespace Start_C__HW2
{

    internal class Program
    {
        static int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        static int[] myArray = new int[9];
        static void Main(string[] args)
        {
            int temp = 0;
            int tempx = 0;
            int tempy = 0;
            int z = 0;

            Console.Write("До сортировки:");
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write($"{a[i, j]} ,");
                }
            }

            for (int x = 0; x <= 2; x++)
            {
                for (int y = 0; y <= 2; y++)
                {
                    myArray[z] = a[x, y];
                    z++;
                }   

            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }





            for (int c = 0; c < myArray.Length; c++)
            {
                a[tempy, tempx] = myArray[c];
                tempx++;
                if(tempx > 2)
                {
                    tempx = 0;
                    tempy++;
                }
            }


            Console.WriteLine();
            Console.Write("После сортировки:");
            for (int i = 0; i <= 2; i++)
                  {
                    Console.WriteLine();
                        for (int j = 0; j <= 2; j++)
                        {
                               Console.Write( $"{ a[i, j]} ,");
                        }
                 }
            
        }
    }
}