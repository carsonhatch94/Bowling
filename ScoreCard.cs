namespace Bowling
{
    public class ScoreCard
    {
        public List<Frame> Frames { get; set; }
        public List<int> FrameScores { get; set; }
        public List<int> Rolls { get; set; }
        public int TotalScore { get; set; }

        public bool GameOver { get; set; } = false;

        public ScoreCard()
        {
            Frames = new List<Frame>();
            FrameScores = new List<int>(new int[10]);
            Rolls = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                Frames.Add(new Frame(i));
            }
        }
        public void UpdateTotalScore()
        {
            TotalScore = FrameScores.Sum();
        }
    }
}
