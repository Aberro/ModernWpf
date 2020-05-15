﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Windows;
using ModernWpf.Media.Animation;

namespace ModernWpf.Controls
{
    public sealed class NavigationViewSelectionChangedEventArgs : RoutedEventArgs
    {
        internal NavigationViewSelectionChangedEventArgs() : base(NavigationView.SelectionChangedEvent)
        {
        }

        public object SelectedItem { get; internal set; }
        public bool IsSettingsSelected { get; internal set; }

        public NavigationViewItemBase SelectedItemContainer { get; internal set; }
        public NavigationTransitionInfo RecommendedNavigationTransitionInfo { get; internal set; }
    }
}
