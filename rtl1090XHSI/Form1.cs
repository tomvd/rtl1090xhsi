using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace rtl1090XHSI
{
    public partial class Form1 : Form
    {

        Socket sock;
        IPAddress serverAddr;
        IPEndPoint endPoint;


        public static int SIM_FLIGHTMODEL_POSITION_GROUNDSPEED = 0;
        public static int SIM_FLIGHTMODEL_POSITION_TRUE_AIRSPEED = 1;
        public static int SIM_FLIGHTMODEL_POSITION_MAGPSI = 2; // mag heading
        public static int SIM_FLIGHTMODEL_POSITION_HPATH = 3; // track (true or mag?)
        public static int SIM_FLIGHTMODEL_POSITION_LATITUDE = 4;
        public static int SIM_FLIGHTMODEL_POSITION_LONGITUDE = 5;
        public static int SIM_FLIGHTMODEL_POSITION_PHI = 6;            // roll angle = bank
        public static int SIM_FLIGHTMODEL_POSITION_R = 7;            // yaw rotation rate in deg/sec
        public static int SIM_FLIGHTMODEL_POSITION_MAGVAR = 8; // XPSDK says that this dataref should be part of the environment, not the aircraft
        public static int SIM_FLIGHTMODEL_POSITION_ELEVATION = 9; // meters
        public static int SIM_FLIGHTMODEL_POSITION_Y_AGL = 10; // meters
        public static int SIM_FLIGHTMODEL_POSITION_THETA = 11; // pitch (deg)
        public static int SIM_FLIGHTMODEL_POSITION_VPATH = 12; // fpa
        public static int SIM_FLIGHTMODEL_POSITION_ALPHA = 13; // aoa
        public static int SIM_FLIGHTMODEL_POSITION_BETA = 14; // yaw ( = slip or drift ? )
        public static int SIM_FLIGHTMODEL_FAILURES_ONGROUND_ANY = 15; // It was misplaced and is not really a failure, you can use that to indicate when the wheels are on the ground
                  
        public static  int SIM_COCKPIT2_GAUGES_INDICATORS_AIRSPEED_KTS_PILOT = 52;
        public static  int SIM_COCKPIT2_GAUGES_INDICATORS_ALTITUDE_FT_PILOT = 54;
        public static  int SIM_COCKPIT2_GAUGES_INDICATORS_VVI_FPM_PILOT = 56;

        public static  int SIM_COCKPIT_RADIOS_NAV1_FREQ_HZ = 100;
        public static  int SIM_COCKPIT_RADIOS_NAV2_FREQ_HZ = 101;

        // AP
        public static  int SIM_COCKPIT_AUTOPILOT_AUTOPILOT_STATE = 150;
        public static  int SIM_COCKPIT_AUTOPILOT_VERTICAL_VELOCITY = 151;
        public static  int SIM_COCKPIT_AUTOPILOT_ALTITUDE = 152;
        public static  int SIM_COCKPIT_AUTOPILOT_APPROACH_SELECTOR = 153;
        public static  int SIM_COCKPIT_AUTOPILOT_HEADING_MAG = 154;
        public static  int SIM_COCKPIT_AUTOPILOT_AIRSPEED = 155;
        public static  int SIM_COCKPIT_AUTOPILOT_AIRSPEED_IS_MACH = 156;
        public static  int SIM_COCKPIT_AUTOPILOT_FD_PITCH = 157;
        public static  int SIM_COCKPIT_AUTOPILOT_FD_ROLL = 158;
        public static  int SIM_COCKPIT_AUTOPILOT_MODE = 159;

        // Transponder
        public static  int SIM_COCKPIT_RADIOS_TRANSPONDER_MODE = 180; // 0=OFF, 1=STDBY, 2=ON, 3=TEST
        public static  int SIM_COCKPIT_RADIOS_TRANSPONDER_CODE = 181;

        public static int SIM_COCKPIT_SWITCHES_HSI_SELECTOR = 200; // 0=NAV1, 1=NAV2, 2=GPS
        public static int SIM_COCKPIT_SWITCHES_EFIS_MAP_RANGE_SELECTOR = 201;
        public static int SIM_COCKPIT_SWITCHES_EFIS_SHOWS_AIRPORTS = 206;
        public static int SIM_COCKPIT_SWITCHES_EFIS_SHOWS_WAYPOINTS = 207;
        public static int SIM_COCKPIT_SWITCHES_EFIS_SHOWS_VORS = 208;
        public static int SIM_COCKPIT_SWITCHES_EFIS_SHOWS_NDBS = 209;
        public static int SIM_COCKPIT_SWITCHES_EFIS_MAP_SUBMODE = 211; // 0=APP, 1=VOR, 2=MAP, 3=NAV, 4=PLN

        public static int SIM_COCKPIT_ELECTRICAL_AVIONICS_ON = 80;
        public static int SIM_COCKPIT_ELECTRICAL_BATTERY_ON = 81;

        public static int SIM_WEATHER_WIND_SPEED_KT = 300;
        public static int SIM_WEATHER_WIND_DIRECTION_DEGT = 301;
        public static int SIM_WEATHER_TEMPERATURE_AMBIENT_C = 304;

        public static int SIM_COCKPIT_SWITCHES_EFIS_DME_1_SELECTOR = 202;
        public static int SIM_COCKPIT_SWITCHES_EFIS_DME_2_SELECTOR = 203;

        public static int XHSI_EFIS_PILOT_DATA = 213;

        /* http://rtl1090.web99.de/ */
        public static int ADSB_ADDRESS = 0;
        public static int ADSB_CATEGORY = 1;
        public static int ADSB_CALLSIGN = 2;
        public static int ADSB_STATUS = 3; // 0 -air 1 - ground 2, etc - alert
        public static int ADSB_CAPABILITY = 4;
        public static int ADSB_DOWNLOADREQ = 5;
        public static int ADSB_UTILITY = 6;
        public static int ADSB_IDENTITY = 7; // SQUAWK
        public static int ADSB_LAT = 8;
        public static int ADSB_LON = 9;
        public static int ADSB_FLIGHTLEVEL = 12; // Fxxx / Axxx / G
        public static int ADSB_ALT = 13;
        public static int ADSB_VRATE = 19; // feet/min
        public static int ADSB_TRUETRACK = 22; 
        public static int ADSB_HEADING = 23; 
        public static int ADSB_IAS = 25; 
        public static int ADSB_TAS = 26; 
        public static int ADSB_GS = 27; 
        public static int ADSB_MACH = 28;
        public static int ADSB_MCP = 29;  // 0-unkonwn, 1-FCU,2-AC ALT, 3-FMS
        public static int ADSB_BANKANGLE = 30;
        public static int ADSB_TURNRATE = 31;
        public static int ADSB_MCP_ALT = 32;
        public static int ADSB_FMS_ALT = 33;
        public static int ADSB_FMS_QNH = 34;
        public static int ADSB_MCP_MODE = 35;
        public static int ADSB_WDIR = 56;
        public static int ADSB_WSPD = 57;
        public static int ADSB_OAT = 58; // outside temp
        public static int ADSB_END = 59;

        public float[] lastval = new float[ADSB_END];
        public float[] delta = new float[ADSB_END];
        public float[] smoothval = new float[ADSB_END];

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            serverAddr = IPAddress.Parse("127.0.0.1");
            endPoint = new IPEndPoint(serverAddr, 49020);
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        public void msg(string mesg)
        {
            textBox1.Text = textBox1.Text + Environment.NewLine + " >> " + mesg;
        }

        private void setSimData(byte[] send_buffer, int offset, int id, float value)
        {
            byte[] quad = new byte[4] { 0, 0, 0, 0 };
            quad = BitConverter.GetBytes(id);
            Array.Reverse(quad);
            Array.Copy(quad, 0, send_buffer, offset*8, 4);
            quad = BitConverter.GetBytes(value);
            Array.Reverse(quad);
            Array.Copy(quad, 0, send_buffer, 4+ offset*8, 4);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            String line, filterline = "";
            try
            {
                Stream stream = client.OpenRead("http://localhost:31008/tableb");
                StreamReader reader = new StreamReader(stream);
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Substring(0, txtICAO.Text.Length).Equals(txtICAO.Text))
                    {
                        filterline = line;
                        break;
                    }
                }
                reader.Close();
                stream.Close();
            }
            catch (System.Net.WebException exception)
            {
                textBox1.Text = "RTL1090 is not running!";
                timer1.Enabled = false;
                return;
            }
            finally
            {
            }
            textBox1.Text = filterline;
            if (filterline.Length > 0)
            {
                string[] data = filterline.Split(':');
                lblCS.Text = data[ADSB_CALLSIGN];
                lblID.Text = data[ADSB_IDENTITY];
                lblLATLON.Text = data[ADSB_LAT] + "  " + data[ADSB_LON];
                lblFL.Text = data[ADSB_FLIGHTLEVEL];
                lblAC.Text = data[ADSB_ALT];
                lblVR.Text = data[ADSB_VRATE];
                lblTT.Text = data[ADSB_TRUETRACK];
                lblHDG.Text = data[ADSB_HEADING];
                lblIAS.Text = data[ADSB_IAS];
                lblTAS.Text = data[ADSB_TAS];
                lblGS.Text = data[ADSB_GS];
                lblMACH.Text = data[ADSB_MACH];
                lblRA.Text = data[ADSB_BANKANGLE];
                lblTR.Text = data[ADSB_TURNRATE];
                lblMCP.Text = data[ADSB_MCP_ALT];

                System.Globalization.NumberStyles style = System.Globalization.NumberStyles.AllowDecimalPoint;
                System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

                for (int i = 0; i < ADSB_END; i++)
                {
                    float newval = 0;
                    Single.TryParse(data[i], style, culture, out newval);
                    delta[i] = smoothval[i] - lastval[i];
                    lastval[i] = newval;
                }

                timer2.Enabled = true;


            }

        }

        private void txtICAO_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int numpackets = 33;
            byte[] send_buffer = new byte[8 + 8 * numpackets];
            byte[] quad = new byte[4] { 0, 0, 0, 0 };

            quad = Encoding.ASCII.GetBytes("ADCD");
            Array.Copy(quad, 0, send_buffer, 0, 4);

            quad = BitConverter.GetBytes(numpackets);
            Array.Reverse(quad);
            Array.Copy(quad, 0, send_buffer, 4, 4);

            for (int i = 0; i < ADSB_END; i++)
            {
                smoothval[i] -= delta[i]/40.0f;
            }

            setSimData(send_buffer, 1, 999, .0f);
            setSimData(send_buffer, 2, SIM_COCKPIT_ELECTRICAL_AVIONICS_ON, 1.0f);
            setSimData(send_buffer, 3, SIM_FLIGHTMODEL_POSITION_GROUNDSPEED, smoothval[ADSB_GS] / 1.9438445f);
            setSimData(send_buffer, 4, SIM_FLIGHTMODEL_POSITION_TRUE_AIRSPEED, smoothval[ADSB_TAS] / 1.9438445f);
            setSimData(send_buffer, 5, SIM_FLIGHTMODEL_POSITION_MAGPSI, smoothval[ADSB_HEADING]);
            setSimData(send_buffer, 6, SIM_FLIGHTMODEL_POSITION_HPATH, smoothval[ADSB_TRUETRACK]);
            setSimData(send_buffer, 7, SIM_FLIGHTMODEL_POSITION_LATITUDE, smoothval[ADSB_LAT]);
            setSimData(send_buffer, 8, SIM_FLIGHTMODEL_POSITION_LONGITUDE, smoothval[ADSB_LON]);
            setSimData(send_buffer, 9, SIM_FLIGHTMODEL_POSITION_PHI, smoothval[ADSB_BANKANGLE]);
            setSimData(send_buffer, 10, SIM_FLIGHTMODEL_POSITION_ELEVATION, smoothval[ADSB_ALT] * 0.3048f);
            setSimData(send_buffer, 11, SIM_FLIGHTMODEL_POSITION_Y_AGL, smoothval[ADSB_ALT] * 0.3048f);
            setSimData(send_buffer, 12, SIM_COCKPIT2_GAUGES_INDICATORS_AIRSPEED_KTS_PILOT, smoothval[ADSB_IAS]);
            setSimData(send_buffer, 13, SIM_COCKPIT2_GAUGES_INDICATORS_ALTITUDE_FT_PILOT, smoothval[ADSB_ALT]);
            setSimData(send_buffer, 14, SIM_COCKPIT2_GAUGES_INDICATORS_VVI_FPM_PILOT, smoothval[ADSB_VRATE]);
            setSimData(send_buffer, 15, SIM_COCKPIT_SWITCHES_EFIS_SHOWS_AIRPORTS, 1.0f);
            setSimData(send_buffer, 16, SIM_COCKPIT_SWITCHES_EFIS_SHOWS_WAYPOINTS, 1.0f);
            setSimData(send_buffer, 17, SIM_COCKPIT_SWITCHES_EFIS_SHOWS_VORS, 1.0f);
            setSimData(send_buffer, 18, SIM_COCKPIT_SWITCHES_EFIS_SHOWS_NDBS, 1.0f);
            setSimData(send_buffer, 19, SIM_COCKPIT_SWITCHES_EFIS_MAP_RANGE_SELECTOR, 2.0f);
            setSimData(send_buffer, 20, SIM_COCKPIT_RADIOS_TRANSPONDER_MODE, 1.0f);
            setSimData(send_buffer, 21, SIM_COCKPIT_RADIOS_TRANSPONDER_CODE, smoothval[ADSB_IDENTITY]);
            var checkedButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            setSimData(send_buffer, 22, SIM_COCKPIT_SWITCHES_EFIS_MAP_SUBMODE, float.Parse(checkedButton.Tag.ToString()));
            setSimData(send_buffer, 23, SIM_COCKPIT_AUTOPILOT_ALTITUDE, smoothval[ADSB_MCP_ALT]);
            setSimData(send_buffer, 24, SIM_COCKPIT_RADIOS_NAV1_FREQ_HZ, 113.9f);
            setSimData(send_buffer, 25, SIM_COCKPIT_RADIOS_NAV2_FREQ_HZ, 113.9f);
            setSimData(send_buffer, 26, SIM_WEATHER_WIND_SPEED_KT, smoothval[ADSB_WSPD]);
            setSimData(send_buffer, 27, SIM_WEATHER_WIND_DIRECTION_DEGT, smoothval[ADSB_WDIR]);
            setSimData(send_buffer, 28, SIM_WEATHER_TEMPERATURE_AMBIENT_C, smoothval[ADSB_OAT]);
            setSimData(send_buffer, 29, SIM_COCKPIT_SWITCHES_EFIS_DME_1_SELECTOR, 2.0f);
            setSimData(send_buffer, 30, SIM_COCKPIT_SWITCHES_EFIS_DME_2_SELECTOR, 2.0f);
            setSimData(send_buffer, 31, SIM_COCKPIT_SWITCHES_HSI_SELECTOR, 2.0f);
            setSimData(send_buffer, 32, XHSI_EFIS_PILOT_DATA, 1.0f);

            setSimData(send_buffer, 33, SIM_FLIGHTMODEL_POSITION_THETA, smoothval[ADSB_VRATE]/200.0f); // not accurate, pure visual effect

            sock.SendTo(send_buffer, endPoint);

        }
    }
}
