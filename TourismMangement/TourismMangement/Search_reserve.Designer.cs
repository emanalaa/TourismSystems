﻿namespace TourismMangement
{
    partial class Search_reserve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_reserve));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReserveButton = new System.Windows.Forms.Button();
            this.TransportationComboBoxSearch = new System.Windows.Forms.ComboBox();
            this.SearchTourPlaceComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTrans = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(193, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Transportation:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(236, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tour Place:";
            // 
            // ReserveButton
            // 
            this.ReserveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReserveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ReserveButton.ForeColor = System.Drawing.Color.White;
            this.ReserveButton.Location = new System.Drawing.Point(305, 386);
            this.ReserveButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(140, 47);
            this.ReserveButton.TabIndex = 7;
            this.ReserveButton.Text = "Reserve";
            this.ReserveButton.UseVisualStyleBackColor = false;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // TransportationComboBoxSearch
            // 
            this.TransportationComboBoxSearch.FormattingEnabled = true;
            this.TransportationComboBoxSearch.Location = new System.Drawing.Point(369, 188);
            this.TransportationComboBoxSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TransportationComboBoxSearch.Name = "TransportationComboBoxSearch";
            this.TransportationComboBoxSearch.Size = new System.Drawing.Size(221, 32);
            this.TransportationComboBoxSearch.TabIndex = 6;
            this.TransportationComboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.TransportationComboBoxSearch_SelectedIndexChanged);
            // 
            // SearchTourPlaceComboBox
            // 
            this.SearchTourPlaceComboBox.FormattingEnabled = true;
            this.SearchTourPlaceComboBox.Location = new System.Drawing.Point(369, 103);
            this.SearchTourPlaceComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SearchTourPlaceComboBox.Name = "SearchTourPlaceComboBox";
            this.SearchTourPlaceComboBox.Size = new System.Drawing.Size(221, 32);
            this.SearchTourPlaceComboBox.TabIndex = 5;
            this.SearchTourPlaceComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchTourPlaceComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 47);
            this.button1.TabIndex = 34;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTrans
            // 
            this.dataGridViewTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTrans.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrans.GridColor = System.Drawing.Color.White;
            this.dataGridViewTrans.Location = new System.Drawing.Point(187, 245);
            this.dataGridViewTrans.Name = "dataGridViewTrans";
            this.dataGridViewTrans.RowTemplate.Height = 26;
            this.dataGridViewTrans.Size = new System.Drawing.Size(403, 87);
            this.dataGridViewTrans.TabIndex = 35;
            // 
            // Search_reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 567);
            this.Controls.Add(this.dataGridViewTrans);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReserveButton);
            this.Controls.Add(this.TransportationComboBoxSearch);
            this.Controls.Add(this.SearchTourPlaceComboBox);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Search_reserve";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_reserve";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.ComboBox TransportationComboBoxSearch;
        private System.Windows.Forms.ComboBox SearchTourPlaceComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewTrans;
    }
}