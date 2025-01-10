using System.Reflection.Metadata.Ecma335;

namespace PP_Simulator._1
{
    public class Birds : Animals
    {

        public bool CanFly { get; set; } = true;

        public Birds(string description, uint size, bool canFly = true) : base(description, size)
        {
            CanFly = canFly;
        }

        public Birds()
        {

        }

        public override string Info
        {
            get
            {
                string flyingAbility = CanFly ? "fly+" : "fly-";
                return $"{Description} ({flyingAbility}) <{Size}>";
            }

        }


    }
}
