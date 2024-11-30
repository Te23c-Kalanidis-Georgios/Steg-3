//{
//  Hello32();
// }

//static void Hello32()
//{
//  for (int i = 0; i < 32; i++)
// {
//     Console.WriteLine("Hello, World");
// }
// }
//Console.ReadLine();











//   PrintSquare(5); 
// PrintSquare(10); 


//static void PrintSquare(int number)
//{
//  int square = number * number;
// Console.WriteLine($"Kvadraten av {number} är {square}");
//}
//Console.ReadLine();











//double result = Multi(4.5, 3.2);
//  Console.WriteLine($"Resultatet är: {result}"); 

// static double Multi(double a, double b)
// {
//   return a * b;
// }

//Console.ReadLine();









//using System;

//class Program
//{
//static void Main(string[] args)
//{
//  RightTriangleArea();
// }

// static void RightTriangleArea()
//{

// Console.Write("Ange längden av basen: ");
// if (!double.TryParse(Console.ReadLine(), out double baseLength))
//{
//   Console.WriteLine("Ogiltig inmatning för basen.");
//  return;
// }


// Console.Write("Ange höjden: ");
//if (!double.TryParse(Console.ReadLine(), out double height))
//{
//   Console.WriteLine("Ogiltig inmatning för höjden.");
//  return;
//}


// double area = (baseLength * height) / 2;


//Console.WriteLine($"Arean av den rätvinkliga triangeln är: {area}");
// Console.ReadLine();
//}
//}




















//using System;

//class Program
//{
// static void Main(string[] ags)
// {

// Console.WriteLine("Resultat av kvadraten är: " + Square());
// Console.WriteLine("Resultat av multiplikationen är: " + Multi());
// Console.WriteLine("Arean av triangeln är: " + RightTriangleArea());


// Console.WriteLine("\nTryck på Enter för att avsluta.");
//Console.ReadLine();
// }

//static double Square()
// {

// Console.Write("Ange ett tal för att beräkna kvadraten: ");
// if (!double.TryParse(Console.ReadLine(), out double number))
//  {
//   Console.WriteLine("Ogiltig inmatning. Returnerar 0.");
//   return 0;
// }


//     return number * number;
// }

// static double Multi()
// {

// Console.Write("Ange första talet: ");
// if (!double.TryParse(Console.ReadLine(), out double number1))
// {
//  Console.WriteLine("Ogiltig inmatning. Returnerar 0.");
//    return 0;
// }


// Console.Write("Ange andra talet: ");
// if (!double.TryParse(Console.ReadLine(), out double number2))
//{
//    Console.WriteLine("Ogiltig inmatning. Returnerar 0.");
//  return 0;
// }


// return number1 * number2;
//}

//static double RightTriangleArea()
// {

//  Console.Write("Ange längden av basen: ");
// if (!double.TryParse(Console.ReadLine(), out double baseLength))
//{
//   Console.WriteLine("Ogiltig inmatning. Returnerar 0.");
//  return 0;
// }


//  Console.Write("Ange höjden: ");
//  if (!double.TryParse(Console.ReadLine(), out double height))
//  {
//      Console.WriteLine("Ogiltig inmatning. Returnerar 0.");
//      return 0;
//  }

//Console.ReadLine();
//  return (baseLength * height) / 2;

// }
//}






















//using System;

//class Program
//{
// static void Main(string[] args)
// {

// double number = GetNumberInput();
// Console.WriteLine($"Du angav siffran: {number}");

// Console.WriteLine("Tryck på Enter för att avsluta programmet.");
//Console.ReadLine();
//}

// static double GetNumberInput()
// {
//  double number;
// while (true)
// {
//  Console.Write("Ange en siffra: ");
//  string? input = Console.ReadLine(); // Tillåt nullable inmatning

// if (!string.IsNullOrEmpty(input) && double.TryParse(input, out number))
// {
//   return number; // Returnera siffran om allt är korrekt
// }
//else
//{
//  Console.WriteLine("Ogiltig inmatning. Var vänlig ange en giltig siffra.");
// }
// }
//  }
//}

















//using System;

//class Program
//{
   // static void Main(string[] args)
    //{
      
       // Console.WriteLine("Kvadraten av talet är: " + Square());
        //Console.WriteLine("Produkten av två tal är: " + Multi());
       // Console.WriteLine("Arean av triangeln är: " + RightTriangleArea());

        
       // Console.WriteLine("Tryck på Enter för att avsluta programmet.");
        //Console.ReadLine();
//    }

   // static double GetNumberInput()
  //      double number;
       // while (true)
       // {
        //    Console.Write("Ange en siffra: ");
        //    string? input = Console.ReadLine(); 

           
         //   if (!string.IsNullOrEmpty(input) && double.TryParse(input, out number))
        //    {
              //  return number; 
       //     }
        //    else
       //     {
        //        Console.WriteLine("Ogiltig inmatning. Var vänlig ange en giltig siffra.");
        //    }
       // }
   // }

   // static double Square()
   // {
    //    Console.WriteLine("Du valde att beräkna kvadraten av ett tal.");
      //  double number = GetNumberInput(); 
     //   return number * number;
  //  }

  //  static double Multi()
  //  {
   //     Console.WriteLine("Du valde att multiplicera två tal.");
    //    Console.WriteLine("Ange det första talet:");
    //    double number1 = GetNumberInput(); 

    //    Console.WriteLine("Ange det andra talet:");
    //    double number2 = GetNumberInput(); 

    //    return number1 * number2;
    //}

   // static double RightTriangleArea()
  //  {
    //    Console.WriteLine("Du valde att beräkna arean av en rätvinklig triangel.");
    //    Console.WriteLine("Ange längden av basen:");
    //    double baseLength = GetNumberInput(); 

    //    Console.WriteLine("Ange höjden:");
    //    double height = GetNumberInput(); 

     //   return (baseLength * height) / 2;
   // }
//}
