using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;

namespace WcfServiceExample.PeopleService.Security.Validators
{

    public class PasswordValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName != password)
            {
                throw new SecurityTokenException();
            }
        }
    }
}
