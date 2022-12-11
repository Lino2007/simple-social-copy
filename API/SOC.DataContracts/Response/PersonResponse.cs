using SOC.DataContracts.Models;

namespace SOC.DataContracts.Response
{
    public class PersonResponse : BaseModelResponse
    {
        public string Firstname { get; set; } = null!;

        public string Lastname { get; set; } = null!;

        public string Nickname { get; set; } = null!;

        public string? Bio { get; set; }

        public string Email { get; set; } = null!;

        public string Country { get; set; } = null!;

        public DateTime? DateOfBirth { get; set; }

        public static explicit operator PersonResponse(Person p)
        {
            return new()
            {
                Id = p.Id,
                Firstname = p.Firstname,
                Lastname = p.Lastname,
                Nickname = p.Nickname,
                Bio = p.Bio,
                Email = p.Email,
                Country = p.Country,
                DateOfBirth = p.DateOfBirth,
                DateCreated = p.DateCreated,
                DateModified = p.DateModified
            };
        }
    }
}