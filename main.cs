using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter Salesperson's name");
    Console.ReadLine();
    Console.WriteLine("Enter sales amount");
    double sa = Convert.ToDouble
    (Console.ReadLine());

    double sc = 200+ (0.09*sa);

    Console.WriteLine("Sales Commission is $" +   sc);

    if (sc>= 0 && sc<= 2999)
    Console.WriteLine("performance is poor");

    if (sc>= 3000 && sc<= 4999)
    Console.WriteLine("performance is average");

    if (sc>= 5000 && sc<= 9999)
    Console.WriteLine("performance is good");

    if (sc>= 10000 && sc<= 14999)
    Console.WriteLine("performance is excellent");

    if (sc>= 15000)
    Console.WriteLine("performance is outstanding");





    



  }
}