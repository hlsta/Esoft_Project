using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class FormDemand : Form
    {
        public FormDemand()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowAgents();
            ShowClient();
            ShowDemand();

        }
        void ShowDemand()
        {
            listViewDemandApartment.Items.Clear();
            listViewDemandHous.Items.Clear();
            listViewDemandLand.Items.Clear();
            foreach (DemandSet demand in Program.esoft.DemandSet)
            {
                if (demand.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                        {
                            demand.IdAgent.ToString(),
                            demand.IdClient.ToString(),
                            demand.Type.ToString(),
                            demand.MiniPrice.ToString(),
                            demand.MaxPrice.ToString(),
                            demand.MinArea.ToString(),
                            demand.MaxArea.ToString(),
                            demand.MinRooms.ToString(),
                            demand.MaxRooms.ToString(),
                            demand.MinFloor.ToString(),
                            demand.MaxFloor.ToString()
                        });
                    item.Tag = demand;
                    listViewDemandApartment.Items.Add(item);
                }
                else if (demand.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                            demand.IdAgent.ToString(),
                            demand.IdClient.ToString(),
                            demand.Type.ToString(),
                            demand.MiniPrice.ToString(),
                            demand.MaxPrice.ToString(),
                            demand.MinArea.ToString(),
                            demand.MaxArea.ToString(),
                            demand.MinFloors.ToString(),
                            demand.MaxFloors.ToString()
                    });
                    item.Tag = demand;
                    listViewDemandHous.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                            demand.IdAgent.ToString(),
                            demand.IdClient.ToString(),
                            demand.Type.ToString(),
                            demand.MiniPrice.ToString(),
                            demand.MaxPrice.ToString(),
                            demand.MinArea.ToString(),
                            demand.MaxArea.ToString(),
                    });
                    item.Tag = demand;
                    listViewDemandLand.Items.Add(item);
                }
            }
            listViewDemandApartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDemandHous.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDemandLand.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);       
        }
        void ShowAgents()
        {
            comboBoxIdAgent.Items.Clear();
            foreach (AgentsSet agentSet in Program.esoft.AgentsSet)
            {
                string[] item = { agentSet.id.ToString() + ".", agentSet.FirstName, agentSet.MiddleName, agentSet.LastName };
                comboBoxIdAgent.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClient()
        {
            comboBoxIdClient.Items.Clear();
            foreach (ClientSet clientSet in Program.esoft.ClientSet)
            {
                string[] item = { clientSet.Id.ToString() + ".", clientSet.FirstName, clientSet.MiddleName, clientSet.LastName };
                comboBoxIdClient.Items.Add(string.Join(" ", item));
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                listViewDemandApartment.Visible = true;
                textBoxMaxRooms.Visible = true;
                textBoxMinRooms.Visible = true;
                textBoxMinFloor.Visible = true;
                textBoxMaxFloor.Visible = true;
                labelMinRooms.Visible = true;
                labelMaxRooms.Visible = true;
                labelMinFloor.Visible = true;
                labelMaxFloor.Visible = true;

                listViewDemandHous.Visible = false;
                listViewDemandLand.Visible = false;
                textBoxMinFloors.Visible = false;
                textBoxMaxFloors.Visible = false;
                labelMinFloors.Visible = false;
                labelMaxFloors.Visible = false;

                textBoxMaxPrice.Text = "";
                textBoxMiniPrice.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMiniArea.Text = "";
                textBoxMaxArea.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewDemandHous.Visible = true;
                textBoxMinFloors.Visible = true;
                textBoxMaxFloors.Visible = true;
                labelMinFloors.Visible = true;
                labelMaxFloors.Visible = true;

                listViewDemandApartment.Visible = false;
                listViewDemandLand.Visible = false;
                textBoxMinFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                textBoxMaxRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                labelMinRooms.Visible = false;
                labelMaxRooms.Visible = false;

                textBoxMaxPrice.Text = "";
                textBoxMiniPrice.Text = "";
                textBoxMiniArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                listViewDemandLand.Visible = true;

                listViewDemandApartment.Visible = false;
                listViewDemandHous.Visible = false;
                textBoxMinFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                textBoxMaxRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                labelMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMinFloors.Visible = false;
                textBoxMaxFloors.Visible = false;
                labelMinFloors.Visible = false;
                labelMaxFloors.Visible = false;

                textBoxMaxPrice.Text = "";
                textBoxMiniPrice.Text = "";
                textBoxMiniArea.Text = "";
                textBoxMaxArea.Text = "";
            }                  
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DemandSet demand = new DemandSet();
            demand.IdAgent = Convert.ToInt32(comboBoxIdAgent.SelectedItem.ToString().Split('.')[0]);
            demand.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
            demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
            demand.MiniPrice = Convert.ToInt64(textBoxMiniPrice.Text);
            demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
            demand.MinArea = Convert.ToDouble(textBoxMiniArea.Text);
            if (comboBoxType.SelectedIndex == 0)
            {
                demand.Type = 0;
                demand.IdAgent = Convert.ToInt32(comboBoxIdAgent.SelectedItem.ToString().Split('.')[0]);
                demand.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                demand.MinRooms = Convert.ToInt32(textBoxMinFloor.Text);
                demand.MaxRooms = Convert.ToInt32(textBoxMinFloor.Text);
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                demand.Type = 1;
                demand.IdAgent = Convert.ToInt32(comboBoxIdAgent.SelectedItem.ToString().Split('.')[0]);
                demand.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
            }
            else
            {
                demand.Type = 2;
            }
            Program.esoft.DemandSet.Add(demand);
            Program.esoft.SaveChanges();
            ShowDemand();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                if (listViewDemandApartment.SelectedItems.Count == 1)
                {
                    DemandSet demand = listViewDemandApartment.SelectedItems[0].Tag as DemandSet;
                    demand.IdAgent = Convert.ToInt32(comboBoxIdAgent.SelectedItem.ToString().Split('.')[0]);
                    demand.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                    demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demand.MiniPrice = Convert.ToInt64(textBoxMiniPrice.Text);
                    demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                    demand.MinArea = Convert.ToDouble(textBoxMiniArea.Text);
                    demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    demand.MinFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                    demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                    Program.esoft.SaveChanges();
                    ShowDemand();
                }
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                if (listViewDemandHous.SelectedItems.Count == 1)
                {
                    DemandSet demand = listViewDemandHous.SelectedItems[0].Tag as DemandSet;
                    demand.IdAgent = Convert.ToInt32(comboBoxIdAgent.SelectedItem.ToString().Split('.')[0]);
                    demand.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                    demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demand.MiniPrice = Convert.ToInt64(textBoxMiniPrice.Text);
                    demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                    demand.MinArea = Convert.ToDouble(textBoxMiniArea.Text);
                    demand.MinFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                    demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                    Program.esoft.SaveChanges();
                    ShowDemand();
                }
            }
            else
            {
                if (listViewDemandLand.SelectedItems.Count == 1)
                {
                    DemandSet demand = listViewDemandLand.SelectedItems[0].Tag as DemandSet;
                    demand.IdAgent = Convert.ToInt32(comboBoxIdAgent.SelectedItem.ToString().Split('.')[0]);
                    demand.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                    demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demand.MiniPrice = Convert.ToInt64(textBoxMiniPrice.Text);
                    demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                    demand.MinArea = Convert.ToDouble(textBoxMiniArea.Text);
                    Program.esoft.SaveChanges();
                    ShowDemand();
                }
            }
        }

        private void listViewDemandApartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDemandApartment.SelectedItems.Count == 1)
            {
                DemandSet demand = listViewDemandApartment.SelectedItems[0].Tag as DemandSet;
                textBoxMiniPrice.Text = demand.MiniPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
                textBoxMiniArea.Text = demand.MinArea.ToString();
                textBoxMinRooms.Text = demand.MinRooms.ToString();
                textBoxMaxRooms.Text = demand.MaxRooms.ToString();
                textBoxMinFloor.Text = demand.MinFloor.ToString();
                textBoxMaxFloor.Text = demand.MaxFloor.ToString();
            }
            else
            {
                textBoxMiniPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMiniArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
            }
        }

        private void listViewDemandHous_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDemandHous.SelectedItems.Count == 1)
            {
                DemandSet demand = listViewDemandHous.SelectedItems[0].Tag as DemandSet;
                textBoxMiniPrice.Text = demand.MiniPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
                textBoxMiniArea.Text = demand.MinArea.ToString();
                textBoxMinFloors.Text = demand.MinFloors.ToString();
                textBoxMaxFloors.Text = demand.MaxFloors.ToString();
            }
            else
            {
                textBoxMiniPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMiniArea.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
        }

        private void listViewDemandLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDemandLand.SelectedItems.Count == 1)
            {
                DemandSet demand = listViewDemandLand.SelectedItems[0].Tag as DemandSet;
                textBoxMiniPrice.Text = demand.MiniPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
                textBoxMiniArea.Text = demand.MinArea.ToString();
            }
            else
            {
                textBoxMiniPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMiniArea.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewDemandApartment.SelectedItems.Count == 1)
                    {
                        DemandSet demandSet = listViewDemandApartment.SelectedItems[0].Tag as DemandSet;
                        Program.esoft.DemandSet.Remove(demandSet);
                        Program.esoft.SaveChanges();
                        ShowDemand();
                    }
                    textBoxMaxArea.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMiniArea.Text = "";
                    textBoxMiniPrice.Text = "";
                    textBoxMinFloor.Text = "";
                    textBoxMaxFloor.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = "";
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewDemandHous.SelectedItems.Count == 1)
                    {
                        DemandSet demandSet = listViewDemandHous.SelectedItems[0].Tag as DemandSet;
                        Program.esoft.DemandSet.Remove(demandSet);
                        Program.esoft.SaveChanges();
                        ShowDemand();
                    }
                    textBoxMaxArea.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMiniArea.Text = "";
                    textBoxMiniPrice.Text = "";
                    textBoxMinFloors.Text = "";
                    textBoxMaxFloors.Text = "";
                }
                else
                {
                    if (listViewDemandLand.SelectedItems.Count == 1)
                    {
                        DemandSet demandSet = listViewDemandLand.SelectedItems[0].Tag as DemandSet;
                        Program.esoft.DemandSet.Remove(demandSet);
                        Program.esoft.SaveChanges();
                        ShowDemand();
                    }
                    textBoxMaxArea.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMiniArea.Text = "";
                    textBoxMiniPrice.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
