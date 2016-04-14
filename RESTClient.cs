using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace RESTClient
{
    public partial class RESTClient : Form, IRESTClient
    {

        public RESTClient()
        {
            InitializeComponent();
            new Controller(this);
        }

        public event Action<string> GetRequest;
        public event Action<string> PostRequest;
        public event Action<string> PutRequest;
        public event Action FireClearTextBox;

        private void KeyDownEnterEvent(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                if(PutRadioButton.Checked)
                {
                    PutRequest(DomainTextBox.Text);
                }
                else if(PostRadioButton.Checked)
                {
                    PostRequest(DomainTextBox.Text);
                }
                else if(GetRadioButton.Checked)
                {
                    GetRequest(DomainTextBox.Text);
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FireClearTextBox();
        }

        public void ClearTextBox()
        {
            InputTextBox.Clear();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if(InputTextBox.Text == "")
            {
                MessageBox.Show("Sorry: Input text box has no input. Please input data to be sent to the server!");
            }

            if (PutRadioButton.Checked)
            {
                PutRequest(DomainTextBox.Text);
            }
            else if (PostRadioButton.Checked)
            {
                PostRequest(DomainTextBox.Text);
            }
            else if (GetRadioButton.Checked)
            {
                GetRequest(DomainTextBox.Text);
            }
        }

        /// <summary>
        /// A property that sets the response text box in the GUI
        /// once the request has been sent.
        /// </summary>
        public string Response
        {
            set
            {
                OutPutTextBox.Text = value;
            }
        }

        /// <summary>
        /// A property that sets the status code label in the GUI
        /// once the request has been sent.
        /// </summary>
        public string StatusCode
        {
            set
            {
                
                StatusCodeLabelActual.Text = value;
            }
        }
    }
}
