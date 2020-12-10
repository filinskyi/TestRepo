namespace Sprint01Library
{
    public class Person
    {
        protected int yearOfBirth;
        protected string healthInfo;
        protected string name;

        public Person(int yearOfBirth, string name, string healthInfo)
        {
            this.yearOfBirth = yearOfBirth;
            this.healthInfo = healthInfo;
            this.name = name;
        }

        internal string GetHealthStatus()
            => name + ": " + yearOfBirth + ". " + healthInfo;

        public override string ToString()
            => name;
    }
}
