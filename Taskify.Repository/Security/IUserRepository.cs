using Meteors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskify.DataTransferObjects;

namespace Taskify.Repositories.Security
{
    public interface IUserRepository
    {
        Task<OperationResult<GetLogInDto>> SignUp(SignUpDto dto);
        Task<OperationResult<GetLogInDto>> LogIn(LogInDto dto);
        Task<OperationResult<TokenDto>> RefreshToken(Guid id, string refreshToken);
        Task<OperationResult<bool>> ForgetPassword(string email);
        Task<OperationResult<GetLogInDto>> ResetPassword(ResetPasswordDto dto);
        Task<OperationResult<bool>> Block(Guid id);
        Task<OperationResult<bool>> UnBlock(Guid id);
    }
}
