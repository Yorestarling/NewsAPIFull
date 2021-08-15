using NewsFormsAdmin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace NewsFormsAdmin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Log(TxtUsername.Text, TxtPassword.Text);
            clear();

        }

        void clear()
        {
            TxtPassword.Clear();
            TxtUsername.Clear();
        }


        public void Log(string username, string password)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44320/");



            if (TxtUsername.Text.Length == 0)
            {
                MessageBox.Show("Username Required");
            }
            else if (TxtPassword.Text.Length == 0)
            {
                MessageBox.Show("Password Required");
            }
            else
            {

                var FormData = new MultipartFormDataContent("Upload----" + DateTime.Now.ToString(CultureInfo.InvariantCulture));
                FormData.Add(new StringContent(username), "username");
                FormData.Add(new StringContent(password), "password");


                var response = httpClient.PostAsync("/api/Account/auth", FormData).Result;
                var responseText = response.Content.ReadAsStringAsync().Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseObject = JsonConvert.DeserializeObject<TokenClass>(responseText);

                    //httpClient.DefaultRequestHeaders.Authorization = new("bearer", responseObject.token);
                    
                    MENU mENU = new MENU();
                    mENU.ShowDialog();

                    
                    // return responseObject;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Invalid Credentials");
                }
                else
                {
                    throw new ApplicationException("Internal Server Error");
                }

            }


        }

        private void BtnLog_Enter(object sender, EventArgs e)
        {
            //Log();
            //clear();
        }

        private void BtnLog_DragEnter(object sender, DragEventArgs e)
        {
            //Log();
            //clear();
        }
    }

    
}
