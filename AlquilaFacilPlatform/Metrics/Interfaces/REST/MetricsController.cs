using System.Net.Mime;
using AlquilaFacilPlatform.Metrics.Domain.Service;
using AlquilaFacilPlatform.Metrics.Interfaces.REST.Resources;
using AlquilaFacilPlatform.Metrics.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;

namespace AlquilaFacilPlatform.Metrics.Interfaces.REST;


[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class MetricsController(IMetricCommandService metricCommandService): ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateMetric([FromBody] CreateMetricResource resource)
    {
        var command = CreateMetricCommandFromResourceAssembler.ToCommandFromResource(resource);
        var metric = await metricCommandService.Handle(command);
        if (metric is null) return BadRequest();
        var metricResource = MetricResourceFromEntityAssembler.ToResourceFromEntity(metric);
        return Ok(metricResource);
    }
}

