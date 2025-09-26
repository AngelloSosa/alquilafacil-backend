namespace AlquilaFacilPlatform.Metrics.Interfaces.REST.Resources;

public record CreateMetricResource(string EventName, int UserId, string SessionId);