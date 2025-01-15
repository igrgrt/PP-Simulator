using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Simulator._1
{
    public class Elf : Creature
    {

        private int agility;
        public int Agility
        {
            get => agility;
            set => agility = Validator.Limiter(value, 0, 10);
        }

        public Elf(string name, int level = 1, int agility = 1) : base(name, level)
        {
            Agility = agility;
        }

        public Elf() : base()
        {

        }

        private int singCounter = 0;
        public string Sing() => "The elf is singing.";

        public override int Power => (8 * Level) + (2 * Agility);
        public override string Greeting() => $"Hi, I'm {Name}, my level is {Level}, my agility is {Agility}.";
        public override string Info => $"{Name} [{Level}][{Agility}]";

    }
}
