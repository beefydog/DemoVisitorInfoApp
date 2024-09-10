namespace DemoVisitorInfoApp.Data;

public class Visit
{
    public int Id { get; set; }
    public DateTime VisitDate { get; set; }
    public DateTime LastVisitDate { get; set; }
    public int TotalVisits { get; set; } = 1;
    public string IPAddress { get; set; } = string.Empty;
    public string Browser { get; set; } = string.Empty;
    public string OperatingSystem { get; set; } = string.Empty;
    public string DeviceType { get; set; } = string.Empty;
    public string ScreenResolution { get; set; } = string.Empty;
    public string ReferrerUrl { get; set; } = string.Empty;
    public string LastReferrerUrl { get; set; } = string.Empty; 
    public string Path { get; set; } = string.Empty; 
    public string LastPath { get; set; } = string.Empty; 
    public string QueryString { get; set; } = string.Empty; 
    public string LastQueryString { get; set; } = string.Empty; 
    public string SessionId { get; set; } = string.Empty;
    public string Cookies { get; set; } = string.Empty;
}