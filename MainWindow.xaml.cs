using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.App.Content;

namespace airSoft
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        public MainWindow()
        {
            SettingsAppearanceViewModel settings = new SettingsAppearanceViewModel();
            settings.SetThemeAndColor(Properties.Settings.Default.SelectedThemeDisplayName,
                                        Properties.Settings.Default.SelectedtThemSource,
                                        Properties.Settings.Default.SelectedAccentColor,
                                        Properties.Settings.Default.SelectedFontSize);
            InitializeComponent();
        }
    }
}
