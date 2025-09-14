namespace Form_List
{
    partial class Form_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox_Album = new System.Windows.Forms.ListBox();
            this.Button_AddItem = new System.Windows.Forms.Button();
            this.Button_RemoveItem = new System.Windows.Forms.Button();
            this.Button_ClearList = new System.Windows.Forms.Button();
            this.Button_ShowItem = new System.Windows.Forms.Button();
            this.ComboBox_Colors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBox_Album
            // 
            this.ListBox_Album.FormattingEnabled = true;
            this.ListBox_Album.Items.AddRange(new object[] {
            "Animals",
            "Atom Heart Mother",
            "Dark Side of the Moon",
            "Echoes",
            "Meddle",
            "Wish You Were Here"});
            this.ListBox_Album.Location = new System.Drawing.Point(62, 32);
            this.ListBox_Album.Name = "ListBox_Album";
            this.ListBox_Album.Size = new System.Drawing.Size(160, 121);
            this.ListBox_Album.TabIndex = 0;
            // 
            // Button_AddItem
            // 
            this.Button_AddItem.Location = new System.Drawing.Point(82, 159);
            this.Button_AddItem.Name = "Button_AddItem";
            this.Button_AddItem.Size = new System.Drawing.Size(109, 23);
            this.Button_AddItem.TabIndex = 1;
            this.Button_AddItem.Text = "Add New Item";
            this.Button_AddItem.UseVisualStyleBackColor = true;
            this.Button_AddItem.Click += new System.EventHandler(this.Button_AddItem_Click);
            // 
            // Button_RemoveItem
            // 
            this.Button_RemoveItem.Location = new System.Drawing.Point(82, 188);
            this.Button_RemoveItem.Name = "Button_RemoveItem";
            this.Button_RemoveItem.Size = new System.Drawing.Size(109, 23);
            this.Button_RemoveItem.TabIndex = 2;
            this.Button_RemoveItem.Text = "Remove New Item";
            this.Button_RemoveItem.UseVisualStyleBackColor = true;
            this.Button_RemoveItem.Click += new System.EventHandler(this.Button_RemoveItem_Click);
            // 
            // Button_ClearList
            // 
            this.Button_ClearList.Location = new System.Drawing.Point(82, 217);
            this.Button_ClearList.Name = "Button_ClearList";
            this.Button_ClearList.Size = new System.Drawing.Size(109, 23);
            this.Button_ClearList.TabIndex = 3;
            this.Button_ClearList.Text = "Clear List";
            this.Button_ClearList.UseVisualStyleBackColor = true;
            this.Button_ClearList.Click += new System.EventHandler(this.Button_ClearList_Click);
            // 
            // Button_ShowItem
            // 
            this.Button_ShowItem.Location = new System.Drawing.Point(82, 246);
            this.Button_ShowItem.Name = "Button_ShowItem";
            this.Button_ShowItem.Size = new System.Drawing.Size(109, 23);
            this.Button_ShowItem.TabIndex = 4;
            this.Button_ShowItem.Text = "Show Selected";
            this.Button_ShowItem.UseVisualStyleBackColor = true;
            this.Button_ShowItem.Click += new System.EventHandler(this.Button_ShowItem_Click);
            // 
            // ComboBox_Colors
            // 
            this.ComboBox_Colors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ComboBox_Colors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_Colors.FormattingEnabled = true;
            this.ComboBox_Colors.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Gold",
            "Green",
            "Red",
            "Yellow"});
            this.ComboBox_Colors.Location = new System.Drawing.Point(62, 5);
            this.ComboBox_Colors.Name = "ComboBox_Colors";
            this.ComboBox_Colors.Size = new System.Drawing.Size(160, 21);
            this.ComboBox_Colors.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ComboBox:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ListBox:";
            // 
            // Form_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox_Colors);
            this.Controls.Add(this.Button_ShowItem);
            this.Controls.Add(this.Button_ClearList);
            this.Controls.Add(this.Button_RemoveItem);
            this.Controls.Add(this.Button_AddItem);
            this.Controls.Add(this.ListBox_Album);
            this.MaximizeBox = false;
            this.Name = "Form_List";
            this.Text = "Pink Floyd Albums";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Album;
        private System.Windows.Forms.Button Button_AddItem;
        private System.Windows.Forms.Button Button_RemoveItem;
        private System.Windows.Forms.Button Button_ClearList;
        private System.Windows.Forms.Button Button_ShowItem;
        private System.Windows.Forms.ComboBox ComboBox_Colors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

