using SOC.DataContracts.Models;

namespace SOC.DataContracts.Response
{
    public class PersonBanResponse : BaseModelResponse
    {
        public bool Active { get; set; }

        public DateTime? ActiveUntil { get; set; }

        public string Reason { get; set; } = null!;

        public Guid PersonId { get; set; }

        public static explicit operator PersonBanResponse(PersonBan pb)
        {
            return new()
            {
                Id = pb.Id,
                Active = pb.Active,
                ActiveUntil = pb.ActiveUntil,
                Reason = pb.Reason,
                PersonId = pb.PersonId,
                DateCreated = pb.DateCreated,
                DateModified = pb.DateModified
            };
        }
    }
}