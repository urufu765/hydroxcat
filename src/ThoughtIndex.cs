namespace HydroxCat
{
    public class ThoughtIndex : ExtEnum<ThoughtIndex>
    {
        public static readonly ThoughtIndex Idle = new("Idle", true);  // When doing nothing. May or many not dance.
        public static readonly ThoughtIndex FollowingOrder = new("FollowingOrder", true);  // When scug is given orders and has not spotted any object or point of interest.

        public static readonly ThoughtIndex MonsterNearby = new("MonsterNearby", true);  // In this state, the AI determines there's a bad guy nearby
        public static readonly ThoughtIndex DeathpitNearby = new("DeathpitNearby", true);  // In this state, the AI has determined there is a deathpit that must be crossed. Stop if there's no platform to jump to (max distance range achieved by pouncing distance but does not necessarily check if there's sufficient room to roll or slide yet.)
        public static readonly ThoughtIndex ClimbablePoleNearby = new("ClimbablePoleNearby", true);
        public static readonly ThoughtIndex CorridorNearby = new("CorridorNearby", true);
        public static readonly ThoughtIndex NormalFallNearby = new("NormalFallNearby", true);  // In this state, the AI determines if it's able to make the distance simply by falling. If not, check if the distance is makeable by a jump
        public static readonly ThoughtIndex NormalJumpNearby = new("NormalJumpNearby", true);  // In this state the AI determines it's able to make the distance with a normal jump. If not, check if the distance is makeable by a long jump.
        public static readonly ThoughtIndex LongJumpNearby = new("LongJumpNearby", true);  // In this state the AI determines it's able to do a long jump (if not, try looking for a pounceable distance)
        public static readonly ThoughtIndex PounceNearby = new("PounceNearby", true);  // In this state the AI figures out it's able to make a jump by a rollpounce or a slidepounce.
        public static readonly ThoughtIndex FoodNearby = new("FoodNearby", true);  // Food eat. Determine if food is simply reachable. If not, attempt to check if it's in jumping distance.
        public static readonly ThoughtIndex FriendlyNearby = new("FriendlyNearby", true);  // In this state the AI determines it should probably not throw the weapons so eagerly if there's a friendly between the enemy and the scug

        public static readonly ThoughtIndex BreakFall = new("BreakFall", true);  // If the AI determines they've been falling for enough distance, and is not in risk of rolling off the cliff, they'll break the fall with a roll

        public static readonly ThoughtIndex RainPanic = new("RainPanic", true);  // In this state the AI is in panic and will ignore the player's attempt at being smart. They will panic and try to run to a shelter, ignoring the fact there might be a deathpit
        public static readonly ThoughtIndex NoDefPanic = new("NoDefensePanic", true);  // In this state, the AI is in a state of panic from engaging an enemy with no ways to defend themselves. they will ignore the player's attack command and may grab things by random.

        public ThoughtIndex(string 값, bool register = false)
        : base (값, register){
        }
    }
}