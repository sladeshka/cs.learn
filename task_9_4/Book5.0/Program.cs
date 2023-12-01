namespace Book5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = {
                new("Harper Lee", "To Kill a Mockingbird", 281, 1960),
                new("F. Scott Fitzgerald", "The Great Gatsby", 208, 1925)
            };
            // Console.WriteLine("\n Polymorphism testing");
            //Item item = new Item();
            //item = books[0];
            //item.Take();
            //item.Return();
            //Console.WriteLine(item);
            //item = books[1];
            //item.Take();
            //item.Return();
            //Console.WriteLine(item);

            Magazine magazine = new Magazine("About nature", 5, "Earth and us", 2014, 1235, true);
            magazine.Take();
            Console.WriteLine(magazine);
            magazine.isSubscription = true;
            Console.WriteLine($"Magazine subscription {magazine.subscription().title} {magazine.subscription().isSubscription}");
        }
    }
}