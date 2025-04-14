namespace Bowling
{
    public class Frame
    {
        public int FrameNumber { get; set; }
        public int FirstRoll { get; set; }
        public int SecondRoll { get; set; }
        public int FirstBonus { get; set; } = -1;
        public int SecondBonus { get; set; } = -1;
        public bool IsStrike { get; set; }
        public bool IsSpare { get; set; }

        public Frame(int frameNumber)
        {
            this.FrameNumber = frameNumber;
        }
    }
}
