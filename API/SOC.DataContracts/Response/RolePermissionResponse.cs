using SOC.DataContracts.Models;

namespace SOC.DataContracts.Response
{
    public class RolePermissionResponse : BaseModelResponse
    {
        public Guid PermissionId { get; set; }

        public Guid RoleId { get; set; }

        public static explicit operator RolePermissionResponse(RolePermission rp)
        {
            return new()
            {
                Id = rp.Id,
                PermissionId = rp.PermissionId,
                RoleId = rp.RoleId,
                DateCreated = rp.DateCreated,
                DateModified = rp.DateModified
            };
        }
    }
}