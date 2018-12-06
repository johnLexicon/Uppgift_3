using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3_OOP
{
    //3.4.3 Skapa en vanlig klass NumericInputError som ärver från UserError
    class NumericInputError : UserError
    {
        // 3.4.4 Skriv en override för UEMessage() så att den returerar “You tried to use a numeric input in a text only field.This fired an error!”
        public override string UEMessage() => "You tried to use a numeric input in a text only field.This fired an error!";

    }
}
