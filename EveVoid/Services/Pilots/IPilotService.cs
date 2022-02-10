using EveVoid.Models.Pilots;

namespace EveVoid.Services.Pilots
{
    public interface IPilotService
    {
        Pilot GetPilotById(int id);
    }
}