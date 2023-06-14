namespace HydroxCat
{
    public class ActionIndex : ExtEnum<ActionIndex>
    {
        public static readonly ActionIndex None = new("None", true);  // Rest.

        public static readonly ActionIndex NormalMove = new("NormalMove", true);  // Movin around in normal places
        public static readonly ActionIndex SwimMove = new("SwimMove", true);  // Swimmin around in watery places
        public static readonly ActionIndex ZeroGMove = new("ZeroGMove", true);  // Swimmin around in no gravity
        public static readonly ActionIndex AttackMove = new("AttackMove", true);  // Go towards attack target
        public static readonly ActionIndex GrabMove = new("GrabMove", true);  // Go towards grabby target

        public static readonly ActionIndex AttackInRange = new("AttackInRange", true);  // Attack target when in range
        public static readonly ActionIndex GrabInRange = new("GrabInRange", true);  // Grab target when in range

        public static readonly ActionIndex GrabCursor = new("Fuck", true);  // What if the scug can grab the fucking cursor like some goddamn leech and get carried off?

        public ActionIndex(string 값, bool register = false)
        : base (값, register){
        }
    }

}