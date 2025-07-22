
namespace ChallengeFocare1
{
    public class Client
    {
        public int Age { get; set; }
        public string Sexy { get; set; }

        public Client(int age, string sexy)
        {
            Age = age;
            Sexy = sexy.ToUpper();
        }
    }
}
