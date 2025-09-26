using AlquilaFacilPlatform.Metrics.Domain.Model.Commands;
using AlquilaFacilPlatform.Metrics.Domain.Model.Entities;

namespace AlquilaFacilPlatform.Metrics.Domain.Service;

public interface IMetricCommandService
{
    Task<Metric?> Handle(CreateMetricCommand command);
}