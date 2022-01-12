using SwissTransport.Core;
using SwissTransport.Models;
using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBBTransportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cmb_Start.Text != "" && cmb_End.Text != "")
            {
                dgv_Verbindungen.Rows.Clear();
                SwissTransport.Core.ITransport transport = new SwissTransport.Core.Transport();
                SwissTransport.Models.Connections connections = new SwissTransport.Models.Connections();
                connections = transport.GetConnections(cmb_Start.Text, cmb_End.Text);
                for (int i = 0; i < connections.ConnectionList.Count; i++)
                {
                    string[] String = new string[4];
                    String[0] = connections.ConnectionList[i].From.Platform;
                    String[1] = connections.ConnectionList[i].From.Departure.ToString();
                    String[2] = connections.ConnectionList[i].To.Arrival.ToString();
                    String[3] = Convert.ToString(connections.ConnectionList[i].To.Arrival - connections.ConnectionList[i].From.Departure);

                    dgv_Verbindungen.Rows.Add(String);
                }
            } else
            {
                MessageBox.Show("Bitte ein Start- und Endpunkt eingeben.");
            }
        }

        private void cmb_Start_DropDown(object sender, EventArgs e)
        {
            if (cmb_Start.Text.Length >= 2)
            {
                cmb_Start.Items.Clear();
                cmb_Start.Items.Add(cmb_Start.Text);
                SwissTransport.Core.ITransport transport = new SwissTransport.Core.Transport();
                SwissTransport.Models.Stations stations = new SwissTransport.Models.Stations();
                stations = transport.GetStations(cmb_Start.Text);
                for (int i = 0; i < stations.StationList.Count; i++)
                {
                    cmb_Start.Items.Add(stations.StationList[i].Name);
                }
            }
        }

        private void cmb_End_DropDown(object sender, EventArgs e)
        {
            if (cmb_End.Text.Length >= 2)
            {
                cmb_End.Items.Clear();
                cmb_End.Items.Add(cmb_End.Text);
                SwissTransport.Core.ITransport transport = new SwissTransport.Core.Transport();
                SwissTransport.Models.Stations stations = new SwissTransport.Models.Stations();
                stations = transport.GetStations(cmb_End.Text);
                for (int i = 0; i < stations.StationList.Count; i++)
                {
                    cmb_End.Items.Add(stations.StationList[i].Name);
                }
            }
        }
    }
}