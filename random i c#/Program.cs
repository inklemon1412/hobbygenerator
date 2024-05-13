namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hobbygeneratoren!");

            while (true)
            {
                Console.WriteLine("Who wants a hobby?");
                var Name = Console.ReadLine();
                Random NewHobby = new Random();
                var randomHobby = NewHobby.Next(0, 5);
                if (randomHobby == 0)
                {
                    Console.WriteLine($"{Name}is now on top of a pony. Good luck!");
                }
                else if (randomHobby == 1)
                {
                    Console.WriteLine($"{Name} loves ballet now. Congrats!");
                }
                else if (randomHobby == 2)
                {
                    Console.WriteLine($"How exciting! {Name} has now picked up a paintbrush and is making the next Mona Lisa!");
                }
                else if (randomHobby == 3)
                {
                    Console.WriteLine($"Let's get this bread, gamers! {Name} is now into gaming");
                }
                else
                {
                    Console.WriteLine($"Check it out! {Name} is now a bookworm");
                }
            }
        }
    }
}
