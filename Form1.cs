using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryManager
{
    public partial class Form1 : Form
    {
        private DeliveryManager deliveryManager;

        public Form1()
        {
            InitializeComponent();
            deliveryManager = new DeliveryManager();
            UpdateDeliveriesList();
        }
        private void UpdateDeliveriesList()
        {
            deliveriesListBox.Items.Clear();
            foreach (var delivery in deliveryManager.Deliveries)
            {
                deliveriesListBox.Items.Add($"{delivery.CustomerName} - {delivery.Address} ({delivery.Status})");
            }
        }

        private void addDeliveryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerNameTextBox.Text) ||
            string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            DateTime deliveryDate = deliveryDatePicker.Value;
            Delivery newDelivery = new Delivery(customerNameTextBox.Text,
            addressTextBox.Text, deliveryDate);
            try
            {
                deliveryManager.AddDelivery(newDelivery);
                customerNameTextBox.Clear();
                addressTextBox.Clear();
                UpdateDeliveriesList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeDeliveryButton_Click(object sender, EventArgs e)
        {
            if (deliveriesListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите доставку для удаления!");
                return;
            }
            string selectedItem = deliveriesListBox.SelectedItem.ToString();
            string[] parts = selectedItem.Split(new[] { '-' }, StringSplitOptions.None);
            if (parts.Length >= 2)
            {
                string customerName = parts[0].Trim();
                string address = parts[1].Trim();
                var deliveryToRemove = deliveryManager.Deliveries.Find(d => d.CustomerName ==
                customerName && d.Address == address);
                if (deliveryToRemove != null)
                {
                    try
                    {
                        deliveryManager.RemoveDelivery(deliveryToRemove);
                        UpdateDeliveriesList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void updateStatusButton_Click(object sender, EventArgs e)
        {
            if (deliveriesListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите доставку для обновления статуса!");
                return;
            }
            string selectedItem = deliveriesListBox.SelectedItem.ToString();
            string[] parts = selectedItem.Split(new[] { '-' }, StringSplitOptions.None);
            if (parts.Length >= 2)
            {
                string customerName = parts[0].Trim();
                string address = parts[1].Trim();
                var deliveryToUpdate = deliveryManager.Deliveries.Find(d => d.CustomerName ==
                customerName && d.Address == address);
                if (deliveryToUpdate != null)
                {
                    DeliveryStatus newStatus = (DeliveryStatus)Enum.Parse(typeof(DeliveryStatus),
                    statusComboBox.SelectedItem.ToString());
                    try
                    {
                        deliveryManager.UpdateDeliveryStatus(deliveryToUpdate, newStatus);
                        UpdateDeliveriesList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
