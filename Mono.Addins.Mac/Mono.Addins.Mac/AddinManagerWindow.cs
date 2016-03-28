//
// AddinManagerWindow.cs
//
// Author:
//       iain <iain@falsevictories.com>
//
// Copyright (c) 2016 Copyright © 2015 Iain Holmes
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;

using AppKit;

namespace Mono.Addins.Mac
{
    public class AddinManagerWindow
    {
        private static bool mAllowInstall = true;

        public static bool AllowInstall {
            get { return mAllowInstall; }
            set { mAllowInstall = value; }
        }

        private AddinManagerWindow ()
        {
        }

        private static void InitDialog (AddinManagerDialog dlg)
        {
            dlg.AllowInstall = AllowInstall;
        }

        public static NSWindow Show (NSWindow parent)
        {
            return null;
        }

        public static void Run (NSWindow parent)
        {
            var dlg = new AddinManagerDialog ();
            NSApplication.SharedApplication.RunModalForWindow (dlg);
        }
    }
}

