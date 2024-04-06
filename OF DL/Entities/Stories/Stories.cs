﻿using Newtonsoft.Json;

namespace OF_DL.Entities.Stories
{
    public class Stories
    {
        public int id { get; set; }
        public int userId { get; set; }
        public bool isWatched { get; set; }
        public bool isReady { get; set; }
        public List<Medium> media { get; set; }
        public DateTime createdAt { get; set; }
        public object question { get; set; }
        public bool canLike { get; set; }
        public bool isLiked { get; set; }
        public class Files
        {
            public Source source { get; set; }
            public Thumb thumb { get; set; }
            public Preview preview { get; set; }
            public SquarePreview squarePreview { get; set; }
        }

        public class Medium
        {
            public long id { get; set; }
            public string type { get; set; }
            public bool convertedToVideo { get; set; }
            public bool canView { get; set; }
            public bool hasError { get; set; }
            public DateTime createdAt { get; set; }
            public Files files { get; set; }
        }

        public class Preview
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int size { get; set; }
            public Sources sources { get; set; }
        }

        public class Source
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int duration { get; set; }
            public int size { get; set; }
            public Sources sources { get; set; }
        }

        public class Sources
        {
            [JsonProperty("720")]
            public object _720 { get; set; }

            [JsonProperty("240")]
            public object _240 { get; set; }
            public string w150 { get; set; }
            public string w480 { get; set; }
        }

        public class SquarePreview
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int size { get; set; }
            public Sources sources { get; set; }
        }

        public class Thumb
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int size { get; set; }
        }
    }
}
