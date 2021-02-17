using System;

// A Record is a fancy class.
// Records are immutable (readonly)- the value cannot be changed.

namespace UnderstandingRecords
{
    public record Record1(string FirstName, string LastName);
    public class Class1
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public Class1(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}