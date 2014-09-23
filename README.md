# orchard-media-multiformat

A Multi-Format and Multi-Source Media Module for [OrchardCMS](http://www.orchardproject.net/) (>=1.8) designed to improve cross-browser compatibility for video and audio playback.

Orchard's default Media Library Picker Field allows for multiple-file selection. However, when this is rendered in a page or blog post, each selection is independently displayed.

```html
<video src="my-movie.webm" />
<video src="my-movie.mp4" />
<video src="my-movie.mov" />
```

This module extends the Media Library Picker to allow for multiple-source Video or Audio players, improving cross-browser compatibility.

```html
<video>
  <source src="my-movie.webm" type="audio/webm" />
  <source src="my-movie.mp4" type="video/mp4" />
  <source src="my-movie.mov" type="video/quicktime" />
</video>
```

This functionality is available via the `Multi Source Audio` and `Multi Source Video` ContentParts.

## Installation

Option 1: Install through the Gallery within the Modules section of your Orchard dashboard.  
Option 2: Download from the Orchard Gallery [directly](http://gallery.orchardproject.net/List/Modules/Orchard.Module.Arana.MediaMultiFormat)


## Contributors

- [Jay Harris](http://github.com/JayHarris) (primary author)

## License

(BSD-3 License)

Copyright (c) 2014, Arana Software <<info@aranasoft.com>>   
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

  * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
  * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
  * Neither the name of the Arana Software nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

====

This license applies to all parts of this software that are not externally
maintained libraries. The externally maintained libraries used by this
software are:

Orchard CMS, located at http://orchard.codeplex.com. Orchard's license follows:

> Copyright (c) 2009 Outercurve Foundation
All rights reserved.

> Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

> Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
Neither the name of Outercurve Foundation nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
