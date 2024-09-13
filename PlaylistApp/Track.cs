namespace PlaylistApp
{
    public class Track
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public Image TrackImage { get; set; }

        public Track(string title, string artist, Image trackImage)
        {
            this.Title = title;
            this.Artist = artist;
            TrackImage = trackImage;
        }

        public override string ToString()
        {
            return $"{Title}\n" +
                   $"{Artist}";
        }
    }
}
