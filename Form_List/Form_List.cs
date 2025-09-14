
// Amir Moeini Rad
// September 2025

// Main Concepts: ComboBox, ListBox and Button Components in C# WinForms

// In this example, the ComboBox and ListBox components are filled manually using the 'Items' property.

// The ComboBox does nothing here. It just displays a list of colors.

// The ListBox component displays a list of Pink Floyd albums.
// The list items are not sorted alphabetically. Therefore, the new item will be added to the end of the list.

// The Button components perform various operations on the ListBox component such as
// adding, removing, clearing items, and showing the selected item.


using System;
using System.Windows.Forms;


namespace Form_List
{
    public partial class Form_List : Form
    {
        // The constructor method of the Form_List class.
        public Form_List()
        {
            InitializeComponent();

            // Select and display the first item in the ComboBox component as default.
            ComboBox_Colors.SelectedIndex = 0;
        }


        // The 'Click' event handler for the 'Add an Item' button.
        private void Button_AddItem_Click(object sender, EventArgs e)
        {
            // Add() method adds an item to the end of the ListBox component.
            ListBox_Album.Items.Add("The Division Bell");            
        }


        // The 'Click' event handler for the 'Remove an Item' button.
        private void Button_RemoveItem_Click(object sender, EventArgs e)
        {
            // Remove() method removes the first occurrence of a specific item from the ListBox component.
            ListBox_Album.Items.Remove("The Division Bell");
        }


        // The 'Click' event handler for the 'Clear List' button.
        private void Button_ClearList_Click(object sender, EventArgs e)
        {
            // Clear() method removes all items from the ListBox component.
            ListBox_Album.Items.Clear();
        }


        // The 'Click' event handler for the 'Show Selected Item' button.
        private void Button_ShowItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected '" + ListBox_Album.SelectedItem + 
                "' which has an index of " + ListBox_Album.SelectedIndex,
                "Selected Album", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
