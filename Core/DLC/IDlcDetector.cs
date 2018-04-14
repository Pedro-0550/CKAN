﻿using CKAN.Versioning;

namespace CKAN.DLC
{
    /// <summary>
    /// Represents an object that can detect the presence of official DLC in a KSP installation.
    /// </summary>
    public interface IDlcDetector
    {
        /// <summary>
        /// Checks if the relevant DLC is installed in the specific KSP installation.
        /// </summary>
        /// <param name="ksp">The KSP installation to check.</param>
        /// <param name="identifier">
        /// The identifier to use for the DLC's psuedo-module. Value is undefined if this method is undefined.
        /// </param>
        /// <param name="version">
        /// The version of the installed DLC. May be <c>null</c> if it is not possible to get the specific version of
        /// the DLC. Value is undefined if this method returns <c>false</c>.
        /// </param>
        /// <returns>
        /// <list type="bullet">
        /// <item>
        /// <term><c>true</c></term>
        /// <description>
        /// When the relevant DLC is installed in the installation specified by <paramref name="ksp"/>.
        /// </description>
        /// </item>
        /// <item>
        /// <term><c>false</c></term>
        /// <description>
        /// When the relevant DLC is not installed in the installation specified by <paramref name="ksp"/>.
        /// </description>
        /// </item>
        /// </list>
        /// </returns>
        bool IsInstalled(KSP ksp, out string identifier, out UnmanagedModuleVersion version);
    }
}