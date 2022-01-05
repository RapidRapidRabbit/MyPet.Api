﻿using MyPet.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.BLL.Interfaces
{
    public interface IAdvertisementService
    {
        Task AddAdvertisementAsync(AdvertisementDTO model);        
        Task<AdvertisementDTO> GetAdvertisementByIdAsync(int id, string userId);        
        Task<AdvertisementDTO> DeleteAdvertisementAsync(int id, string userId);
        Task<IEnumerable<AdvertisementDTO>> GetFilteredPagedAdvertisementsAsync(int pageNumber, int pageSize, string region, string category, string locationTown);
        Task<IEnumerable<AdvertisementDTO>> GetPagedAdsByUserAsync(string userId, int pageNumber, int pageSize);
        Task<IEnumerable<AdvertisementDTO>> GetAdsByUserAsync(string userId);
        Task<AdvertisementDTO> UpdateAdvetrtisementAsync(AdvertisementDTO model, string userId);
        Task<AdvertisementDTO> ChangeAdStatus(int AdId, string status);
        Task<IEnumerable<AdvertisementDTO>> GetAdsOnModerationAsync();


        Task<IEnumerable<AdvertisementDTO>> GetAllAdvertisementsAsync();
    }
}
