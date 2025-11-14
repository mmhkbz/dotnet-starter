namespace Basic.API.Config;

public class MaterialThemeSettings
{
    public const string SectionName = "MaterialTheme";
    
    public ColorMode Mode { get; set; } = ColorMode.Default;
}

public enum ColorMode
{
    Default,
    Primary,
    Secondary,
    Success,
    Warning,
    Danger,
    Info
}
