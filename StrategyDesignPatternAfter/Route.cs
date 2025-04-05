





public class Route
{
    public string Title { get; set; } = string.Empty;
    public TimeSpan Duration { get; set; }
    public int DistanceInKM { get; set; }

    public RoutePreference RoutePreference { get; set; }
    public List<string>? Directions { get; set; }

    public override string ToString()
    {
        string formattedDuration = $"{Duration.Hours} hr {Duration.Minutes} min";
        string formattedDistance = $"{DistanceInKM} km";

        string result = RoutePreference.ToString();
        result = $"{Title}\t [{formattedDuration}] ({formattedDistance})\n";

        if (Directions == null || Directions.Count == 0)
        {
            return result;
        }
        foreach (var direction in Directions)
        {
            result += $"   ├ {direction}\n";
        }

        return result;
    }
}
