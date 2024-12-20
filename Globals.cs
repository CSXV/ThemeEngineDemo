using System.Drawing;
using ThemeEngineLibrary;

namespace ThemeEngineDemo {
  public class Globals {
    public static uint color = 0x6750A4;

    public static clsThemeEngine Theme = new clsThemeEngine(color);

    public static void UpdateTheme(uint color) {
      Theme.UpdateScheme(color);
    }

    public static void UpdateTheme(Color color) {
      Theme.UpdateScheme(color);
    }
  }
}
