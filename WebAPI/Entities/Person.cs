﻿namespace WebAPI.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public BDFormat BirthDate { get; set; }

    }

    public class BDFormat
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }
}