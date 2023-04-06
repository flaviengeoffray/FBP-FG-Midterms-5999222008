﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUP_BMI_Calculator.Model
{
    [Table("BMIResult")]
    public class BMIResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public double BMIScore { get; set; }

        public string BMI_Result { get; set; }

    }
}
