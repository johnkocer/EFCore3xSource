﻿using System;
using System.Collections.Generic;

namespace DatabaseFirstOne2One.EfDbFirstOne2OneModels
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual Address Address { get; set; }
    }
}
