using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegister
{
    public class MandatoryFieldInputError : UserError
    {
        public override string UEMessage()
        {
            return "This field is mandatory and cannot be null!";
        }

        public string UEMessage(string input)
        {
            string output;
            if (input.Equals("Hej"))
                output = "Hej på dig!";
            else
                output = "Ha det så bra!";
            return output;
        }
    }
}
