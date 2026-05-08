using System.Reflection;
using Gtk;
using Shelly.Gtk.UiModels;

namespace Shelly.Gtk.Windows.Dialog;

public class ShellyAboutDialog(Overlay overlay)
{
    public void OpenAboutDialog()
    {
        try
        {
            var dialog = AboutDialog.New();

            dialog.ProgramName = "Shelly";
            dialog.Version = Assembly.GetExecutingAssembly().GetName().Version?.ToString(3) ?? "0.0.0";
            dialog.Comments = "Shelly is an Arch Linux package manager";
            dialog.Copyright = $"© {DateTime.Now.Year} Seafoam Labs";

            dialog.LicenseType = License.Gpl30;
            dialog.WrapLicense = true;

            dialog.Website = "https://www.seafoam-labs.org/";
            dialog.WebsiteLabel = "Seafoam Labs Website";

            dialog.Authors = ["Zoey Bauer", "Caroline Snyder"];
            dialog.AddCreditSection("Maintainers", [
                "Vinícius Fonseca",
                "Anton Ždanov"
            ]);

            dialog.LogoIconName = "shelly";
            dialog.Show();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Failed to load arch news {e}");
        }
    }
}