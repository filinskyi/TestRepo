namespace Sprint01Library
{
    public class Child : Person
    {
        private string childIDNumber;

        public Child(int yearOfBirth, string name, string healthInfo, string childIDNumber)
            : base(yearOfBirth, name, healthInfo)
        {
            this.childIDNumber = childIDNumber;
        }

        public override string ToString()
            => $"{base.ToString()} {childIDNumber}";
    }
}
