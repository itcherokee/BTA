namespace BTA.Core.Domain.Base
{
    using System;

    public abstract class Person : BaseModel<string>
    {
        public string FirstNameEng { get; set; }

        public string MiddleNameEng { get; set; }

        public string LastNameEng { get; set; }

        public string FirstnameLocal { get; set; }

        public string MiddleNameLocal { get; set; }

        public string LastNameLocal { get; set; }

        public DateTime? BirthDate { get; set; }

        public int MyProperty { get; set; }
    }
}