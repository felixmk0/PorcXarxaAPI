using PorcXarxaAPI.DTOs;
using PorcXarxaAPI.DTOs.Users;
using PorcXarxaAPI.Services;

namespace PorcXarxaAPI.Interfaces
{
    public interface IUserService
    {
        Task<ServiceResult<AuthResponseDTO>> CreateUserAsync(CreateUserDTO userDTO);
        Task<ServiceResult<bool>> DeleteUserById(int id);
        Task<ServiceResult<GetUserDTO?>> GetUserByIdAsync(int id);
        Task<ServiceResult<List<GetUserDTO>>> GetUsersAsync();
        Task<ServiceResult<AuthResponseDTO>> LoginUserAsync(LoginUserDTO loginDTO);
    }
}