using FastEndpoints.Swagger.ValidationSchemaInfiniteLoop.Example.Requests;

namespace FastEndpoints.Swagger.ValidationSchemaInfiniteLoop.Example.Endpoints;

public class AddNodeEndpoint : Endpoint<AddNodeRequest>
{
    public override void Configure()
    {
        AllowAnonymous();
        Post("/api/nodes");
    }

    public override async Task HandleAsync(AddNodeRequest req, CancellationToken ct)
    {
        await Task.Delay(1000, ct);

        await SendAsync("done", cancellation: ct);
    }
}