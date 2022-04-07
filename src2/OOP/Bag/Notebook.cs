namespace OOP.Bag
{
    public class Notebook
    {
        public string Name { get; set; }
        public PageType PageType { get; set; }
        public int PageCount { get; set; }
        public Size Size { get; set; }
    }

    public enum PageType
    {
        Line,
        Cell
    }
}