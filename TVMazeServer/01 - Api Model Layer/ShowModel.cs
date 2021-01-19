using System;

namespace TVMaze
{
    public class Series
    {
        public int? ID { get; set; }
        public string Url { get; set; }
        public RatingModel? Rating { get; set; }
        public Image? Image { get; set; }
        public string Name { get; set; }
        public string OfficialSite { get; set; }
    }
    public class RatingModel
    {
        public string Average { get; set; }
    }
    public class Image
    {
        public string Medium { get; set; }
        public string Original { get; set; }
    }

    public class FullShow
    {
        public float? Score { get; set; }
        public Show? Show { get; set; }

    }


    public class Show
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public string language { get; set; }
        public string[] generes { get; set; }
        public string status { get; set; }
        public int? runtime { get; set; }
        public string officialSite { get; set; }
        public object schedule { get; set; }
        public RatingModel? rating { get; set; }
        public int? weight { get; set; }
        public object? network { get; set; }
        public object? webChannel { get; set; }
        public object? externals { get; set; }
        public Image? image { get; set; }
        public string summary { get; set; }
        public int? update { get; set; }
        public object? links { get; set; }
    }

}
