namespace PropertiesExample
{
    class Student : Person
    {
        private string code = "N.A";
        private string name = "N.A";
        private int age = 0;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public override int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return "\nCode => " + Code + ",\nName => " + Name + ",\nAge => " + Age;
        }

    }
}
