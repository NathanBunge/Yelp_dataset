using _451_Database_UI.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace _451_Database_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (string state in Globals.states) stateBox.Items.Add(state);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState.Text = ListManager.SelectListBox(stateBox);
            //cityBox.Items.Clear();
            
            ClearCities();
            if (stateBox.SelectedIndex == -1) return;
            
            Globals.SetCities(stateBox.SelectedItem.ToString());
            foreach(string city in Globals.cities)
                cityBox.Items.Add(city);
            
        }

        private void cityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCity.Text = ListManager.SelectListBox(cityBox);
            ClearZips();

            if (cityBox.SelectedIndex == -1) return;
            Globals.SetZips(cityBox.SelectedItem.ToString());
            foreach (string zip in Globals.zips)
                zipBox.Items.Add(zip);
        }

        private void zipBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedZip.Text = ListManager.SelectListBox(zipBox);
            checkedListBox1.Items.Clear();

            if (zipBox.SelectedIndex == -1) return;
            Globals.SetCategories(zipBox.SelectedItem.ToString());
            foreach (string category in Globals.categories)
                checkedListBox1.Items.Add(category);

            businessTable.Rows.Clear();

            Globals.SetBusinessInfo(selectedZip.Text, new List<string>());
            foreach (string[] stringAr in Globals.businessInfo)
                businessTable.Rows.Add(stringAr);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListManager.SearchListBox(stateBox, Globals.states, stateSearch.Text);
        }

        private void citySearch_TextChanged(object sender, EventArgs e)
        {
            ListManager.SearchListBox(cityBox, Globals.cities, citySearch.Text);
        }

        private void zipSearch_TextChanged(object sender, EventArgs e)
        {
            ListManager.SearchListBox(zipBox, Globals.zips, zipSearch.Text);
        }

        private void businessTable_SelectionChanged(object sender, EventArgs e)
        {
            if (businessTable.SelectedRows.Count == 0) return;
            Globals.SetTipInfo(businessTable.SelectedRows[0].Cells[3].Value.ToString());

            tipBox.Text = "";
            foreach(string[] tipInfo in Globals.tipInfo)
            {
                tipBox.Text += CustomFormatter.TipBuilder(tipInfo);
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            businessTable.Rows.Clear();
            ListManager.UpdateCheckedList(checkedListBox1, e);
            debugBox.Text = "";
            foreach (string str in Globals.checkedCategories)
                debugBox.Text += str;
            Globals.SetBusinessInfo(selectedZip.Text, ListManager.ItemListToStringList(checkedListBox1, e));
            //Globals.SetBusinessInfo(selectedZip.Text, Globals.categories);
            //if(e.NewValue == CheckState.Checked) Globals.businessInfo
            //Globals.SetBusinessInfo(selectedZip.Text, test);
            foreach (string[] stringAr in Globals.businessInfo)
                businessTable.Rows.Add(stringAr);
            if (businessTable.Rows.Count == 0) ClearTipBox();
        }

        private void ClearCities()
        {
            cityBox.Items.Clear();
            ClearZips();
        }

        private void ClearZips()
        {
            zipBox.Items.Clear();
            ClearCategories();
        }
        private void ClearCategories()
        {
            checkedListBox1.Items.Clear();
            ClearBusinessTable();
        }
        private void ClearBusinessTable()
        {
            businessTable.Rows.Clear();
            ClearTipBox();
        }
        private void ClearTipBox()
        {
            tipBox.Text = "";
            //submitButton.Enabled = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void tipText_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("askldjfhaskldjfhaskldfj\n\n");
            string tipDate = dateTimePicker1.Value.ToString();
            string tipTexts = tipText.Text;
            string business_id = businessTable.SelectedRows[0].Cells[3].Value.ToString();
            string user_id = tipUserID.Text;


            string sql = $"INSERT INTO Tip (tipDate, user_id, business_id, tipText, likes) " +
                $"VALUES ('{tipDate}', '{user_id}', '{business_id}', '{tipTexts}', {0})";

            Console.WriteLine(sql);
            var cmd = new NpgsqlCommand(sql, Globals.con);

            cmd.ExecuteNonQuery();

            businessTable.Rows.Clear();
            Globals.SetBusinessInfo(selectedZip.Text, ListManager.ItemListToStringList(checkedListBox1));
            //if(e.NewValue == CheckState.Checked) Globals.businessInfo
            //Globals.SetBusinessInfo(selectedZip.Text, test);
            foreach (string[] stringAr in Globals.businessInfo)
                businessTable.Rows.Add(stringAr);
            if (businessTable.Rows.Count == 0) ClearTipBox();
        }
    }
}
