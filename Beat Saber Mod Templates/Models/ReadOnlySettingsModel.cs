﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatSaberModTemplates.Models
{
    public class ReadOnlySettingsModel : ISettingsModel
    {

        public string ChosenInstallPath { get; }

        public bool GenerateUserFileWithTemplate { get; }

        public bool GenerateUserFileOnExisting { get; }

        public bool SetManifestJsonDefaults { get; }

        public bool CopyToIPAPendingOnBuild { get; }

        public BuildReferenceType BuildReferenceType { get; }

        public string Manifest_Author { get; }

        public string Manifest_Donation { get; }

        public ReadOnlySettingsModel()
        {
            ChosenInstallPath = string.Empty;
        }

        public ReadOnlySettingsModel(string chosenPath, bool genUserWithTemp, bool genUserExisting, bool setManDefaults, bool copyToPending,
            BuildReferenceType buildReferenceType, string manifest_Author, string manifest_Donation)
        {
            ChosenInstallPath = chosenPath;
            GenerateUserFileWithTemplate = genUserWithTemp;
            GenerateUserFileOnExisting = genUserExisting;
            SetManifestJsonDefaults = setManDefaults;
            CopyToIPAPendingOnBuild = copyToPending;
            BuildReferenceType = buildReferenceType;
            Manifest_Author = manifest_Author;
            Manifest_Donation = manifest_Donation;
        }

        public ReadOnlySettingsModel(ISettingsModel settingsModel)
        {
            ChosenInstallPath = settingsModel.ChosenInstallPath;
            GenerateUserFileWithTemplate = settingsModel.GenerateUserFileWithTemplate;
            GenerateUserFileOnExisting = settingsModel.GenerateUserFileOnExisting;
            SetManifestJsonDefaults = settingsModel.SetManifestJsonDefaults;
            CopyToIPAPendingOnBuild = settingsModel.CopyToIPAPendingOnBuild;
            BuildReferenceType = settingsModel.BuildReferenceType;
            Manifest_Author = settingsModel.Manifest_Author;
            Manifest_Donation = settingsModel.Manifest_Donation;
        }

        public bool Equals(ISettingsModel other)
        {
            return GenerateUserFileWithTemplate == other.GenerateUserFileWithTemplate
                && GenerateUserFileOnExisting == other.GenerateUserFileOnExisting
                && SetManifestJsonDefaults == other.SetManifestJsonDefaults
                && CopyToIPAPendingOnBuild == other.CopyToIPAPendingOnBuild
                && BuildReferenceType == other.BuildReferenceType
                && ChosenInstallPath == other.ChosenInstallPath
                && Manifest_Author == other.Manifest_Author
                && Manifest_Donation == other.Manifest_Donation;
        }

        object ICloneable.Clone()
        {
            return new ReadOnlySettingsModel(this);
        }
    }
}
