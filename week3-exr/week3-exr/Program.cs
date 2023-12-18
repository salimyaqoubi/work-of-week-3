namespace week3_exr
{
    internal class Program
    {
        static string SolvingSumProblem()
        {
            int ArrSize, Target;

            string s = Console.ReadLine();
            // "3 4"
            // "3" "4"

            string[] arr = s.Split(" ");

            ArrSize = int.Parse(arr[0]);
            Target = int.Parse(arr[1]);

            int[] Values = new int[ArrSize];

            //arr values
            //" 3 4 5 6 7 8 "

            s = Console.ReadLine();
            arr = s.Split(" ");

            for (int i = 0; i < ArrSize; i++)
            {
                Values[i] = int.Parse(arr[i]);
                //Console.WriteLine(Values[i]);
                //Values = int.Parse(Console.ReadLine());
            }
            //Values
            bool flag = false;
            for (int i = 0; i < Values.Length - 1; i++)
            {
                for (int j = i + 1; j < ArrSize; j++)
                {
                    if (Values[i] + Values[j] == Target)
                    {
                        Console.WriteLine($"{i + 1} {j + 1}");
                        //flag = true;
                        break;
                    }
                }
            }
            return "";
        }





        static void Main(string[] args)
        {
            SolvingSumProblem();
        }
    }
}