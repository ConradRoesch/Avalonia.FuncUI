﻿namespace Avalonia.FuncUI.DSL

[<AutoOpen>]
module SplitView =
    open Avalonia.Controls
    open Avalonia.Controls.Templates
    open Avalonia.Interactivity
    open Avalonia.Media
    open Avalonia.Media.Immutable
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
   
    let create (attrs: IAttr<SplitView> list): IView<SplitView> =
        ViewBuilder.Create<SplitView>(attrs)

    type SplitView with

        static member onPaneClosed<'t when 't :> SplitView>(func: RoutedEventArgs -> unit, ?subPatchOptions) =
            AttrBuilder<'t>.CreateSubscription<RoutedEventArgs>(SplitView.PaneClosedEvent, func, ?subPatchOptions = subPatchOptions)

        static member onPaneClosing<'t when 't :> SplitView>(func: CancelRoutedEventArgs -> unit, ?subPatchOptions) =
            AttrBuilder<'t>.CreateSubscription<CancelRoutedEventArgs>(SplitView.PaneClosingEvent, func, ?subPatchOptions = subPatchOptions)

        static member onPaneOpened<'t when 't :> SplitView>(func: RoutedEventArgs -> unit, ?subPatchOptions) =
            AttrBuilder<'t>.CreateSubscription<RoutedEventArgs>(SplitView.PaneOpenedEvent, func, ?subPatchOptions = subPatchOptions)

        static member onPaneOpening<'t when 't :> SplitView>(func: CancelRoutedEventArgs -> unit, ?subPatchOptions) =
            AttrBuilder<'t>.CreateSubscription<CancelRoutedEventArgs>(SplitView.PaneOpeningEvent, func, ?subPatchOptions = subPatchOptions)

        static member content<'t when 't :> SplitView>(value: IView option) : IAttr<'t> =
            AttrBuilder<'t>.CreateContentSingle(SplitView.ContentProperty, value)

        static member content<'t when 't :> SplitView>(value: IView) : IAttr<'t> =
            value |> Some |> SplitView.content

        static member compactPaneLengthProperty<'t when 't :> SplitView>(value: float) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<float>(SplitView.CompactPaneLengthProperty, value, ValueNone)

        static member displayMode<'t when 't :> SplitView>(value: SplitViewDisplayMode) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<SplitViewDisplayMode>(SplitView.DisplayModeProperty, value, ValueNone)

        static member isPaneOpen<'t when 't :> SplitView>(value: bool) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<bool>(SplitView.IsPaneOpenProperty, value, ValueNone)

        static member openPaneLength<'t when 't :> SplitView>(value: float) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<float>(SplitView.OpenPaneLengthProperty, value, ValueNone)

        static member paneBackground<'t when 't :> SplitView>(value: IBrush) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<IBrush>(SplitView.PaneBackgroundProperty, value, ValueNone)

        static member paneBackground<'t when 't :> SplitView>(color: string) : IAttr<'t> =
            color |> Color.Parse |> ImmutableSolidColorBrush |> SplitView.paneBackground

        static member paneBackground<'t when 't :> SplitView>(value: Color) : IAttr<'t> =
            value |> ImmutableSolidColorBrush |> SplitView.paneBackground

        static member panePlacement<'t when 't :> SplitView>(value: SplitViewPanePlacement) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<SplitViewPanePlacement>(SplitView.PanePlacementProperty, value, ValueNone)

        static member pane<'t when 't :> SplitView>(value: IView option) : IAttr<'t> =
            AttrBuilder<'t>.CreateContentSingle(SplitView.PaneProperty, value)

        static member pane<'t when 't :> SplitView>(value: IView) : IAttr<'t> =
            value |> Some |> SplitView.pane

        static member paneTemplate<'t when 't :> SplitView>(value: IDataTemplate) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<IDataTemplate>(SplitView.PaneTemplateProperty, value, ValueNone)

        static member useLightDismissOverlayMode<'t when 't :> SplitView>(value: bool) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<bool>(SplitView.UseLightDismissOverlayModeProperty, value, ValueNone)

        static member templateSettings<'t when 't :> SplitView>(value: Primitives.SplitViewTemplateSettings) : IAttr<'t> =
            AttrBuilder<'t>.CreateProperty<Primitives.SplitViewTemplateSettings>(SplitView.TemplateSettingsProperty, value, ValueNone)
