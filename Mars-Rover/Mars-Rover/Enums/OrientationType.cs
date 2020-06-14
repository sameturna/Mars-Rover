
namespace Mars_Rover.Enums
{
    public class OrientationType
    {
        private OrientationType(string value) { Value = value; }

        public string Value { get; set; }

        public static OrientationType North { get { return new OrientationType("N"); } }
        public static OrientationType South { get { return new OrientationType("S"); } }
        public static OrientationType East { get { return new OrientationType("E"); } }
        public static OrientationType West { get { return new OrientationType("W"); } }
    }
}
