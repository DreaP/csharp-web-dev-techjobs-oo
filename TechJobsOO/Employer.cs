using System;
namespace TechJobsOO
{
    public class Employer : JobField
    {
        // All commented out code are repeated code!

        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        public Employer()
        {
        //    Id = nextId;
        //    nextId++;
        }

        public Employer(string value) : base(value)
        {
            Value = value;
        }

        //public override bool Equals(object obj)
        //{
        //    return obj is Employer employer &&
        //           Id == employer.Id;
        //}

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        //public override string ToString()
        //{
        //    return Value;
        //}
    }
}
