using System;

namespace Sprint01Library
{
    public class MyAccessModifiers
    {
        public static byte averageMiddleAge = 50;
        private int birthYear;
        private protected string IdNumber;
        protected string personalInfo;
        public int Age => DateTime.Now.Year - birthYear;
        internal string Name { get; set; }
        public string NickName { get; internal set; }

        public MyAccessModifiers(int birthYear, string idNumber, string personalInfo)
        {
            this.birthYear = birthYear;
            IdNumber = idNumber;
            this.personalInfo = personalInfo;
        }

        protected internal void HasLivedHalfOfLife() { }

        public override bool Equals(object obj)
            => obj is MyAccessModifiers modifiers
            && birthYear == modifiers.birthYear
            && IdNumber == modifiers.IdNumber
            && personalInfo == modifiers.personalInfo
            && Age == modifiers.Age
            && Name == modifiers.Name
            && NickName == modifiers.NickName;

        public override int GetHashCode()
            => HashCode.Combine(birthYear, IdNumber, personalInfo, Age, Name, NickName);

        public static bool operator ==(MyAccessModifiers left, MyAccessModifiers right)
            => left.Name.Equals(right.Name)
            && left.Age == right.Age
            && left.personalInfo.Equals(right.personalInfo);

        public static bool operator !=(MyAccessModifiers left, MyAccessModifiers right)
            => !(left == right);
    }
}
