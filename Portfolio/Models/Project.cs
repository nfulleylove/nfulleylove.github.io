namespace Portfolio.Models;

public class Project
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public string Company { get; set; } = "";
    public IEnumerable<string> Technologies { get; set; } = Array.Empty<string>();
    public string? Href { get; set; }
    public bool IsFeatured { get; set; }

    public string Dates => $"{StartDate.Year} - {EndDate?.Year.ToString() ?? "Present"}";
    public bool HasLink => !string.IsNullOrEmpty(Href);
}
