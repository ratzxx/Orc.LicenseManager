﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LicenseExtensions.cs" company="WildGums">
//   Copyright (c) 2008 - 2014 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.LicenseManager
{
    using Catel;
    using Catel.Logging;
    using Portable.Licensing;

    public static class LicenseExtensions
    {
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        public static int GetMaximumConcurrentLicenses(this License license)
        {
            Argument.IsNotNull(() => license);

            var maximumConcurrentNumbers = license.Quantity;
            if (maximumConcurrentNumbers <= 0)
            {
                maximumConcurrentNumbers = 1;
            }

            return maximumConcurrentNumbers;
        }
    }
}