//Console.WriteLine("Введите координаты точки по оси Х");
//int X = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите координаты точки по оси Y");
//int Y = Convert.ToInt32(Console.ReadLine());
//
//if(X==0 || Y==0){
//    Console.WriteLine("Точка находится на оси");
//}
//if(X>0 && Y>0){
 //   Console.WriteLine("Точка находится в первой четверти");
//}
//else if(X<0 && Y>0){
 //   Console.WriteLine("Точка находится во второй четверти");
//}
//else if(X<0 && Y<0){
//    Console.WriteLine("Точка находится в третьей четверти");
//}
//else if(X>0 && Y<0){
//    Console.WriteLine("Точка находится в третьей четверти");
//}

//static void Main(string[]args{
    //int[] Input()
    //{
     //   int[] Array = new int [2];
      //  Console.WriteLine("Введите координаты точки по оси Х");
      //  int X = Convert.ToInt32(Console.ReadLine());
      //  Array [0] = X;
      //  Console.WriteLine("Введите координаты точки по оси Y");
      //  int Y = Convert.ToInt32(Console.ReadLine());
      //  Array [1] = Y;
      //  return Array;
   // }
//int [] mini = Input ();
//while (mini [0]==0 || mini[1]==0){
 //   Console.WriteLine("Точка находится на оси");
//}
//if(mini [0]>0 && mini [1] >0){
    //Console.WriteLine("Точка находится в первой четверти");
//}
//else if(mini [0] <0 && mini [1] >0){
  //  Console.WriteLine("Точка находится во второй четверти");
//}
//else if(mini [0] <0 && mini [1] <0){
//    Console.WriteLine("Точка находится в третьей четверти");
//}
//else if(mini [0] >0 && mini [1] <0){
 //   Console.WriteLine("Точка находится в третьей четверти");
//}
//}

//Практическое задание к семинару 3
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//Console.WriteLine ("Введите пятизначное число N");
//int N = Convert.ToInt32(Console.ReadLine());
//int a1 = N%10;
//int a2 = N/10%10;
//int a3 = N/100%10;
//int a4 = N/1000%10;
//int a5 = N/10000%10;
//if (a1==a5 && a2==a4){
//  Console.WriteLine ("Число является палиндромом");
//  }
//  else{
//  Console.WriteLine ("Число не явлется палиндромом");
//}

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//Console.WriteLine("Введдите Ax");
//int Ax = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введдите Ay");
//int Ay = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введдите Az");
//int Az = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите Bx");
//int Bx = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введдите By");
//int By = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введдите Bz");
//int Bz = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(Math.Sqrt((Ax-Bx)*(Ax-Bx) + (Ay-By)*(Ay-By) + (Az-Bz)*(Az-Bz))); 

