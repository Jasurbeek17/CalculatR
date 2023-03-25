namespace CalculatR.Classes 
{
    class Security 
    {
        public void CheckPassword() 
        {
            string password = "";

            do
            {
                Console.Write("Enter your password: ");
                password = Console.ReadLine();
            } while (password != "qwerty");
        }
    }
}