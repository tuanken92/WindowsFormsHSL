using HslCommunication;
using HslCommunication.Profinet.Melsec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHSL
{
    public partial class FormHSL : Form
    {
        string ip = "192.168.1.222";
        int port = 12289;
        private MelsecMcNet melsec_net = null;
    
        public string plc_type { get; set; }
        public string plc_address { get; set; }
        enum EPLCType
        {
            PLCType_M,
            PLCType_D,
            PLCType_X,
            PLCType_Y,
            PLCType_SD
        }
        
        public FormHSL()
        {
            InitializeComponent();

            plc_type = PLCType_Cbb.Text;
            plc_address = PLCAdress_Text.Text;

        }

        private void Connect_Btn_Click(object sender, EventArgs e)
        {
            if(melsec_net == null)
                melsec_net = new MelsecMcNet(ip, port);

            melsec_net.ConnectTimeOut = 2000;
            melsec_net.NetworkNumber = 0x00;//Network number
            melsec_net.NetworkStationNumber = 0x00;//Network station number

            OperateResult connect = melsec_net.ConnectServer();
            if (connect.IsSuccess)
            {
                MessageBox.Show("Connected successfully!");
            }
            else
            {
                MessageBox.Show("Connection failed!");
            }
        }

        private void Disconnect_Btn_Click(object sender, EventArgs e)
        {
            OperateResult close = melsec_net.ConnectClose();
            if (close.IsSuccess)
            {
                MessageBox.Show("Close connection successfully!");
            }
            else
            {
                MessageBox.Show("Close connection failed!");
            }
        }

        private void Read_Btn_Click(object sender, EventArgs e)
        {
            if (melsec_net == null)
                return;

            try
            {
                string _address = string.Format("{0}{1}", plc_type, plc_address);
                switch (PLCType_Cbb.SelectedIndex)
                {
                    case 0://M
                    case 2://M
                    case 3://M
                        bool[] M_relay = melsec_net.ReadBool(_address, 1).Content;//read whether M100 works, decimal address
                        Value_Text.Text = M_relay[0].ToString();
                        Console.WriteLine($"{_address} -> {M_relay[0]}");
                        break;

                    case 1://D
                        int D_reg = melsec_net.ReadInt32(_address).Content;
                        Value_Text.Text = D_reg.ToString();
                        Console.WriteLine($"{_address} -> {D_reg}");
                        break;

                    default:
                        break;
                }    
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Write_Btn_Click(object sender, EventArgs e)
        {
            if (melsec_net == null)
                return;

            try
            {

                string _address = string.Format("{0}{1}", plc_type, plc_address);

                switch (PLCType_Cbb.SelectedIndex)
                {
                    case 0://M
                    case 2://M
                    case 3://M
                        bool b_val = Convert.ToBoolean(Value_Text.Text);
                        
                        Console.WriteLine($"{_address} -> {b_val}");
                        melsec_net.Write(_address, b_val);//write D1000 int value
                        break;

                    case 1://D
                        int i_val = Convert.ToInt32(Value_Text.Text);

                        Console.WriteLine($"{_address} -> {i_val}");
                        melsec_net.Write(_address, i_val);//write D1000 int value
                        break;


                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PLCAdress_Text_TextChanged(object sender, EventArgs e)
        {
            plc_address = PLCAdress_Text.Text;
        }

        private void PLCType_Cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            plc_type = PLCType_Cbb.Text;
        }
    }
}
