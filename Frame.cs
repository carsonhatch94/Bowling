namespace Bowling
{
    public class Frame
    {
        public int FrameNumber { get; set; }
        public int FirstRoll { get; set; } = -1;
        public int SecondRoll { get; set; } = -1;
        public int ThirdRoll { get; set; } = -1;
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
