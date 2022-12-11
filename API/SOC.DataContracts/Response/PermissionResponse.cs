using SOC.DataContracts.Models;

namespace SOC.DataContracts.Response
{
    public class PermissionResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public static explicit operator PermissionResponse(Permission p)
        {
            return new()
            {
                Id = p.Id,
                Name = p.Name,
            };
        }
    }
}