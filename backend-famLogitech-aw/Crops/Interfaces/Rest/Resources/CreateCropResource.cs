namespace backend_famLogitech_aw.Crops.Interfaces.Rest.Resources;

public record CreateCropResource(int Id, string Type, string PlantingDate, int Quantity, int ShedId);