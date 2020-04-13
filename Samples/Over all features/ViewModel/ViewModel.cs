using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ColorPicker_WPF
{
    class ViewModel : NotificationObject
    {
        private BrushModes brushModes;
        private Brush selectedBrush = Brushes.Green;
        private Color selectedColor;
        private bool enableSolidToGradientSwitch;
        private bool enableToolTip;
        private FlowDirection flowDirection;
        private GradientBrushDisplayMode gradientBrushDisplayMode;
        private GradientPropertyEditorMode gradientPropertyEditorMode;
        private bool isAlphaVisible;
        private bool isColorPaletteVisible;
        private ColorSelectionMode colorSelectionMode;

        public Brush SelectedBrush
        {
            get { return selectedBrush; }
            set
            {
                selectedBrush = value;
                this.RaisePropertyChanged("SelectedBrush");
            }
        }
        
        public Color SelectedColor
        {
            get { return selectedColor; }
            set
            {
                selectedColor = value;
                this.RaisePropertyChanged("SelectedColor");
            }
        }

        public BrushModes BrushModes
        {
            get { return brushModes; }
            set
            {
                brushModes = value;
                this.RaisePropertyChanged("BrushModes");
            }
        }
        
        public ColorSelectionMode ColorSelectionMode
        {
            get { return colorSelectionMode; }
            set
            {
                colorSelectionMode = value;
                this.RaisePropertyChanged("ColorSelectionMode");
            }
        }

        public bool EnableSolidToGradientSwitch
        {
            get { return enableSolidToGradientSwitch; }
            set
            {
                enableSolidToGradientSwitch = value;
                this.RaisePropertyChanged("EnableSolidToGradientSwitch");
            }
        }

        public bool EnableToolTip
        {
            get { return enableToolTip; }
            set
            {
                enableToolTip = value;
                this.RaisePropertyChanged("EnableToolTip");
            }
        }

        public FlowDirection FlowDirection
        {
            get { return flowDirection; }
            set
            {
                flowDirection = value;
                this.RaisePropertyChanged("FlowDirection");
            }
        }

        public GradientBrushDisplayMode GradientBrushDisplayMode
        {
            get { return gradientBrushDisplayMode; }
            set
            {
                gradientBrushDisplayMode = value;
                this.RaisePropertyChanged("GradientBrushDisplayMode");
            }
        }

        public GradientPropertyEditorMode GradientPropertyEditorMode
        {
            get { return gradientPropertyEditorMode; }
            set
            {
                gradientPropertyEditorMode = value;
                this.RaisePropertyChanged("GradientPropertyEditorMode");
            }
        }

        public bool IsAlphaVisible
        {
            get { return isAlphaVisible; }
            set
            {
                isAlphaVisible = value;
                this.RaisePropertyChanged("IsAlphaVisible");
            }
        }

        public bool IsColorPaletteVisible
        {
            get { return isColorPaletteVisible; }
            set
            {
                isColorPaletteVisible = value;
                this.RaisePropertyChanged("IsColorPaletteVisible");
            }
        }
        
        public ViewModel()
        {

        }        
    }
}
