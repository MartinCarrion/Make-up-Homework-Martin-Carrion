//Martin Carrion
//    MIS 3033
//    Makeup Homework
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class CastingVote
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Vote { get; set; }

        public CastingVote()
        {
            Firstname = "";
            Lastname = "";
            Email = "";
            Gender = "";
            Vote="";

        }
        public CastingVote(string firstname, string lastname, string email, string gender, string vote)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Gender = gender;
            Vote=vote;


        }

        

        public override string ToString()
        {
            string employeeAsString = $"{Firstname}, {Lastname} {Gender.ToUpper()[0]} has an email of {Email} and has Voted {Vote} ";
            return employeeAsString;
        }





    }
}
