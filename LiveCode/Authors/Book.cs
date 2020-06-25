namespace Authors
{
    internal class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public object Type { get; set; }
        public int Nominations { get; set; }
        public int Wins { get; set; }
        public Genre[] Genres { get; set; }
    }
}