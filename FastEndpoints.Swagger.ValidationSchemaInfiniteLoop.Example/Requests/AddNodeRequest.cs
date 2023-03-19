namespace FastEndpoints.Swagger.ValidationSchemaInfiniteLoop.Example.Requests;

public record AddNodeRequest(string Name, AddNodeRequest[] Nodes);