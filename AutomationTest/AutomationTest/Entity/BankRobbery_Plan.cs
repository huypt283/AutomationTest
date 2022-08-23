using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTest.Entity
{
    public class BankRobbery_Plan
    {
        public int id { get; set; }

        public int? location { get; set; }

        public int? team { get; set; }

        public decimal? expected_revenue { get; set; }

        public DateTime? time { get; set; }

    }

}