# WPF ColorPicker Sample

This sample demonstrates how to build a modern color selection experience in a WPF application. It showcases visual color picking with RGB, HSV, and Hex modes, an eye dropper to sample on-screen colors from any application, a gradient editor for multi-stop gradients, a system color palette, built-in themes, and right-to-left (RTL) layout support. Users can drag sliders, type exact values, sample any pixel on screen, and preview results instantly.

## Features
- RGB, HSV, and Hex input modes with synchronized values and live preview
- Sliders for channel/parameter adjustments (R/G/B, H/S/V, and Alpha if enabled)
- Eye dropper: pick a color from anywhere on screen; values update automatically
- Gradient editor: solid or gradient modes with gradient stops, start/end points, and preview box
- System colors: built-in palette with named system colors for quick selection
- Built-in themes to match application styling
- Right-to-left (RTL) support for languages such as Hebrew, Arabic, and Persian

## Getting Started
- Clone this repository
- Open the WPF solution in Visual Studio
- Build and run the sample application to explore the ColorPicker

## To use the ColorPicker in your own window/page:
- Add the control to your XAML and bind to its selected color property
- Enable the eye dropper to sample colors from the screen when required
- Switch between RGB/HSV/Hex modes based on your UI needs
- Toggle solid/gradient modes and configure gradient stops as needed

## Usage Tips
- RGB/HSV/Hex: expose all modes or restrict to the mode that best fits your workflow
- Eye dropper: provide a clear affordance (button/icon) and show a live preview while hovering
- Gradient editor: manage stops (add/move/remove) and allow precise numeric entry for positions
- Preview: show the current color and, when applicable, the gradient result for instant feedback
- RTL: test layouts in both LTR and RTL to ensure a polished experience

## About the Sample
This sample provides a concise starting point for integrating a capable ColorPicker into WPF apps. It demonstrates visual color selection, on-screen sampling, gradient creation, and system color lookup with theme and RTL support. Extend it by wiring the selected color into your rendering pipeline (e.g., brushes, styles, drawing surfaces) and by tailoring themes to match your brand.


