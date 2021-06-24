using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegister
{
    public class InvalidInputError : UserError
    {
        public string UEMessage(bool isValid)
        {
            string output;
            if (!isValid)
                output = "Your input is invalid!";
            else
                output = "Valid input!";

            return output;
        }

        public override string UEMessage()
        {
            return "This is invalid input error message.";
        }
    }
}
