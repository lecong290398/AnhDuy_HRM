﻿namespace AnhDuyCompany.ManagerCompany.Mobile.MAUI.Services.User
{
    public interface IUserProfileService
    {
        Task<string> GetProfilePicture(long userId);

        string GetDefaultProfilePicture();
    }
}