using AlquilaFacilPlatform.Metrics.Domain.Model.Commands;
using AlquilaFacilPlatform.Metrics.Domain.Model.Entities;
using AlquilaFacilPlatform.Metrics.Domain.Repositories;
using AlquilaFacilPlatform.Metrics.Domain.Service;
using AlquilaFacilPlatform.Shared.Domain.Repositories;

namespace AlquilaFacilPlatform.Metrics.Application.Internal.CommandServices;

public class MetricCommandService(IMetricRepository metricRepository, IUnitOfWork unitOfWork): IMetricCommandService
{
    public async Task<Metric?> Handle(CreateMetricCommand command)
    {
        var metric = new Metric(command);
        await metricRepository.AddAsync(metric);
        await unitOfWork.CompleteAsync();
        return metric;
    }
}