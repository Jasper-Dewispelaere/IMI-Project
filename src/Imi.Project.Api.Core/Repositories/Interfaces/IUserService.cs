using Imi.Project.Api.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Repositories.Interfaces
{
    public interface IUserService
    {
        Task<AuthenticateResultModel> RegisterAsync(RegisterModel registerModel);
        Task<AuthenticateResultModel> LoginAsync(LoginModel loginModel);
    }
}
