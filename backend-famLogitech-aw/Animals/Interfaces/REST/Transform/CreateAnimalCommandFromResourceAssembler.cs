using backend_famLogitech_aw.Animals.Domain.Model.Commands;
using backend_famLogitech_aw.Animals.Interfaces.Resources;

namespace backend_famLogitech_aw.Animals.Interfaces.Transform;

public class CreateAnimalCommandFromResourceAssembler
{
    public static CreateAnimalCommand ToCommandFromResource(CreateAnimalResource resource)
    {
        return new CreateAnimalCommand(resource.Id, resource.Name, resource.Age, resource.Location, resource.HealthState, resource.ShedId);
    }
}