﻿using NASCAR_Money.Models.ViewModels;

namespace NASCAR_Money.Services
{
    public interface IRaceCenterService
    {
        Task<RaceCenterViewModel> GetRaceCenter(int year, int seriesId, int raceId);
    }
}
