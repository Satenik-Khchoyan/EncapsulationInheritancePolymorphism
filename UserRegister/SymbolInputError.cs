using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegister
{
    public class SymbolInputError : UserError
    {
        public override string UEMessage()
        {
            return "You can't use this symbol in your text.";
        }

        public string UEMessage(string symbol)
        {
            string output;
            //if (symbol.Equals("+"))
            //    output = "Error";
            //else
            //    output = "Ok";

            output = symbol.Equals("+") ? "Error" : "Ok";
            return output;

        }
    }
}
