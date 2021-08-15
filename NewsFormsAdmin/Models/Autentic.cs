//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Net.Http;
//using System.Text;
//using System.Windows.Forms;

//namespace NewsFormsAdmin.Models
//{
//    public class Autentic
//    {
      
        
       

//    }

//    void clas()
//    {

//        ArticlesClient art = new ArticlesClient();
        
//    }

//    public class ArticlesClient
//    {
//        HttpClient httpClient = new HttpClient();

//        public ArticlesClient()
//        {
//            httpClient.BaseAddress = new Uri("https://localhost:44320/");
//        }

//        public TokenClass Authenticate(string username, string password)
//        {
//            var FormData = new MultipartFormDataContent("Upload----" + DateTime.Now.ToString(CultureInfo.InvariantCulture));
//            FormData.Add(new StringContent(username), "username");
//            FormData.Add(new StringContent(password), "password");


//            var response = httpClient.PostAsync("/api/Account/auth", FormData).Result;
//            var responseText = response.Content.ReadAsStringAsync().Result;

//            if (response.StatusCode == System.Net.HttpStatusCode.OK)
//            {
//                var responseObject = JsonConvert.DeserializeObject<TokenClass>(responseText);
//                return responseObject;

//                //httpClient.DefaultRequestHeaders.Authorization = new("bearer", responseObject.token);



//            }
//            else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
//            {
//                MessageBox.Show("Invalid Credentials");
//            }
//            else
//            {
//                throw new ApplicationException("Internal Server Error");
//            }


//        }
//    }
//}
