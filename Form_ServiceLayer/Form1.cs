using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;


namespace Form_ServiceLayer
{
   

    public partial class Form1 : Form
    {

        sapLogin sapLogin1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string url;

            url = txturl.Text + "/Login";
            //string json = $"{{\"id\":\"{id}\",\"data\":\"{data}\"}}";
            //string data = "{ \"CompanyDB\": \"TEST\", \"UserName\": \"0001\", \"Password\": \"0002\"}";
            // string jsonLogin = "{\"CompanyDB\":\"SBODEMOGT\",\"Password\":\"manager\",\"UserName\":\"manager\"}";
            string jsonLogin = txtCredenciales.Text;
            HttpWebRequest Solicitud = (HttpWebRequest)WebRequest.Create(url);

            Solicitud.Method = "POST";
            Solicitud.ContentType = "application/json";
            Solicitud.Accept = "application/json";
            Solicitud.ServerCertificateValidationCallback += (sender1, certificate, chain, sslPolicyErrors) => true;
            Solicitud.KeepAlive = true;
            Solicitud.Headers.Add("B1S-WCFCompatible", "true");
            Solicitud.Headers.Add("B1S-MetadataWithoutSession", "true");
            Solicitud.ServicePoint.Expect100Continue = false;
            using (var streamWriter = new StreamWriter(Solicitud.GetRequestStream()))
            {
                streamWriter.Write(jsonLogin);
                //streamWriter.Flush();
                //streamWriter.Close();
            }

            try
            {


                using (WebResponse respuesta = Solicitud.GetResponse())
                {
                    using (Stream strResponse = respuesta.GetResponseStream()) {

                        if (strResponse == null) return;

                        using (StreamReader objReader = new StreamReader(strResponse))
                        {
                            string responseBody = objReader.ReadToEnd();

                            txtSessionId.Multiline = true;
                            txtSessionId.Text = responseBody.ToString();


                            //string JSONString = responseBody.Replace("odata.metadata", "odataMetadata");
                            //JSONString = JsonConvert.SerializeObject(JSONString);
                            //DataTable dtable = JsonConvert.DeserializeObject<DataTable>(JSONString);


                            //var obj = JObject.Parse(responseBody);
                            //var array = new JArray(obj["SessionId"].Values());

                             sapLogin1 = JsonConvert.DeserializeObject<sapLogin>(responseBody);
                           // DataTable dtable = JsonConvert.DeserializeObject<DataTable>(responseBody);
                            //  var makeTB = JsonConvert.DeserializeAnonymousType(responseBody, new { tes= default(DataTable) }).tes;
                            MessageBox.Show(sapLogin1.SessionId);
                        }


                    }


                }
            }
            catch (WebException ex)
            {

                // System.Windows.Forms.MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message);
            }


        }

             
        private void button2_Click(object sender, EventArgs e)
        {
            string url;

            url = txturl.Text + "/Login";
            //string data = "{    \"CompanyDB\": \"TEST\",    \"UserName\": \"0001\",       \"Password\": \"0002\"}";

            string data= "{\"CompanyDB\":\"SBODEMOMX\",\"Password\":\"manager\",\"UserName\":\"manager\"}";

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.KeepAlive = true;
            httpWebRequest.ServerCertificateValidationCallback += (sender1, certificate, chain, sslPolicyErrors) => true;
            httpWebRequest.Headers.Add("B1S-WCFCompatible", "true");
            httpWebRequest.Headers.Add("B1S-MetadataWithoutSession", "true");
            httpWebRequest.Accept = "*/*";
            httpWebRequest.ServicePoint.Expect100Continue = false;
            httpWebRequest.Headers.Add("Accept-Encoding", "gzip, deflate, br");
            httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            { streamWriter.Write(data); }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
           // B1Session obj = null;

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                txtResult.Text=result;
               // obj = JsonConvert.DeserializeObject<B1Session>(result);
            }


        }

        private void cmdClientes_Click(object sender, EventArgs e)
        {

            string url = txturl.Text + "/BusinessPartners?$select=CardCode,CardName,CardType,Currency,Phone1,City,SalesPersonCode";
          
            string json = txtCredenciales.Text;
            HttpWebRequest Solicitud = (HttpWebRequest)WebRequest.Create(url);

            ////ejemplo servicelayer en 
            //Solicitud.Accept = "application/json;odata=minimalmetadata";
            //Solicitud.KeepAlive = true;                               //keep alive
            //Solicitud.ServicePoint.Expect100Continue = false;        //content
            //Solicitud.AllowAutoRedirect = true;
            //Solicitud.ContentType = "application/json;odata=minimalmetadata;charset=utf8";
            //Solicitud.Timeout = 10000000;    //number of seconds before considering a request as timeout (consider to change it for batch operations)


            Solicitud.Method = "GET";
            Solicitud.ContentType = "application/json;odata=minimalmetadata;charset=utf8";
            Solicitud.Accept = "application/json";
            Solicitud.ServerCertificateValidationCallback += (sender1, certificate, chain, sslPolicyErrors) => true;
            Solicitud.KeepAlive = true;
            Solicitud.Headers.Add("B1S-WCFCompatible", "true");
            Solicitud.Headers.Add("B1S-MetadataWithoutSession", "true");
            Solicitud.Headers.Add("Cookie","B1SESSION=" + sapLogin1.SessionId + ";ROUTEID =.node1");
      
            Solicitud.ServicePoint.Expect100Continue = false;
           
           
            try
            {

                using (WebResponse respuesta = Solicitud.GetResponse())
                {
                    using (Stream strResponse = respuesta.GetResponseStream())
                    {

                        if (strResponse == null) return;

                        using (StreamReader objReader = new StreamReader(strResponse))
                        {
                            string responseBody = objReader.ReadToEnd();

                            string JSONString = string.Empty;


                            JObject jSonObj = JObject.Parse(responseBody);
                            JSONString = JsonConvert.SerializeObject(jSonObj["value"]);
                           // DataTable dtable = JsonConvert.DeserializeObject<DataTable>(JSONString);
                            DataTable dtable = JsonConvert.DeserializeObject<DataTable>(JSONString);
                            gvLista.DataSource = dtable;

                            
                        }


                    }


                }
            }
            catch (WebException ex)
            {

                // System.Windows.Forms.MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message);
            }



        }

        private void cmdVerCliente2_Click(object sender, EventArgs e)
        {

            //otra forma de enviar solicitudes
            HttpClient cliente = new HttpClient();

            //var cookieContainer = new CookieContainer();
            //using (var handler = new HttpClientHandler { CookieContainer = cookieContainer })
            //using (var client = new HttpClient(handler))
            //{
            //    var jsonString = @"{""CompanyDB"":""MICOMPANY""}";
            //    var postData = new StringContent(jsonString, Encoding.UTF8, "application/json");

            //    var loginResponse = await client.PostAsync("https://some-site.com/loginPath", postData);

            //    // ...

            //    // This GET request will automatically include the cookies you received above
            //    var dataResponse = await client.GetAsync("https://some-site.com/give/me/data");
            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string JSONString = string.Empty;
            string strJson = txtResult.Text;

            //******** metodo 1 
            JObject jObjson = JObject.Parse(strJson);          
            JSONString = JsonConvert.SerializeObject(jObjson["value"]);
            DataTable dtable = JsonConvert.DeserializeObject<DataTable>(JSONString);
            //******** fin metodo 1

            gvLista.DataSource = dtable;
            // DataTable dtable = JsonConvert.DeserializeObject<DataTable>(JSONString);

            //string strJson2 = txtResult.Text;

            //var jsonV = JsonConvert.SerializeObject(strJson2);
            //DataTable dt = (DataTable)JsonConvert.DeserializeObject( jsonV["value"]);




        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            gvLista.DataSource="";
        }

        private void cmdOrdenVenta_Click(object sender, EventArgs e)
        {

            string url;

            url = txtCrearOrder.Text;
            //string json = $"{{\"id\":\"{id}\",\"data\":\"{data}\"}}";
            //string data = "{ \"CompanyDB\": \"TEST\", \"UserName\": \"0001\", \"Password\": \"0002\"}";
            string json = txtJsonOrder.Text;
           
            HttpWebRequest Solicitud = (HttpWebRequest)WebRequest.Create(url);

            Solicitud.Method = "POST";
            Solicitud.ContentType = "application/json";
            Solicitud.Accept = "application/json";
            Solicitud.ServerCertificateValidationCallback += (sender1, certificate, chain, sslPolicyErrors) => true;
            Solicitud.KeepAlive = true;
            Solicitud.Headers.Add("B1S-WCFCompatible", "true");
            Solicitud.Headers.Add("B1S-MetadataWithoutSession", "true");
            Solicitud.Headers.Add("Cookie", "B1SESSION=" + sapLogin1.SessionId + ";ROUTEID =.node1");
            Solicitud.ServicePoint.Expect100Continue = false;
            using (var streamWriter = new StreamWriter(Solicitud.GetRequestStream()))
            {
                streamWriter.Write(json);
                //streamWriter.Flush();
                //streamWriter.Close();
            }

            try
            {

                using (WebResponse respuesta = Solicitud.GetResponse())
                {
                    using (Stream strResponse = respuesta.GetResponseStream())
                    {

                        if (strResponse == null) return;

                        using (StreamReader objReader = new StreamReader(strResponse))
                        {
                            string responseBody = objReader.ReadToEnd();

                            txtOrderResult.Text = responseBody.ToString();

                           //sapLogin1 = JsonConvert.DeserializeObject<sapLogin>(responseBody);
                        
                        }

                    }
                }
            }
            catch (WebException ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message);
            }

        }



        private void cmdCrear2_Click(object sender, EventArgs e)
        {
            Order documento = new Order();

            documento.CardCode = "C1111";
            documento.DocDate = "2022-05-30";
            documento.DocDueDate="2022-05-30";
            documento.DocType = "dDocument_Items";
            //documento.DocumentLines =  List<DocumentLine>;
            List<DocumentLine> Lineas = new List<DocumentLine>();
            //Lineas.Add(new DocumentLine { ItemCode = "A00001", Quantity = 1f, TaxCode = "IVA", UnitPrice = 670.76f });
            //Lineas.Add(new DocumentLine { ItemCode = "A00002", Quantity = 2f, TaxCode = "IVA", UnitPrice = 1250.45f });

            DataTable dt =  new DataTable();
            dt.Columns.Add("ItemCode");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("TaxCode");
            dt.Columns.Add("UnitPrice");
            dt.Rows.Add();
            dt.Rows[0]["ItemCode"] = "A00001";
            dt.Rows[0]["Quantity"] = 1f;
            dt.Rows[0]["TaxCode"] = "IVA";
            dt.Rows[0]["UnitPrice"] = 679.24f;
            dt.Rows.Add();
            dt.Rows[1]["ItemCode"] = "A00002";
            dt.Rows[1]["Quantity"] = 2f;
            dt.Rows[1]["TaxCode"] = "IVA";
            dt.Rows[1]["UnitPrice"] = 1250.45f;
            dt.Rows.Add();
            dt.Rows[2]["ItemCode"] = "A00003";
            dt.Rows[2]["Quantity"] = 3f;
            dt.Rows[2]["TaxCode"] = "IVA";
            dt.Rows[2]["UnitPrice"] = 2470.81f;
            //{ ItemCode = "A00001", Quantity = 2f, TaxCode = "IVA", UnitPrice = 1250.45f });
            //documento.DocumentLines.Add(new DocumentLine { ItemCode = "A00002", Quantity = 2f, TaxCode = "IVA", UnitPrice = 1250.45f });

            //var list= dt.AsEnumerable().ToList();

            //documento.DocumentLines = CommonMethod.ConvertToList<DocumentLine>(dt);

            // documento.DocumentLines = Lineas;
            
            // **************  metodook
                List<DocumentLine> Lines = dt.AsEnumerable().Select(row =>
                new DocumentLine 
                {
                    ItemCode = row["ItemCode"].ToString(),
                    Quantity = Convert.ToSingle(row["Quantity"]),
                    TaxCode = row["TaxCode"].ToString(),
                    UnitPrice = Convert.ToSingle(row["UnitPrice"])
                }).ToList();

            // *********** otro metodo  ok


            documento.DocumentLines = Lines;
            txtOrderResult.Text = JsonConvert.SerializeObject(documento);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class sapLogin
    {
        public string metadata { get; set; }
        public string SessionId { get; set; }
        public string Version { get; set; }

        public string SessionTimeout { get; set; }

    }

    //clase para comvertir Datatable a lista
    public static class CommonMethod
    {
        public static List<T> ConvertToList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName.ToLower()).ToList();
            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row => {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name.ToLower()))
                    {
                        try
                        {
                            pro.SetValue(objT, row[pro.Name]);
                        }
                        catch (Exception ex) { }
                    }
                }
                return objT;
            }).ToList();
        }
    }




}
