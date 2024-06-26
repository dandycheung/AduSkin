using AduSkin.Utility.Element;
using System.Windows.Controls;

namespace AduSkin.Controls.Metro
{
    public class AduTabControl : TabControl
    {
        void SelectionState()
        { 
        }

        public AduTabControl()
        {
            Loaded += delegate { ElementBase.GoToState(this, "SelectionLoaded"); };
            SelectionChanged += delegate (object sender, SelectionChangedEventArgs e) { if (e.Source is AduTabControl) { SelectionState(); } };
            
        }

        static AduTabControl()
        {
            ElementBase.DefaultStyle<AduTabControl>(DefaultStyleKeyProperty);
        }
    }
}