using Meteors;
using Taskify.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskify.DataTransferObjects;
using Taskify.DataSource;
using Microsoft.EntityFrameworkCore;
using Meteors.OperationContext;
using Taskify.Repositories.Base;

namespace Taskify.Repositories.Security
{
    public class UserRepository : BaseRepository, IUserRepository
    {

        private readonly UserManager<User> _userManager;

        public UserRepository(UserManager<User> userManager, TaskifyContext contaxt) 
            : base(contaxt)
        {
            _userManager = userManager;
        }

        public async Task<OperationResult<GetLogInDto>> SignUp(SignUpDto dto)
        {
            if (await Context.Users.AnyAsync(u => u.Email == dto.Email))
                return _Operation.SetFailed<GetLogInDto>("This Email is already used");
            throw new NotImplementedException();
        }

        public Task<OperationResult<GetLogInDto>> LogIn(LogInDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<bool>> ForgetPassword(string email)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<TokenDto>> RefreshToken(Guid id, string refreshToken)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<GetLogInDto>> ResetPassword(ResetPasswordDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<bool>> Block(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<bool>> UnBlock(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}