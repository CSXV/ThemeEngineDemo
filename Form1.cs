using System;
using System.Windows.Forms;

namespace ThemeEngineDemo {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();

      _setpix();
      _settxt();
      _setbtn();
    }

    private void _setbtn() {
      button1.BackColor = Globals.Theme.PrimaryContainer;
      button1.ForeColor = Globals.Theme.OnPrimaryContainer;
    }

    private void _setpix() {
      pbMark.BackColor = Globals.Theme.Surface;
      pbOriginial.BackColor = colorDialog1.Color;

      pictureBox1.BackColor = Globals.Theme.Surface;

      pbPrimary.BackColor = Globals.Theme.Primary;
      pbPrimaryContainer.BackColor = Globals.Theme.PrimaryContainer;

      pbSecondary.BackColor = Globals.Theme.Secondary;
      pbSecondaryContainer.BackColor = Globals.Theme.SecondaryContainer;

      pbTertiary.BackColor = Globals.Theme.Tertiary;
      pbTertiaryContainer.BackColor = Globals.Theme.TertiaryContainer;

      pbError.BackColor = Globals.Theme.Error;
      pbErrorContainer.BackColor = Globals.Theme.ErrorContainer;

      pbSurfaceBright.BackColor = Globals.Theme.SurfaceBright;
      pbSurfaceDim.BackColor = Globals.Theme.SurfaceDim;
      pbSurface.BackColor = Globals.Theme.Surface;

      pbSurfaceContainerLowest.BackColor = Globals.Theme.SurfaceContainerLowest;
      pbSurfaceContainerLow.BackColor = Globals.Theme.SurfaceContainerLow;
      pbSurfaceContainer.BackColor = Globals.Theme.SurfaceContainer;
      pbSurfaceContainerHight.BackColor = Globals.Theme.SurfaceContainerHigh;

      pbShadow.BackColor = Globals.Theme.Shadow;
    }

    private void _settxt() {
      txOriginial.BackColor = colorDialog1.Color;
      txOriginial.ForeColor = Globals.Theme.OnSurface;

      txPrimary.BackColor = Globals.Theme.Primary;
      txPrimaryContainer.BackColor = Globals.Theme.PrimaryContainer;

      txSecondary.BackColor = Globals.Theme.Secondary;
      txSecondaryContainer.BackColor = Globals.Theme.SecondaryContainer;

      txTertiary.BackColor = Globals.Theme.Tertiary;
      txTertiaryContainer.BackColor = Globals.Theme.TertiaryContainer;

      txError.BackColor = Globals.Theme.Error;
      txErrorContainer.BackColor = Globals.Theme.ErrorContainer;

      txSurfaceBright.BackColor = Globals.Theme.SurfaceBright;
      txSurfaceDim.BackColor = Globals.Theme.SurfaceDim;
      txSurface.BackColor = Globals.Theme.Surface;

      txSurfaceContainerLowest.BackColor = Globals.Theme.SurfaceContainerLowest;
      txSurfaceContainerLow.BackColor = Globals.Theme.SurfaceContainerLow;
      txSurfaceContainer.BackColor = Globals.Theme.SurfaceContainer;
      txSurfaceContainerHight.BackColor = Globals.Theme.SurfaceContainerHigh;

      txShadow.BackColor = Globals.Theme.Shadow;

      //-----------------------------------------------------
      txPrimary.ForeColor = Globals.Theme.OnPrimary;
      txPrimaryContainer.ForeColor = Globals.Theme.OnPrimaryContainer;

      txSecondary.ForeColor = Globals.Theme.OnSecondary;
      txSecondaryContainer.ForeColor = Globals.Theme.OnSecondaryContainer;

      txTertiary.ForeColor = Globals.Theme.OnTertiary;
      txTertiaryContainer.ForeColor = Globals.Theme.OnTertiaryContainer;

      txError.ForeColor = Globals.Theme.OnError;
      txErrorContainer.ForeColor = Globals.Theme.OnErrorContainer;

      txSurfaceBright.ForeColor = Globals.Theme.OnSurface;
      txSurface.ForeColor = Globals.Theme.OnSurface;
      txSurfaceDim.ForeColor = Globals.Theme.OnSurface;

      txSurfaceContainerLowest.ForeColor = Globals.Theme.OnSurface;
      txSurfaceContainerLow.ForeColor = Globals.Theme.OnSurface;
      txSurfaceContainer.ForeColor = Globals.Theme.OnSurface;
      txSurfaceContainerHight.ForeColor = Globals.Theme.OnSurface;

      txShadow.ForeColor = Globals.Theme.OnSurface;

    }

    private void button1_Click(object sender, EventArgs e) {
      colorDialog1.ShowDialog();
      Globals.UpdateTheme(colorDialog1.Color);

      _setpix();
      _settxt();
      _setbtn();
    }
  }
}
