namespace C_Sharp_NewFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Display("Hitendra", "Kumar");
            System.Tuple<int, string> info = GetInfo("X1");
            var info1 = GetInfo1("X");
            (int age, string name) info3 = GetInfo3("X1");
            (int age, string name) info4 = GetInfo4("X1");
            System.Console.WriteLine($"Name: {info.Item2} Age: {info.Item1}");
            System.Console.WriteLine($"Name: {info1.name} Age: {info1.age}");
            System.Console.WriteLine($"Name: {info3.name} Age: {info3.age}");
            System.Console.WriteLine($"Name: {info4.name} Age: {info4.age}");
            System.Console.Read();
        }

        public static string Test() => "test";
        public static void Display(string fname, string lname) => System.Console.WriteLine($"My name is {fname} {lname}");

        public static System.Tuple<int, string> GetInfo(string id) => new System.Tuple<int, string>(36, "Hitendra");

        public static (int age, string name) GetInfo1(string id) => (36, "Hitendra");

        public static (int, string) GetInfo2(string id) => (36, "Hitendra");

        public static (int, string) GetInfo3(string id) => (age: 36, name: "Hitendra");

        public static (int age, string name) GetInfo4(string id) => (age: 36, name: "Hitendra");
    }


}
