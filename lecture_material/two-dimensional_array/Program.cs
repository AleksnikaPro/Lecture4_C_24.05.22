// Двумерные массивы

/*string [,] table = new string [2,5];
// String.Empty  - такой константой происходит инициализация строк 
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]

table[1,2]  = "слово";

for (int rows = 0; rows < 2; rows++) // 2 строки
{
    for (int columns = 0; columns < 5; columns++) // 5 столбцов
    {
        Console.WriteLine($"-{table [rows, columns]}-");
    }
  
}*/

// ____________________________________________________________


/*int [,] matrix = new int [3,4];

for (int i = 0; i < 3; i++) 
{
    for (int j = 0; j < 4; j++) 
    {
        Console.Write($"{matrix [i, j]} ");
    }
    Console.WriteLine(); // чтобы был переход на новую строку
}*/
// Вывод
//    0 0 0 0 
//    0 0 0 0
//    0 0 0 0

//_________________________________________________
/*
int [,] matrix = new int [3,4];

for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        Console.Write($"{matrix [i, j]} ");
    }
    Console.WriteLine(); // чтобы был переход на новую строку
}*/

//Опишем метод, который будет печатать двумерный массив (матрицу), и заполнять ее числами.
//___________________________________________________
/*
void PrintArray(int [,] matrix) // принимает матрицу (в качестве аргумента) и печатает ее
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write($"{matrix [i, j]} ");
        }
        Console.WriteLine(); // чтобы был переход на новую строку
    }


}
void FillArray(int[,] matrix) // метод заполняет матрицу числами
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix [i, j] = new Random().Next(1,10); // [1;10) - полуинтервал
        }
    }
}
int [,] matrix = new int [3,4];
PrintArray(matrix);
FillArray (matrix);
Console.WriteLine();
PrintArray(matrix);
*/
//_____________________________________________________

// рисунок палец
// 0 - пробел, 1 - +
// 0 - закрашенный пиксель, 1- незакрашенный пиксель

int[,] pic = new int[,]
{
 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,1,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,1,1,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0},
 {0,0,1,1,1,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0},
 {0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
 {0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            // Console.Write($"{image[i,j]} ");
            if (image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}
void FillImage(int row, int column)
{
    if (pic[row, column] == 0)
    {
        pic[row, column] = 1;
        FillImage(row - 1, column);
        FillImage(row, column - 1);
        FillImage(row + 1, column);
        FillImage(row, column + 1);
    }
}
PrintImage(pic);
FillImage(13,13);
PrintImage(pic);

//______________________________________________________

// Второй вариант

int[,] pic = new int[,]
{
 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,1,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
 {0,0,0,0,0,1,1,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0},
 {0,0,1,1,1,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
 {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0},
 {0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
 {0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0},
 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};
//--------------------------------------------------------------------------------------------------------------+
void RedrawPicture(int[,] pic, string zero, string one)
{
    for (int rows = 0; rows < pic.GetLength(0); rows++)
    {
        for (int col = 0; col < pic.GetLength(1); col++)
        {
            if (pic[rows, col] == 0) Console.Write(zero);
            else Console.Write(one);
        }
        Console.WriteLine();
    }
}
//--------------------------------------------------------------------------------------------------------------+
void FillPicture(int row, int col)
{
    if(pic[row,col] == 0)
    {
        pic[row,col] = 1;
        FillPicture(row-1,col);
        FillPicture(row,col-1);
        FillPicture(row+1,col);
        FillPicture(row,col+1);
    }
}
//--------------------------------------------------------------------------------------------------------------+
double Factorial(int n)
{
    if(n==1) return 1;
    else return (Factorial(n-1) * n);
}
//--------------------------------------------------------------------------------------------------------------+
double Fibo(int n)
{
    if(n == 1 || n == 2) return 1;
    else           
    {
        return(Fibo(n-1) + Fibo(n-2));
    }   
}
//--------------------------------------------------------------------------------------------------------------+
RedrawPicture(pic,"   ","-x-");
FillPicture(13,13);
RedrawPicture(pic,"   ","-x-");
/*
double fiboSum = 0;
for (int i = 1; i <= 40; i++)
{   double f = Fibo(i);
fiboSum += f;
    Console.WriteLine($"Fibo({i}) = {f}");
}

Console.WriteLine(fiboSum/20);
*/