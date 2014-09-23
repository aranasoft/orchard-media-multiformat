# orchard-media-multiformat

A Multi-Format and Multi-Source Media Module for [OrchardCMS](http://www.orchardproject.net/) (>=1.8) designed to improve cross-browser compatibility for video and audio playback.

Orchard's default Media Library Picker Field allows for multiple-file selection. However, when this is rendered in a page or blog post, each selection is independently displayed.

```html
<video src="my-movie.webm" />
<video src="my-movie.avi" />
<video src="my-movie.mov" />
```

This module extends the Media Library Picker to allow for multiple-source Video or Audio players, improving cross-browser compatibility.

```html
<video>
  <source src="my-movie.webm" />
  <source src="my-movie.avi" />
  <source src="my-movie.mov" />
</video>
```

This functionality is available via the `Multi Source Audio` and `Multi Source Video` ContentParts.

## Installation

Option 1: Install through the Gallery within the Modules section of your Orchard dashboard.
Option 2: Download from the Orchard Gallery [directly](http://gallery.orchardproject.net/List/Modules/Orchard.Module.Arana.MediaMultiFormat)


## Contributors

- [Jay Harris](http://github.com/JayHarris) (primary author)

## License

Please review LICENSE for licensing information.
