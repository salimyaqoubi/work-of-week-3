namespace week3_day12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook myphone = new PhoneBook(5);
            myphone.addPerson(0, "salim juma", 93662922);
            myphone.addPerson(1, "akram juma", 99418938);
            myphone.addPerson(2, "sami juma", 99528284);


            Console.WriteLine(myphone.GetNumByName("salim juma"));
            Console.WriteLine(myphone["salim juma"]);
            myphone["Nadir juma", true] = 9999;



            myphone.GetAll();

        }
    }
}