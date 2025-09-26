using AlquilaFacilPlatform.Metrics.Domain.Model.Commands;

namespace AlquilaFacilPlatform.Metrics.Domain.Model.Entities;

public class Metric
{

    public Metric()
    {
        EventName = string.Empty;
        EventName = string.Empty;
        Timestamp = DateTime.UtcNow;
    }

    public Metric(CreateMetricCommand command)
    {
        EventName = command.EventName;
        UserId = command.UserId;
        SessionId = command.SessionId;
        Timestamp = DateTime.UtcNow;
    }
    
    public int Id { get; private set; }
    public string EventName { get; private set; }
    public int UserId { get; private set; }
    public DateTime Timestamp { get; private set; }
    public string SessionId { get; private set; }
}