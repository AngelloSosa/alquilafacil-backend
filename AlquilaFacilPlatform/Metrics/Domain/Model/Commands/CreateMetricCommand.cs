namespace AlquilaFacilPlatform.Metrics.Domain.Model.Commands;

public record CreateMetricCommand(string EventName, int UserId, string SessionId);