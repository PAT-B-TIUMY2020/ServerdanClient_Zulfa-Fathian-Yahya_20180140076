using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P2_076;

using System.ServiceModel.Description;
using System.ServiceModel.Channels;



namespace Server_Zulfa_Fathian_Yahya_20180140076
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnon_Click(object sender, EventArgs e)
        {
            ServiceHost hostObj = null;
            Uri address = new Uri("http://localhost:2222/Matematika");
            BasicHttpBinding bind = new BasicHttpBinding();
            try
            {
                hostObj = new ServiceHost(typeof(Matematika), address);
                //ALAMAT BASE ADDRESS
                hostObj.AddServiceEndpoint(typeof(IMatematika), bind, "");
                //ALAMAT ENDPOINT
                //wsdl
                ServiceMetadataBehavior smb = new
               ServiceMetadataBehavior(); //Service Runtime Player
                smb.HttpGetEnabled = true; //untuk mengaktifkan wsdl(dibuka saat development, tidak untuk dibuka)
                hostObj.Description.Behaviors.Add(smb);
                //mex
                System.ServiceModel.Channels.Binding mexbind =
               MetadataExchangeBindings.CreateMexHttpBinding();
                hostObj.AddServiceEndpoint(typeof(IMetadataExchange),
               mexbind, "mex");
                hostObj.Open();
                Console.WriteLine("Server is ready!!!!");
                Console.ReadLine();
                on.Visible = true;
                off.Visible = false;
                onklik.Visible = true;
                offklik.Visible = false;
                hostObj.Close();
            }
            catch (Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

        private void btnoff_Click(object sender, EventArgs e)
        {
            on.Visible = false;
            off.Visible = true;
            onklik.Visible = true;
            offklik.Visible = false;
        }
    }
}
