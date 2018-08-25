namespace C_Sharp_NewFeatures
{
    interface IInterface { }
    class MyClass : IInterface { }

    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            System.Console.WriteLine($"Name: {p.Myname().FirstName} {p.Myname().LastName}");
            int i = default(int);
            System.Console.WriteLine(i.ToString());
            string s = default(System.String);
            System.Console.WriteLine(s);
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
        // Method Shorthands
        public static string Test() => "test";
        public static void Display(string fname, string lname) => System.Console.WriteLine($"My name is {fname} {lname}");

        public string TestMethod() => "Hello World";

        public float Division(int a, int b) => a / b;

        //Tuples
        public static System.Tuple<int, string> GetInfo(string id) => new System.Tuple<int, string>(36, "Hitendra");

        public static (int age, string name) GetInfo1(string id) => (36, "Hitendra");

        public static (int, string) GetInfo2(string id) => (36, "Hitendra");

        public static (int, string) GetInfo3(string id) => (age: 36, name: "Hitendra");

        public static (int age, string name) GetInfo4(string id) => (age: 36, name: "Hitendra");

        public (string FirstName, string LastName) Myname() => (FirstName: "Hitendra", LastName: "Kumar");
    }


}
