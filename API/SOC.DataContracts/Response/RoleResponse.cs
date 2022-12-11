using SOC.DataContracts.Models;

namespace SOC.DataContracts.Response
{
    public class RoleResponse : BaseModelResponse
    {
        public string Name { get; set; } = null!;

        public static explicit operator RoleResponse(Role r)
        {
            return new()
            {
                Id = r.Id,
                Name = r.Name,
                DateCreated = r.DateCreated,
                DateModified = r.DateModified
            };
        }
    }
}