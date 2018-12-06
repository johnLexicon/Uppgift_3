using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3_OOP
{
    //3.4.9 Skapa nu tre egna klasser med tre egna definitioner på UEMessage().
    class BirdError : UserError
    {
        public override string UEMessage() => "You tried to convert an animal that is not a bird";
    }
}
