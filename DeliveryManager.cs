using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager
{
    public class DeliveryManager
    {
        public List<Delivery> Deliveries { get; private set; }

        public DeliveryManager()
        {
            Deliveries = new List<Delivery>();
            LoadDeliveries();
        }

        public void AddDelivery(Delivery delivery)
        {
            if (delivery == null)
            {
                throw new ArgumentNullException(nameof(delivery));
            }
            Deliveries.Add(delivery);
            SaveDeliveries();
        }

        public void RemoveDelivery(Delivery delivery)
        {
            if (delivery == null)
            {
                throw new ArgumentNullException(nameof(delivery));
            }
            Deliveries.Remove(delivery);
            SaveDeliveries();
        }

        public void UpdateDeliveryStatus(Delivery delivery, DeliveryStatus newStatus)
        {
            if (delivery == null)
            {
                throw new ArgumentNullException(nameof(delivery));
            }
            delivery.UpdateStatus(newStatus);
            SaveDeliveries();
        }

        private void SaveDeliveries()
        {
            File.WriteAllLines("deliveries.txt", Deliveries.Select(d =>
                $"{d.CustomerName}|{d.Address}|{d.DeliveryDate.ToString("yyyy-MM-dd")}|{(int)d.Status}"));
        }

        private void LoadDeliveries()
        {
            if (File.Exists("deliveries.txt"))
            {
                var lines = File.ReadAllLines("deliveries.txt");
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 4)
                    {
                        if (DateTime.TryParse(parts[2], out DateTime deliveryDate))
                        {
                            var delivery = new Delivery(parts[0], parts[1], deliveryDate);
                            if (Enum.TryParse(parts[3], out DeliveryStatus status))
                            {
                                delivery.Status = status;
                            }
                            Deliveries.Add(delivery);
                        }
                    }
                }
            }
        }
    }
}