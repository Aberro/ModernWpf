// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Windows;

namespace ModernWpf.Controls
{
    public sealed class NavigationViewDisplayModeChangedEventArgs : RoutedEventArgs
    {
        internal NavigationViewDisplayModeChangedEventArgs() : base(NavigationView.DisplayModeChangedEvent)
        {
        }

        public NavigationViewDisplayMode DisplayMode { get; internal set; }
    }
}
