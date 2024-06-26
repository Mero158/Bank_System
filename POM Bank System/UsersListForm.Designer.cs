﻿namespace Bank_System
{
    partial class UsersListForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.BalanceTable = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permissions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManageUsersMenu_Button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.NOUsers_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceTable)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::Bank_System.Properties.Resources.image;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::Bank_System.Properties.Resources.image__2_;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::Bank_System.Properties.Resources.image__1_;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Rounding = 12;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // BalanceTable
            // 
            this.BalanceTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BalanceTable.ColumnHeadersHeight = 80;
            this.BalanceTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password,
            this.Permissions});
            this.BalanceTable.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Custom1;
            this.BalanceTable.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            this.BalanceTable.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.BalanceTable.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.BalanceTable.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.BalanceTable.HideOuterBorders = true;
            this.BalanceTable.Location = new System.Drawing.Point(-6, -6);
            this.BalanceTable.Name = "BalanceTable";
            this.BalanceTable.ReadOnly = true;
            this.BalanceTable.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.BalanceTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BalanceTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BalanceTable.Size = new System.Drawing.Size(813, 371);
            this.BalanceTable.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.BalanceTable.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.BalanceTable.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            this.BalanceTable.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.BalanceTable.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.BalanceTable.StateCommon.DataCell.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.BalanceTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.BalanceTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.BalanceTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BalanceTable.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BalanceTable.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BalanceTable.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BalanceTable.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceTable.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.BalanceTable.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.White;
            this.BalanceTable.TabIndex = 46;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Permissions
            // 
            this.Permissions.HeaderText = "Permissions";
            this.Permissions.Name = "Permissions";
            this.Permissions.ReadOnly = true;
            // 
            // ManageUsersMenu_Button
            // 
            this.ManageUsersMenu_Button.Location = new System.Drawing.Point(12, 382);
            this.ManageUsersMenu_Button.Name = "ManageUsersMenu_Button";
            this.ManageUsersMenu_Button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.OverrideDefault.Back.ColorAngle = 45F;
            this.ManageUsersMenu_Button.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.OverrideDefault.Border.ColorAngle = 45F;
            this.ManageUsersMenu_Button.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ManageUsersMenu_Button.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ManageUsersMenu_Button.OverrideDefault.Border.Rounding = 20;
            this.ManageUsersMenu_Button.OverrideDefault.Border.Width = 1;
            this.ManageUsersMenu_Button.Size = new System.Drawing.Size(321, 79);
            this.ManageUsersMenu_Button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StateCommon.Back.ColorAngle = 45F;
            this.ManageUsersMenu_Button.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StateCommon.Border.ColorAngle = 45F;
            this.ManageUsersMenu_Button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ManageUsersMenu_Button.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ManageUsersMenu_Button.StateCommon.Border.Rounding = 20;
            this.ManageUsersMenu_Button.StateCommon.Border.Width = 1;
            this.ManageUsersMenu_Button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ManageUsersMenu_Button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ManageUsersMenu_Button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUsersMenu_Button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StatePressed.Back.ColorAngle = 135F;
            this.ManageUsersMenu_Button.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StatePressed.Border.ColorAngle = 135F;
            this.ManageUsersMenu_Button.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ManageUsersMenu_Button.StatePressed.Border.Rounding = 20;
            this.ManageUsersMenu_Button.StatePressed.Border.Width = 1;
            this.ManageUsersMenu_Button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(49)))));
            this.ManageUsersMenu_Button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(42)))));
            this.ManageUsersMenu_Button.StateTracking.Back.ColorAngle = 45F;
            this.ManageUsersMenu_Button.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(49)))));
            this.ManageUsersMenu_Button.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(49)))));
            this.ManageUsersMenu_Button.StateTracking.Border.ColorAngle = 45F;
            this.ManageUsersMenu_Button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ManageUsersMenu_Button.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ManageUsersMenu_Button.StateTracking.Border.Rounding = 20;
            this.ManageUsersMenu_Button.StateTracking.Border.Width = 1;
            this.ManageUsersMenu_Button.TabIndex = 47;
            this.ManageUsersMenu_Button.Values.Image = global::Bank_System.Properties.Resources.arrow_24_xxl3;
            this.ManageUsersMenu_Button.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ManageUsersMenu_Button.Values.Text = "Manage Users Menu";
            // 
            // NOUsers_Label
            // 
            this.NOUsers_Label.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.NOUsers_Label.AutoSize = true;
            this.NOUsers_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOUsers_Label.ForeColor = System.Drawing.Color.Gray;
            this.NOUsers_Label.Location = new System.Drawing.Point(396, 406);
            this.NOUsers_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NOUsers_Label.Name = "NOUsers_Label";
            this.NOUsers_Label.Size = new System.Drawing.Size(250, 25);
            this.NOUsers_Label.TabIndex = 48;
            this.NOUsers_Label.Text = "format-->NO.Users ://ex2";
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.NOUsers_Label);
            this.Controls.Add(this.ManageUsersMenu_Button);
            this.Controls.Add(this.BalanceTable);
            this.Name = "UsersListForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POM Bank - Users List";
            this.Load += new System.EventHandler(this.UsersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BalanceTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView BalanceTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permissions;
        public ComponentFactory.Krypton.Toolkit.KryptonButton ManageUsersMenu_Button;
        private System.Windows.Forms.Label NOUsers_Label;
    }
}