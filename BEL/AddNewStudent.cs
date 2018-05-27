﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Enums;
using DAL;

namespace BAL
{
    public class AddNewStudent
    {
        AddData ad = new AddData();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City{ get; set; }
        public Counties County { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public AddNewStudent(string fname, string lname, string address1, string address2,  string city, Counties county, string email, string phone)
        {
            FirstName = fname;
            LastName = lname;
            AddressLine1 = address1;
            AddressLine2 = address2;
            City = city;
            County = county;
            Email = email;
            Phone = phone;
        }

        public void AddStudentToDb()
        {
            ad.AddNewStudent(FirstName, LastName, AddressLine1, AddressLine2, City, County.ToString(), Email, Phone);
        }

    }
}