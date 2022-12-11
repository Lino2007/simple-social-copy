using SOC.DataContracts.Models;

namespace SOC.DataContracts.Response
{
    public class UserRoleResponse : BaseModelResponse
    {
        public Guid PersonId { get; set; }

        public Guid RoleId { get; set; }

        public static explicit operator UserRoleResponse(UserRole ur)
        {
            return new()
            {
                Id = ur.Id,
                PersonId = ur.PersonId,
                RoleId = ur.RoleId,
                DateCreated = ur.DateCreated,
                DateModified = ur.DateModified
            };
        }
    }
}