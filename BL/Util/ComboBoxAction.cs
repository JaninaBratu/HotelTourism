using Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BL.Util
{
    public partial class ComboBoxAction : Form
    {
        public static void InitializeCountyComboBox(ComboBox countyComboBox, ComboBox cityComboBox)
        {
            List<County> listOfCounties = CountyService.GetAllCounties();

            List<ComboBoxItem> c = new List<ComboBoxItem>();

            c.Add(new ComboBoxItem("All counties", -1));

            for (int i = 0; i < listOfCounties.Count; i++)
            {

                c.Add(new ComboBoxItem(listOfCounties[i].Name.ToString(), listOfCounties[i].CountyId));

                //if (!SetComboboxVisibility(countyComboBox, cityComboBox))
                //{
                //    if (i == 0)
                //    {
                //        InitializeCityComboBox(listOfCounties[i].CountyId, cityComboBox);
                //    }
                //}
            }

            countyComboBox.DataSource = c;
            countyComboBox.DisplayMember = "Text";
            countyComboBox.ValueMember = "Value";

        }

        public static void InitializeCityComboBox(int countyId, ComboBox cityComboBox)
        {
            List<City> listOfCities = CityService.GetCitiesByCounty(countyId);
            
            List<ComboBoxItem> c = new List<ComboBoxItem>();
            if (listOfCities.Count > 1)
            {
                c.Add(new ComboBoxItem("All cities", -1));
            }

            for (int i = 0; i < listOfCities.Count; i++)
            {
                if (countyId != -1)
                {
                    c.Add(new ComboBoxItem(listOfCities[i].Name.ToString(), listOfCities[i].CityId));
                }
            }
            cityComboBox.DataSource = c;
            cityComboBox.DisplayMember = "Text";
            cityComboBox.ValueMember = "Value";
            cityComboBox.Visible = true;
        }

        public static bool SetComboboxVisibility(ComboBox combobox1, ComboBox combobox2)
        {
            int selectedValue = (int)combobox1.SelectedValue;
            if (selectedValue == -1)
            {
                combobox2.Visible = false;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
