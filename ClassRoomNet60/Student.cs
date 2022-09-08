﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Student
    {
        public string Name { get; private set; }
        public int BirthMonth { get; private set; }
        public int BirthDay { get; private set; }


        public Student(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
        }

        

        public string SeasonOfBirth()
        {
            switch (BirthMonth)
            {
                case 12:
                case 1:
                case 2: return "Winter";
                case 3:
                case 4:
                case 5: return "Spring";
                case 6:
                case 7:
                case 8: return "Sommer";
                case 9:
                case 10:
                case 11: return "Autumn";
                default: return "Month not between 1 and 12";
            }
        }

        public override string ToString()
        {
            return $"Student is named {Name} and their birthday is the {BirthDay}/{BirthMonth}";
        }
    }
}
