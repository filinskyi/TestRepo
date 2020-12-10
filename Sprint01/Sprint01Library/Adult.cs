namespace Sprint01Library
{
    public class Adult : Person
    {
        private string passportNumber;

        public Adult(int yearOfBirth, string name, string healthInfo, string passportNumber)
            : base(yearOfBirth, name, healthInfo)
        {
            this.passportNumber = passportNumber;
        }

        public override string ToString()
            => $"{base.ToString()} {passportNumber }";
    }
}
