namespace backend_famLogitech_aw.Farms.Domain.Model.Commands;

public record CreateFarmCommand(int Id,string FarmName, string Location, string Type, string Infrastructure, string Certificate, string Product);
