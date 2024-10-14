public class Program {
    static void Main(string[] args) {
        float res;
        float num1 = float.Parse(Console.ReadLine());
        string mid = Console.ReadLine();
        float num2 = float.Parse(Console.ReadLine());

        switch (mid) {
            case "+":
            res = num1 + num2;
            Console.WriteLine( num1  + " + " + num2 + " = " + res);
            break;
            case "-":
            res = num1 - num2;
            Console.WriteLine( num1  + " - " + num2 + " = " + res);
            break;
            case "*":
            res = num1 * num2;
            Console.WriteLine( num1  + " * " + num2 + " = " + res);
            break;
            case "/":
            res = num1 / num2;
            Console.WriteLine( num1  +  " / " + num2 + " = " + res);
            break;
            case "%":
            res = num1 / num2;
            Console.WriteLine( num1  + " % " + num2 + " = " + res);
            break;
        }

    }
}
