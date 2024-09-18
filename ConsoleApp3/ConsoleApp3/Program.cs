// See https://aka.ms/new-console-template for more information
/*namespace Task_1{
    public class Calculator{
        public double Calculate(double a, double b,string operation){
            switch(operation){
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    if (b != 0){
                        return a/b;
                    }
                    else{
                        return 0;
                    }
                default:
                    return 0;
            }
        }
    }
    public class Program{
        public static void Main(string[] args){
            Calculator calc = new Calculator();
            double result  = calc.Calculate(2,2,"+");
            Console.WriteLine($"Result : {result}");
        }
    }
}*/
/*namespace Task2{
    public class Number{
        public bool is_prime(int num){
            bool is_number_prime = true;
            int counter = 2;
            while (counter <= num/2){
                if (num % counter == 0){
                    is_number_prime = false;
                    break;
                } 
                counter ++;
            }
            return is_number_prime;
        }
    }
    class Program{
        public static void Main(string[] args){
            Number n = new Number();
            bool result = n.is_prime(5);
            Console.WriteLine($"is digit prime:{result}");
        }
    }
}*/

/*namespace Task3{
    public class Converter{
        public double converting(double count, string source, string target){
            switch(source){
                case "uah":
                    switch (target){
                        case "usd":
                            return count/41.5;
                        case "eur":
                            return count/46.2;
                        default:
                            return 0;
                    }
                case "usd":
                    switch (target){
                        case "uah":
                            return 41.5*count;
                        case "eur":
                            return 41.5*count/(46.2*count);
                        default:
                            return 0;
                    }
                case "eur":
                    switch (target){
                        case "uah":
                            return 46.2*count;
                    case "eur":
                        return 46.2*count/(41.5*count);
                    default:
                        return 0;}
                default:
                    return 0;
            }
        }
    }
    class Program{
        static void Main(string[] args){
            Converter c = new Converter();
            double result = c.converting(12,"usd","uah");
            Console.WriteLine(result); 
        }
    }
}*/

/*namespace Task4{
    class less_and_biggest{
        public string MinMax(double[] arr){
            int counter = 0;
            double max = arr[0];
            while (counter < arr.Length){
                if (arr[counter] > max){
                    max = arr[counter];
                    counter++;
                }
            }
            double min = max;
            for(int i = 0; i < arr.Length; i++){
                if (arr[i] < min){
                    min = arr[i];
                }
            }
            return $"Min: {min}\nMax:{max}";
        }
    }
    class Program{
        static void Main(string[] args){
            double[] arr1 = {1,2,3,4,5,6,311,12.12,223};
            less_and_biggest min_max = new less_and_biggest();
            string result = min_max.MinMax(arr1);
            Console.WriteLine(result);
        }
    }
}*/

/*namespace Task5{
    class Counter{
        public int vovels_counter(string input){
            char[] vovels = {'a', 'e', 'u', 'i', 'o', 'A', 'E', 'U', 'I', 'O'};
            int counter = 0;
            foreach (char letter in input){
                if (vovels.Contains(letter)){
                    counter ++;
                }
            }
            return counter;
        }
    }
    class Program{
        static void Main(string[] args){
            Counter count = new Counter();
            int result = count.vovels_counter("hello");
            Console.WriteLine(result);
        }
    }
}*/


/*namespace Task6{
    class GeometricCalc{
        public double calc(string shape, double[] sides){
            
            switch (shape.ToLower()){
                case "circle":
                    return (sides[0]*sides[0])*Math.PI;
                case "rectangle":
                    return sides[0]*sides[1];
                case "cube":
                    return 6*(sides[0]*sides[0]);
                default:
                    return 0;
            }
        }
    }
    class Program{
        static void Main(string[] args){
            double[] sides = {10,10};
            GeometricCalc calculator = new GeometricCalc();
            double result = calculator.calc("rectangle",sides);
            Console.WriteLine(result);
            
        }
    }
}*/

