namespace DeliveryManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.deliveriesListBox = new System.Windows.Forms.ListBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.deliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.updateStatusButton = new System.Windows.Forms.Button();
            this.removeDeliveryButton = new System.Windows.Forms.Button();
            this.addDeliveryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Новый",
            "В пути",
            "Доставлен"});
            this.statusComboBox.Location = new System.Drawing.Point(12, 38);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(100, 21);
            this.statusComboBox.TabIndex = 15;
            // 
            // deliveriesListBox
            // 
            this.deliveriesListBox.FormattingEnabled = true;
            this.deliveriesListBox.Location = new System.Drawing.Point(12, 98);
            this.deliveriesListBox.Name = "deliveriesListBox";
            this.deliveriesListBox.Size = new System.Drawing.Size(560, 238);
            this.deliveriesListBox.TabIndex = 14;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(172, 8);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 13;
            this.addressTextBox.Text = "Адрес";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(12, 8);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.customerNameTextBox.TabIndex = 12;
            this.customerNameTextBox.Text = "Имя клиента";
            // 
            // deliveryDatePicker
            // 
            this.deliveryDatePicker.Location = new System.Drawing.Point(382, 8);
            this.deliveryDatePicker.Name = "deliveryDatePicker";
            this.deliveryDatePicker.Size = new System.Drawing.Size(200, 20);
            this.deliveryDatePicker.TabIndex = 11;
            // 
            // updateStatusButton
            // 
            this.updateStatusButton.Location = new System.Drawing.Point(232, 68);
            this.updateStatusButton.Name = "updateStatusButton";
            this.updateStatusButton.Size = new System.Drawing.Size(120, 23);
            this.updateStatusButton.TabIndex = 10;
            this.updateStatusButton.Text = "Обновить статус";
            this.updateStatusButton.UseVisualStyleBackColor = true;
            this.updateStatusButton.Click += new System.EventHandler(this.updateStatusButton_Click);
            // 
            // removeDeliveryButton
            // 
            this.removeDeliveryButton.Location = new System.Drawing.Point(122, 68);
            this.removeDeliveryButton.Name = "removeDeliveryButton";
            this.removeDeliveryButton.Size = new System.Drawing.Size(100, 23);
            this.removeDeliveryButton.TabIndex = 9;
            this.removeDeliveryButton.Text = "Удалить";
            this.removeDeliveryButton.UseVisualStyleBackColor = true;
            this.removeDeliveryButton.Click += new System.EventHandler(this.removeDeliveryButton_Click);
            // 
            // addDeliveryButton
            // 
            this.addDeliveryButton.Location = new System.Drawing.Point(12, 68);
            this.addDeliveryButton.Name = "addDeliveryButton";
            this.addDeliveryButton.Size = new System.Drawing.Size(100, 23);
            this.addDeliveryButton.TabIndex = 8;
            this.addDeliveryButton.Text = "Добавить";
            this.addDeliveryButton.UseVisualStyleBackColor = true;
            this.addDeliveryButton.Click += new System.EventHandler(this.addDeliveryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.deliveriesListBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.deliveryDatePicker);
            this.Controls.Add(this.updateStatusButton);
            this.Controls.Add(this.removeDeliveryButton);
            this.Controls.Add(this.addDeliveryButton);
            this.Name = "Form1";
            this.Text = "Управление доставкой";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ListBox deliveriesListBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.DateTimePicker deliveryDatePicker;
        private System.Windows.Forms.Button updateStatusButton;
        private System.Windows.Forms.Button removeDeliveryButton;
        private System.Windows.Forms.Button addDeliveryButton;
    }
}

