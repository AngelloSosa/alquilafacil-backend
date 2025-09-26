using AlquilaFacilPlatform.Metrics.Domain.Model.Entities;
using AlquilaFacilPlatform.Metrics.Interfaces.REST.Resources;

namespace AlquilaFacilPlatform.Metrics.Interfaces.REST.Transform;

public static class MetricResourceFromEntityAssembler
{
    public static MetricResource ToResourceFromEntity(Metric entity)
    {
        return new MetricResource(
            entity.Id,
            entity.EventName,
            entity.UserId,
            entity.Timestamp,
            entity.SessionId
        );
    }
}