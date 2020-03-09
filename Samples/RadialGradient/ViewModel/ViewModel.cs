using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ColorPicker_RadialGradient
{
    class ViewModel : NotificationObject
    {
        private bool enableSolidToGradientSwitch = true;
        private GradientBrushDisplayMode gradientBrushDisplayMode;
        private GradientPropertyEditorMode gradientPropertyEditorMode = GradientPropertyEditorMode.Extended;
        private BrushModes brushModes = BrushModes.Gradient;
        private Brush selectedBrush;

        public Brush SelectedBrush
        {
            get { return selectedBrush; }
            set
            {
                selectedBrush = value;
                this.RaisePropertyChanged("SelectedBrush");
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

        public GradientPropertyEditorMode GradientPropertyEditorMode
        {
            get { return gradientPropertyEditorMode; }
            set
            {
                gradientPropertyEditorMode = value;
                this.RaisePropertyChanged("GradientPropertyEditorMode");
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

        public bool EnableSolidToGradientSwitch
        {
            get { return enableSolidToGradientSwitch; }
            set
            {
                enableSolidToGradientSwitch = value;
                this.RaisePropertyChanged("EnableSolidToGradientSwitch");
            }
        }

        public ViewModel()
        {
            //Creating Linargradient brush
            RadialGradientBrush radialGradient = new RadialGradientBrush();
            radialGradient.GradientOrigin = new Point(0.5, 0.5);
            radialGradient.Center = new Point(0.5, 0.5);
            radialGradient.RadiusX = 0.5;
            radialGradient.RadiusY = 0.5;
            radialGradient.GradientStops.Add(new GradientStop(Colors.Yellow, 0.0));
            radialGradient.GradientStops.Add(new GradientStop(Colors.Red, 0.25));
            radialGradient.GradientStops.Add(new GradientStop(Colors.Blue, 0.75));
            radialGradient.GradientStops.Add(new GradientStop(Colors.LimeGreen, 1.0));

            //Assiging a RadialGradient for the  ColorPicker Brush
            SelectedBrush = radialGradient;
        }
    }
}
