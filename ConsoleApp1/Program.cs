using Core.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Blog blog = new Blog();


            while (true)
            {

               
                Console.WriteLine("1. Blog yarat");
                Console.WriteLine("2. Comment yarat");
                Console.WriteLine("3. Commentlərə bax");
                Console.WriteLine("4. Commentə bax");
                Console.WriteLine("5. Commenti sil");
                Console.WriteLine("6. Commenti dəyiş (update)");
                Console.WriteLine("0. Proqramdan çıx");

                Console.WriteLine("\nSecim edin!");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nYeni blog yaradın:");
                        Console.Write("Title  daxil edin: ");
                        string title = Console.ReadLine();

                        bool isTitle = Helper.CheckBlogTitle(title);

                        Console.Write("Description daxil edin: ");
                        string description = Console.ReadLine();

                        bool isDescription = Helper.CheckBlogDescription(description);
                        if (isTitle && isDescription)
                        {
                            Console.WriteLine("Başlıq ve tesvir uyğun olaraq daxil edildi.");
                        }
                        else
                        {
                            Console.WriteLine("Başlıq və ya təsvir uyğun deyil. Başlıq minimum 5 simvoldan, tesvir minimum 8 simvoldan ibaret olmalıdır.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nComment yaradin:");
                        Console.Write("Comment daxil edin: ");
                        string content = Console.ReadLine();

                        Comment newComment = new Comment(content);
                        blog.AddComment(newComment);

                        Console.WriteLine("Yeni comment əlavə olundu!");
                        break;
                        
                }


            }

        }
    }
}
