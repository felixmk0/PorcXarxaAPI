using PorcXarxaAPI.DTOs.Farms;
using PorcXarxaAPI.Services;

namespace PorcXarxaAPI.Interfaces
{
    public interface IFarmService
    {
        Task<ServiceResult<List<GetFarmDTO>>> GetFarmsAsync();
        Task<ServiceResult<object>> CreateFarmAsync(CreateFarmDTO createFarmDTO);
        Task<ServiceResult<GetFarmDTO?>> GetFarmByIdAsync(int id);
        Task<ServiceResult<bool>> DeleteFarmAsync(int id);
    }
}
