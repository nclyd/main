using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_CourseWork
{
    class MultipleChoice : Question
    {
        private string[] PossibleAns;
        private string Answers;

        public MultipleChoice() : base()
        {
            possibleAns = new string[4];
        }

        public string[] possibleAns { get => PossibleAns; set => PossibleAns = value; }
        public string answers { get => Answers; set => Answers = value; }

        public bool CheckAns(string attemptedAns)
        {
            if (attemptedAns != answers)
            {
                return false;
            }
            else
                return true;
        }
    }
}
