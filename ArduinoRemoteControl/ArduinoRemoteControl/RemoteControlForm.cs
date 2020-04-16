using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoRemoteControl
{
    public partial class RemoteControlForm : Form
    {
        private SerialMessenger serialMessenger;
        private Timer readMessageTimer;
        // TODO: Below fill in the actual Arduino COM port.
        private string port = "COM3";
        private int speed = 9600;

        public RemoteControlForm()
        {
            InitializeComponent();

            MessageBuilder messageBuilder = new MessageBuilder();
            serialMessenger = new SerialMessenger(port, speed, messageBuilder);

            readMessageTimer = new Timer();
            readMessageTimer.Interval = 10;
            readMessageTimer.Tick += new EventHandler(ReadMessageTimer_Tick);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialMessenger.Connect();
                readMessageTimer.Enabled = true;
                labelConnected.Text = "Connected to Arduino\n" + port;
                labelConnected.BackColor = Color.LightGreen;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void disconnecButton_Click(object sender, EventArgs e)
        {
            disconnect();
            labelConnected.Text = "not connected";
            labelConnected.BackColor = Color.Red;

        }

        private void ReadMessageTimer_Tick(object sender, EventArgs e)
        {
            string message = serialMessenger.ReadMessages();
            if (message != null && message != "")
            {
                processReceivedMessage(message);
            }
        }

        /// <summary>
        /// handle received messages
        /// </summary>
        /// <param name="message"></param>
        private void processReceivedMessage(string message)
        {
            // First trim whitespace characters like a trailing '\r'.
            // This is needed because the Arduino Serial.println adds \r\n.
            // '\n' will be removed because this is used as the message separation character,
            // but the '\r' must also be removed, otherwise comparing the message strings will not work.
            message = message.Trim();
            // Add message to the listBox.
            listBoxMessagesReceived.Items.Add(message);
            // TODO: Below fill in your message handling.
           
        }

        private int getParamValue(string message)
        {
            int colonIndex = message.IndexOf(':');
            if (colonIndex != -1)
            {
                string param = message.Substring(colonIndex + 1);
                int value;
                bool done = int.TryParse(param, out value);
                if (done)
                {
                    return value;
                }
            }
            throw new ArgumentException("message contains no value parameter");
        }

        private void RemoteControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            disconnect();
        }

        private void disconnect()
        {
            try
            {
                readMessageTimer.Enabled = false;
                serialMessenger.Disconnect();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxMessagesReceived.Items.Clear();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            serialMessenger.SendMessage(textBoxSendMessage.Text);
        }
    }
}
