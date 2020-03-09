using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ColorPicker_Appearance
{
    class ViewModel : NotificationObject
    {
        private Brush selectedBrush= Brushes.YellowGreen;
        private bool enableToolTip;
        private FlowDirection flowDirection;
        private bool isAlphaVisible;
        private Brush brushMode;

        public Brush BrushMode
        {
            get { return brushMode; }
            set
            {
                brushMode = value;
                this.RaisePropertyChanged("BrushMode");
            }
        }

        public Brush SelectedBrush
        {
            get { return selectedBrush; }
            set
            {
                selectedBrush = value;
                this.RaisePropertyChanged("SelectedBrush");
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

        public bool IsAlphaVisible
        {
            get { return isAlphaVisible; }
            set
            {
                isAlphaVisible = value;
                this.RaisePropertyChanged("IsAlphaVisible");
            }
        }
    }
}
