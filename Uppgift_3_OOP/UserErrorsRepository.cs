using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3_OOP
{
    //3.4.7 I program.cs Main-metod: Skapa en lista med UserErrors och populera den med instanser av NumericInputError och TextInputError.
    internal static class UserErrorsRepository
    {

        internal static List<UserError> RetrieveErrors()
        {
            return new List<UserError>()
            {
                new NumericInputError(),
                new TextInputError(),
                new NumericInputError(),
                new TextInputError(),
                new NumericInputError(),
                new TextInputError(),
                new NumericInputError(),
                new TextInputError(),
                new NumericInputError(),
                new TextInputError(),
                new NumericInputError(),
                new TextInputError()
            };
        }
    }
}
