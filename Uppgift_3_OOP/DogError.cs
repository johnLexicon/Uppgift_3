namespace Uppgift_3_OOP
{
    //3.4.9 Skapa nu tre egna klasser med tre egna definitioner på UEMessage().
    internal class DogError : UserError
    {
        public override string UEMessage() => "You tried to convert an animal that is not a dog!!!!!!";
    }
}