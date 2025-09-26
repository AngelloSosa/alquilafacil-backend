namespace AlquilaFacilPlatform.Metrics.Interfaces.REST.Resources;

public record MetricResource(int Id, string EventName, int UserId, DateTime Timestamp, string SessionId);