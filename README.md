# Frank's Fork of digiCamControl

[digiCamControl](http://digicamcontrol.com/) is DSLR camera remote control open source software.
Frank's Fork was created from the [digiCamControl code](https://github.com/dukus/digiCamControl) version 2.1.6.

The fork has extra features and is backward compatible with the official digiCamControl version.
The extra features are offered as PRs to digiCamControl. If all PRs are accepted, the fork will cease to exist.

## Additional features

- In-camera bracketing support for Nikon cameras ([PR](https://github.com/dukus/digiCamControl/pull/427)).

## In-camera bracketing support for Nikon cameras

digiCamControl supports bracketing, but then every picture is an individual capture in the application. That is relatively slow, about a second per image. In-camera bracketing is much faster. There are situations where that is required. E.g., if the target is moving (but not so fast). Or as part of a time lapse of a solar eclipse in the totality phase, where you need many images (7 - 9) for a HDR to capture the outer regions of the corona, but the totality may be quite short (1-2 minutes) so it is a challenge to collect sufficient HDR images for a smooth video.

The in-camera AE bracketing properties are now available for Nikon cameras. In digiCamControl the bracketing can be configured. Also set the properties for continuous shooting and set the burst rate to the number of images in the bracket. If capture is started in digiCamControl, the camera then takes all images as fast as possible before control is returned to digiCamControl.


## License

DSLR camera remote control open source software
Copyright (C) 2014  Duka Istvan / 2026 Frank Robijn

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF 
MERCHANTABILITY,FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY 
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH 
THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
