
namespace Mars_Rover.Enums
{
    public class InstructionType
    {
        private InstructionType(string value) { Value = value; }

        public string Value { get; set; }

        public static InstructionType Move { get { return new InstructionType("M"); } }
        public static InstructionType TurnLeft { get { return new InstructionType("L"); } }
        public static InstructionType TurnRight { get { return new InstructionType("R"); } }

    }
}

