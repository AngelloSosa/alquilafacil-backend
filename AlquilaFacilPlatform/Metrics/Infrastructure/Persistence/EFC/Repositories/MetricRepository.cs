using AlquilaFacilPlatform.Metrics.Domain.Model.Entities;
using AlquilaFacilPlatform.Metrics.Domain.Repositories;
using AlquilaFacilPlatform.Shared.Infrastructure.Persistence.EFC.Configuration;
using AlquilaFacilPlatform.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace AlquilaFacilPlatform.Metrics.Infrastructure.Persistence.EFC.Repositories;

public class MetricRepository(AppDbContext context): BaseRepository<Metric>(context), IMetricRepository
{
    
}