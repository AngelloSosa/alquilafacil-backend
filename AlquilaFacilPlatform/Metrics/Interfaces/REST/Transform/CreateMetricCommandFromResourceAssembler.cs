using AlquilaFacilPlatform.Metrics.Domain.Model.Commands;
using AlquilaFacilPlatform.Metrics.Interfaces.REST.Resources;

namespace AlquilaFacilPlatform.Metrics.Interfaces.REST.Transform;

public static class CreateMetricCommandFromResourceAssembler
{
    public static CreateMetricCommand ToCommandFromResource(CreateMetricResource resource)
    {
        return new CreateMetricCommand(
            resource.EventName,
            resource.UserId,
            resource.SessionId
        );
    }
}