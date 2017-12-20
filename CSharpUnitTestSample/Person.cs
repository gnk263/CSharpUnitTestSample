namespace CSharpUnitTestSample
{
    public class Person
    {
        private string _firstName = "Yamada";
        private string _lastName = "Takeshi";

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    _lastName = value;
            }
        }

        public string FullName() => $"{FirstName} {LastName}";
    }
}