﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenAgents_Click(object sender, EventArgs e)
        {
            Form formAgent = new FormAgent();
            formAgent.Show();
        }

        private void buttonOpenRealEstates_Click(object sender, EventArgs e)
        {
            Form formRealEstate = new FormRealEstate();
            formRealEstate.Show();
        }

        private void buttonOpenDemands_Click(object sender, EventArgs e)
        {
            Form fromSupply = new FormSupply();
            fromSupply.Show();
        }

        private void buttonOpenSupplies_Click(object sender, EventArgs e)
        {
            Form fromDemand = new FormDemand();
            fromDemand.Show();
        }
    }
}   

