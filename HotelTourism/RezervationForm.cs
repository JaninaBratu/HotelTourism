using BL;
using BL.Util;
using DAL.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelTourism
{
    public partial class RezervationForm : Form
    {
        //todo obiect filtre
        private const int PAGE_LIMIT = 2;

        int count = 0;

        public RezervationForm()
        {
            InitializeComponent();
            InitializeComboBox();
            InitializePageNr();
            DisplayHotels(Int32.Parse(pageTextBox.Text.ToString()));
        }

        
        public void InitializeDataGridView(List<Hotel> listOfHotels)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ReadOnly = true;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Hotel Id";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "City";

            foreach (var hotel in listOfHotels)
            {
                dataGridView1.Rows.Add(new String[] { hotel.HotelId.ToString(), hotel.Name.ToString(), hotel.City.Name.ToString()});
            }
            dataGridView1.Refresh();
        }


        //initialize countyId combobox and city combobox
        public void InitializeComboBox()
        {
            ComboBoxAction.InitializeCountyComboBox(countyComboBox, cityComboBox);
            List<ComboBoxItem> c = new List<ComboBoxItem>();
            c.Add(new ComboBoxItem("All cities", -1));
            cityComboBox.DataSource = c;
            cityComboBox.DisplayMember = "Text";
            cityComboBox.ValueMember = "Value";
            cityComboBox.Visible = false;
        }
        private void countyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var countyId = (int)countyComboBox.SelectedValue;

            if (countyId == -1)
            {
                List<ComboBoxItem> c = new List<ComboBoxItem>();
                c.Add(new ComboBoxItem("All cities", -1));
                cityComboBox.DataSource = c;
                cityComboBox.DisplayMember = "Text";
                cityComboBox.ValueMember = "Value";
                cityComboBox.Visible = false;
                
            }
            else
            {
                ComboBoxAction.InitializeCityComboBox(countyId, cityComboBox);
                
            }
            DisplayHotels(Int32.Parse(pageTextBox.Text.ToString()));
            //set city combobox to default (all cities and show); else (hide combobox)
            // apelezi displayHotels
            // 
        }

        private void InitializePageNr()
        {
            pageTextBox.Text = "1";
            pageTextBox.TextAlign = HorizontalAlignment.Center;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int currentPage = Int32.Parse(pageTextBox.Text.ToString());
            int updatedCurrentPage = currentPage - 1;
            DisplayHotels(updatedCurrentPage);
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           int currentPage = Int32.Parse(pageTextBox.Text.ToString());
           int updatedCurrentPage = currentPage + 1;
           DisplayHotels(updatedCurrentPage);
        }

        private void DisplayHotels(int currentPage)
        {
            int nrOfHotels;
            int nrOfPages;

            var countyId = (int)countyComboBox.SelectedValue;
            var cityId = (int)cityComboBox.SelectedValue;

            FilterType filterType = new FilterType(countyId, cityId);

            double offset = PageAction.CalculateOffset(currentPage, PAGE_LIMIT);
            List<Hotel> listOfHotels = HotelService.GetListByOffsetAndFilterType(PAGE_LIMIT, offset, filterType);

            if (listOfHotels.Count > 0)
            {
                InitializeDataGridView(listOfHotels);
                nrOfHotels = HotelService.GetTotalNrOfHotels(filterType); 
                nrOfPages = Convert.ToInt32(PageAction.GetNrOfPages(nrOfHotels, PAGE_LIMIT));

                SetPageNr(currentPage);
                //si butoanele disabled unde le faci? care butoane?
                SetEnabledButtons(currentPage, nrOfPages);
                
            }
        }

        private void SetEnabledButtons(int currentPage, int nrOfPages)
        {
            //previous btn
            if (currentPage == 1)
            {
                previousButton.Enabled = false;
            }
            else
            {
                previousButton.Enabled = true;
            }
            //next btn
            if(currentPage == nrOfPages)
            {
                nextButton.Enabled = false;
            }
            else
            {
                nextButton.Enabled = true;    
            }

        }

        private bool IsFirstPage(int currentPage)
        {
            if (currentPage == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsLastPage(int currentPage)
        {
            int nrOfHotels = HotelService.GetListOfHotels().Count();
            int nrOfPages = Int32.Parse(PageAction.GetNrOfPages(nrOfHotels, PAGE_LIMIT).ToString());
            if (currentPage == nrOfPages)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool FirstPageIsLastPage(int currentPage, int nrOfPages)
        {
            if (nrOfPages == currentPage)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SetPageNr(int currentPage)
        {
            pageTextBox.Text = currentPage.ToString();
            //il muti in alta parte
            pageTextBox.TextAlign = HorizontalAlignment.Center;
        }

    }
}
