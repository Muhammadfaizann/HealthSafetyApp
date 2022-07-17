using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthSafetyApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckText : Grid
    {
        public CheckText()
        {
            InitializeComponent();
        }

        [Obsolete]
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create<CustomCheckbox, bool>(p => p.IsChecked, false, propertyChanged: (s, o, n) => { (s as CheckText).OnChecked(new EventArgs()); });

        internal void OnChecked(EventArgs eventArgs)
        {
            if (CheckedChanged != null)
                CheckedChanged(this, eventArgs);
        }
        public string Text
        {
            get
            {
                if (chkbox.IsChecked == true)
                {
                    return lbl.Text;
                }
                else
                {
                    return null;
                }
            }
            
        }
        public Color TextColor
        {
            get => lbl.TextColor;
            set
            {
                lbl.TextColor = value;
            }
        }
        public Color Color
        {
            get => chkbox.Color;
            set
            {
                chkbox.Color = value;
            }
        }

        [Obsolete]
        public bool Checked
        {
            get
            {
                return (bool)GetValue(IsCheckedProperty);
            }
            set
            {
                SetValue(IsCheckedProperty, value);
            }
        }
       public string DefaultText
        {
            get => lbl.Text;
            set
            {
                lbl.Text = value;
            }
        }
        public double FontSize
        {
            get => lbl.FontSize;
            set
            {
                lbl.FontSize = value;
            }
        }
        public event EventHandler CheckedChanged;
        //public event EventHandler<CheckedChangedEventArgs> CheckedChanged
        //{
        //    add
        //    {
        //        chkbox.CheckedChanged += value;
        //    }
        //    remove
        //    {
        //        chkbox.CheckedChanged -= value;
        //    }
        //}
    }
}