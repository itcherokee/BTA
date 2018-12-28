namespace BTA.Core.Domain.Orgaization
{
    using BTA.Core.Domain.Base;

    public class Employee : Person
    {
        public Address HomeAddress { get; set; }

        public string Position { get; set; }

        public BusinessUnit BusinessUnit { get; set; }

        public Department Department { get; set; }

        public Employee Manager { get; set; }

        public string Notes { get; set; }
    }
}