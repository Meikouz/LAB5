using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LAB5
{
    public partial class Form1 : Form
    {
        private readonly List<Bouquet> bouquets = new List<Bouquet>();
        private readonly BouquetDirector director = new BouquetDirector();
        private readonly BouquetBuilder builder = new BouquetBuilder();

        public Form1()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            cmbWrap.Items.AddRange(new string[]
            {
                "Крафт-папір",
                "Прозора плівка",
                "Сітка",
                "Коробка"
            });

            cmbRibbon.Items.AddRange(new string[]
            {
                "Червона",
                "Синя",
                "Золота",
                "Біла",
                "Рожева"
            });

            cmbWrap.SelectedIndex = 0;
            cmbRibbon.SelectedIndex = 0;

            numRoses.Value = 3;
            numTulips.Value = 2;
            numDaisies.Value = 1;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Bouquet bouquet = director.CreateBouquet(
                builder,
                txtName.Text,
                cmbWrap.Text,
                cmbRibbon.Text,
                (int)numRoses.Value,
                (int)numTulips.Value,
                (int)numDaisies.Value
            );

            bouquets.Add(bouquet);
            RefreshBouquetList();
            lstBouquets.SelectedIndex = lstBouquets.Items.Count - 1;
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            if (lstBouquets.SelectedIndex < 0)
            {
                MessageBox.Show("Оберіть букет для клонування.");
                return;
            }

            Bouquet original = bouquets[lstBouquets.SelectedIndex];
            Bouquet clone = original.Clone();
            bouquets.Add(clone);

            RefreshBouquetList();
            lstBouquets.SelectedIndex = lstBouquets.Items.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBouquets.SelectedIndex < 0)
            {
                MessageBox.Show("Оберіть букет для видалення.");
                return;
            }

            bouquets.RemoveAt(lstBouquets.SelectedIndex);
            RefreshBouquetList();
            txtInfo.Clear();
        }

        private void lstBouquets_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedBouquet();
        }

        private void RefreshBouquetList()
        {
            lstBouquets.Items.Clear();

            foreach (Bouquet bouquet in bouquets)
            {
                lstBouquets.Items.Add(bouquet);
            }
        }

        private void ShowSelectedBouquet()
        {
            if (lstBouquets.SelectedIndex >= 0)
            {
                txtInfo.Text = bouquets[lstBouquets.SelectedIndex].GetDetails();
            }
            else
            {
                txtInfo.Clear();
            }
        }
    }
}