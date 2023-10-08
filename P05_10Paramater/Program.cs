 {
     int Fibonacci(int n)
     {
         //tells the code if its 0 or 1 just give the result 0 or 1
         if (n == 0) return 0;
         if (n == 1) return 1;

         int first = 0;
         int second = 1;


         NextIteration:
         var current = first + second;
         first = second;
         second = current;
         n--;
         if (n > 1)
         {
             goto NextIteration;
         }

         return current;
     }


     Console.WriteLine(Fibonacci(4));

 }
 {
    int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        int first = Fibonacci(n - 2);
        int second = Fibonacci(n - 1);

        return first + second;
    }

    int result = Fibonacci(4);
    Console.WriteLine(result);
    
    
}