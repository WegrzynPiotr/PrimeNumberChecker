namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            render();    
        }

        static void render()
        {  
        while(true)
            {
                var number = getNumber();        
                Console.WriteLine(checkNumber(number));
            }
        }

        static int getNumber()
        {
            Console.WriteLine("\n\n-----Wpisz liczbę-----\n");
            if(!int.TryParse(Console.ReadLine(), out var number)) return 0;
            Console.WriteLine();
            return number;
        }
        static string checkNumber(int inputValue,int i=2) {
            string result = "";
            if (inputValue <=1) return "Możesz użyć tylko cyfr z zakresu 2-9";
            if (inputValue % i != 0 && inputValue>i)
                return checkNumber(inputValue,i+1);
            else
            {
                result = inputValue.ToString();
                result += inputValue ==i ? " to liczba pierwsza": " nie jest liczbą pierwsza";
                result += "\n";
            }
            return result;
        }
    }
}