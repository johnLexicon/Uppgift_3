using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3_OOP
{
    //3.4.4 Skapa en vanlig klass TextInputError som ärver från UserError
    class TextInputError : UserError
    {
        //6. Skriv en override för UEMessage() så att den returerar “You tried to use a text input in a numericonly field.This fired an error!”
        public override string UEMessage() => "You tried to use a text input in a numericonly field.This fired an error!";
    }
}
