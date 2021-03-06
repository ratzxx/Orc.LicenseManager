﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILicenseInfoService.cs" company="WildGums">
//   Copyright (c) 2008 - 2015 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.LicenseManager.Services
{
    using Models;

    public interface ILicenseInfoService
    {
        #region Methods
        LicenseInfo GetLicenseInfo();
        #endregion
    }
}