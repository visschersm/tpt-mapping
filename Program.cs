using System;
using MTech.TPTMapping;

namespace MTech.TPTMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new AnimalContext();
            context.Cows.Add(new Cow 
            {

            });
        }
    }
}
