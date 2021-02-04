namespace Study.Log4Net
{
    public class Counter
    {
        public int LoopCounter { get; set; }

        public override string ToString()
        {
            return LoopCounter.ToString();
        }
    }
}