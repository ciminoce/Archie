using Archie.Entidades;

namespace Archie.Windows.Helpers
{
    public static class CombosHelper
    {
        public static void CargarComboSecciones(ref ComboBox combo)
        {
            combo.Items.Clear();
            combo.DataSource = Enum.GetValues(typeof(Seccion));
            combo.SelectedIndex = 0;
        }
    }
}
