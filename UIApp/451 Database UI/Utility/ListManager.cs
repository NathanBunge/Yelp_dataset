using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;
using static System.Windows.Forms.ListBox;

namespace _451_Database_UI
{
    public abstract class ListManager
    {
        /// <summary>
        /// Searches a list for relevant results.
        /// </summary>
        /// <param name="list">List of strings to search.</param>
        /// <param name="searchTerm">String to search for.</param>
        /// <returns>List of relevant strings.</returns>
        public static List<string> SearchList(List<string> list, string searchTerm)
        {
            if (list == null) return new List<string>();
            List<string> returnList = new List<string>();
            List<string> otherRecs = new List<string>();
            foreach (string item in list)
            {
                if (item.ToLower().StartsWith(searchTerm.ToLower())) returnList.Add(item);
                else if (item.ToLower().Contains(searchTerm.ToLower())) otherRecs.Add(item);
            }
            foreach (string item in otherRecs) returnList.Add(item);

            return returnList;
        }

        /// <summary>
        /// Refines search box to relevant items.
        /// </summary>
        /// <param name="listBox">List Box to refine.</param>
        /// <param name="items">List of potential items.</param>
        /// <param name="searchTerm">String to search for.</param>
        public static void SearchListBox(ListBox listBox, List<string> items, string searchTerm)
        {
            listBox.Items.Clear();
            SearchList(items, searchTerm);
            foreach (string item in SearchList(items, searchTerm)) listBox.Items.Add(item);
        }

        /// <summary>
        /// Refines checkedListBox to relevant items;
        /// </summary>
        /// <param name="checkedListBox"></param>
        /// <param name="items"></param>
        /// <param name="checkedItems"></param>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        public static void SearchCheckedListBox(CheckedListBox checkedListBox, List<string> items, List<string> checkedItems, string searchTerm)
        {
            checkedListBox.Items.Clear();
            if (items == null) return;
            List<string> otherRecs = new List<string>();
            foreach (string item in items)
            {
                if (item.ToLower().StartsWith(searchTerm.ToLower())) checkedListBox.Items.Add(item, checkedItems.Contains(item));
                else if (item.ToLower().Contains(searchTerm.ToLower())) otherRecs.Add(item);
            }
            foreach (string item in otherRecs) checkedListBox.Items.Add(item, checkedItems.Contains(item));
        }

        public static void UpdateCheckedList(CheckedListBox objectCollection, ItemCheckEventArgs newValue)
        {
            if (newValue.NewValue == CheckState.Checked) Globals.checkedCategories.Add(objectCollection.Items[newValue.Index].ToString());
            else Globals.checkedCategories.Remove(objectCollection.Items[newValue.Index].ToString());
        }

        public static string SelectListBox(ListBox listBox)
        {
            if (listBox.SelectedIndex == -1) return "";
            return listBox.SelectedItem.ToString();
        }

        public static List<string> ItemListToStringList(CheckedListBox objectCollection, ItemCheckEventArgs newValue)
        {
            List<string> returnList = new List<string>();
            foreach (object obj in objectCollection.CheckedItems)
                returnList.Add(obj.ToString());
            if (newValue.NewValue == CheckState.Checked) returnList.Add(objectCollection.Items[newValue.Index].ToString());
            else returnList.Remove(objectCollection.Items[newValue.Index].ToString());
            return returnList;
        }

        public static List<string> ItemListToStringList(CheckedListBox objectCollection)
        {
            List<string> returnList = new List<string>();
            foreach (object obj in objectCollection.CheckedItems)
                returnList.Add(obj.ToString());
            return returnList;
        }
    }
}
