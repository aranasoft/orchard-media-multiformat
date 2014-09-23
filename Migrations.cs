using System;
using System.Collections.Generic;
using System.Globalization;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace Arana.MediaMultiFormat {
    public class Migrations : DataMigrationImpl {
        public int Create() {
            ContentDefinitionManager.AlterPartDefinition("MultiSourceVideoPart", part => part
                .Attachable()
                .WithDescription("Multi-Source Video using MediaPicker.")
                .WithField("Sources", cfg => cfg
                    .WithDisplayName("Video Sources")
                    .OfType("MediaLibraryPickerField")
                    .WithSetting("MediaLibraryPickerFieldSettings.Multiple", true.ToString(CultureInfo.InvariantCulture))
                    .WithSetting("MediaLibraryPickerFieldSettings.DisplayedContentTypes", "Video")
                )
                );

            ContentDefinitionManager.AlterPartDefinition("MultiSourceAudioPart", part => part
                .Attachable()
                .WithDescription("Multi-Source Audio using MediaPicker.")
                .WithField("Sources", cfg => cfg
                    .WithDisplayName("Audio Sources")
                    .OfType("MediaLibraryPickerField")
                    .WithSetting("MediaLibraryPickerFieldSettings.Multiple", true.ToString(CultureInfo.InvariantCulture))
                    .WithSetting("MediaLibraryPickerFieldSettings.DisplayedContentTypes", "Audio")
                )
                );

            return 1;
        }
    }
}