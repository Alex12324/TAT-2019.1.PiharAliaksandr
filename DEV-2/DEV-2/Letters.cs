

namespace DEV_2
{
    /// <summary>
    /// My letter class.
    /// </summary>
    public class Letters
    {
        public string Current { get; set; }
        public string Next { get; set; }
        public string Prev { get; set; }
        public Letters() { }
        public Letters(string prev, string current, string next)
        {
            this.Current = current;
            this.Next = next;
            this.Prev = prev;
        }
    }
}
