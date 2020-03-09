using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ColorPicker_ChooseColor
{
    class ViewModel :  NotificationObject
    {
        private Brush selectedBrush;
        private Color selectedColor = Colors.YellowGreen;
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

        public bool IsColorPaletteVisible
        {
            get { return isColorPaletteVisible; }
            set
            {
                isColorPaletteVisible = value;
                this.RaisePropertyChanged("IsColorPaletteVisible");
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
    }
}
