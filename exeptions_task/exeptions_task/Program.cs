using exeptions_task;
using exeptions_task.Exeptions;

namespace code_task
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                User user1 = new User("kamal", "kamal@gmail.com", "HalaMadrid2006", 1);

                user1.ShowInfo();
            }
            catch (IncorrectPaswordException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}