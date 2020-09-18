using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ExchangeRatesAsync
{
    public partial class FrmExchangeRate : Form
    {
        public FrmExchangeRate()
        {
            InitializeComponent();
        }

        private void FrmExchangeRate_Load(object sender, EventArgs e)
        {
            TestReader();
            RefreshCheck();
        }
        async Task TestReader()
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Async = true;

            string[] liste = new string[7];
            int i = 0;
            using (XmlReader reader = XmlReader.Create("http://www.tcmb.gov.tr/kurlar/today.xml", settings))
            {
                while (await reader.ReadAsync())
                {


                    switch (reader.NodeType)
                    {

                        case XmlNodeType.Text:
                            liste[i] = reader.Value;
                            await reader.GetValueAsync();
                            if (i == 6)
                            {

                                if (liste[1].ToString() == "ABD DOLARI")
                                {
                                    ListViewItem item = new ListViewItem(liste[1].ToString());
                                    item.SubItems.Add(liste[2].ToString());
                                    item.SubItems.Add(liste[3].ToString());
                                    item.SubItems.Add(liste[4].ToString());
                                    item.SubItems.Add(liste[5].ToString());
                                    item.SubItems.Add(liste[6].ToString());

                                    i = -5;
                                    listView1.Items.Add(item);
                                }

                                if (liste[1].ToString() == "EURO")
                                {
                                    ListViewItem item = new ListViewItem(liste[1].ToString());
                                    item.SubItems.Add(liste[1].ToString());
                                    item.SubItems.Add(liste[2].ToString());
                                    item.SubItems.Add(liste[3].ToString());
                                    item.SubItems.Add(liste[4].ToString());
                                    item.SubItems.Add(liste[5].ToString());

                                    i = -1;
                                    listView1.Items.Add(item);
                                }

                                i = 0;
                            }

                            i++;

                            break;
                    }


                }
            }
        }

        private void tmr_Refresh_Tick(object sender, EventArgs e)
        {
            
            TestReader();
            listView1.Items.Clear();
            // MessageBox.Show("Çalıştı");
        }
        public void RefreshCheck()
        {
            try
            {
                Timer tmr = new Timer();
                tmr.Interval = (15 * 1 * 1000);//5 sec
                tmr.Tick += new EventHandler(tmr_Refresh_Tick);
                tmr.Start();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


        }
    }
}
