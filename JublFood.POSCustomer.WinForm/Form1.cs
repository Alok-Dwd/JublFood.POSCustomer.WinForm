using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Text;
using System.Windows.Forms;

namespace JublFood.POSCustomer.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Setting.CustomerCode = 0;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

            if (txtPhoneNumber.TextLength == 10)
            {
                FindCustomer("DPI66585", txtPhoneNumber.Text, txtExt.Text);
            }
            else
            {

                txtExt.Text = string.Empty;
                txtName.Text = string.Empty;
                txtDOB.Text = string.Empty;
                txtAnniversary.Text = string.Empty;
                txtCompanyName.Text = string.Empty;
                txtStreetNumber1.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtCity.Text = string.Empty;
                txtPostalCode.Text = string.Empty;
                txtGSTIN.Text = string.Empty;
                txtSuite.Text = string.Empty;
                txtStreetNumber2.Text = string.Empty;

            }
        }

        private async void FindCustomer(string locationCode, string phoneNumber, string phoneExtension)
        {
            try
            {
                GetCustomerByPhoneNumberRequest customerRequestModel = new GetCustomerByPhoneNumberRequest();

                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

                customerRequestModel.LocationCode = locationCode;
                customerRequestModel.PhoneNumber = phoneNumber;
                customerRequestModel.PhoneNumberExt = phoneExtension;

                HttpClient APIClient = new HttpClient();

                APIClient.BaseAddress = new Uri("https://localhost:44370/");
                APIClient.DefaultRequestHeaders.Accept.Clear();
                APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await APIClient.PostAsJsonAsync("api/Customer/GetCustomerByPhoneNumber", customerRequestModel);
                response.EnsureSuccessStatusCode();
                GetCustomerByPhoneNumberResponse apiResponse = await response.Content.ReadAsAsync<GetCustomerByPhoneNumberResponse>();

                txtPhoneNumber.Text = apiResponse.result.CustomerDetail.Phone_Number;
                txtExt.Text = apiResponse.result.CustomerDetail.Phone_Ext;
                txtName.Text = apiResponse.result.CustomerDetail.Name;
                txtDOB.Text = apiResponse.result.CustomerDetail.date_of_birth.ToShortDateString() == "01-01-1900" ? string.Empty : apiResponse.result.CustomerDetail.date_of_birth.ToShortDateString();
                txtAnniversary.Text = apiResponse.result.CustomerDetail.anniversary_date.ToShortDateString() == "01-01-1900" ? string.Empty : apiResponse.result.CustomerDetail.anniversary_date.ToShortDateString();
                txtCompanyName.Text = apiResponse.result.CustomerDetail.Company_Name;
                txtStreetNumber1.Text = apiResponse.result.CustomerDetail.Street_Number;
                txtAddress.Text = apiResponse.result.CustomerDetail.Address_Line_2 + apiResponse.result.CustomerDetail.Address_Line_3 + apiResponse.result.CustomerDetail.Address_Line_4;
                txtCity.Text = apiResponse.result.CustomerDetail.Address_Line_2;
                txtPostalCode.Text = apiResponse.result.CustomerDetail.Postal_Code;
                txtGSTIN.Text = apiResponse.result.CustomerDetail.Customer_GSTIN;

                Setting.CustomerCode = apiResponse.result.CustomerDetail.Customer_Code;

                //tbNotes.Text = apiResponse.result.CustomerDetail;


            }
            catch (Exception ex)
            {

            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

            panelOrder.Visible = true;
            btnCustomer.Visible = false;
            btnOrder.Visible = true;
            listBoxOrder.Visible = true;
            btnSaveCustomer.Visible = false;

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            panelOrder.Visible = false;
            btnCustomer.Visible = true;
            btnOrder.Visible = false;
            listBoxOrder.Visible = false;
            btnSaveCustomer.Visible = true;
        }

        private void SaveCustomer()
        {
            try
            {

                SaveCustomerRequest saveCustomerRequestModel = new SaveCustomerRequest();

                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

                saveCustomerRequestModel.Added_By = "Alok"; // logged in user (Cached data)
                saveCustomerRequestModel.Address_Line_2 = txtAddress.Text;
                saveCustomerRequestModel.Address_Line_3 = "";
                saveCustomerRequestModel.Address_Line_4 = "";
                saveCustomerRequestModel.Address_Type = "";
                saveCustomerRequestModel.anniversary_date = Convert.ToDateTime(txtAnniversary.Text);
                saveCustomerRequestModel.Company_Name = txtCompanyName.Text;
                saveCustomerRequestModel.Cross_Street_Code = 0;
                saveCustomerRequestModel.date_of_birth = Convert.ToDateTime(txtDOB.Text);
                saveCustomerRequestModel.Finance_Charge_Rate = 0;
                saveCustomerRequestModel.First_Order_Date = DateTime.Now;
                saveCustomerRequestModel.Last_Order_Date = DateTime.Now;
                saveCustomerRequestModel.Location_Code = "DPI66585"; // logged in store (Cached data)
                saveCustomerRequestModel.Name = txtName.Text;
                saveCustomerRequestModel.Phone_Ext = "";
                saveCustomerRequestModel.Phone_Number = txtPhoneNumber.Text;
                saveCustomerRequestModel.Postal_Code = txtPostalCode.Text;
                saveCustomerRequestModel.Street_Code = 0;
                saveCustomerRequestModel.Street_Number = txtStreetNumber1.Text;
                saveCustomerRequestModel.Suite = txtSuite.Text;
                saveCustomerRequestModel.Tax_Exempt1 = false;
                saveCustomerRequestModel.Tax_Exempt2 = false;
                saveCustomerRequestModel.Tax_Exempt3 = false;
                saveCustomerRequestModel.Tax_Exempt4 = false;
                saveCustomerRequestModel.Tax_ID1 = "";
                saveCustomerRequestModel.Tax_ID2 = "";
                saveCustomerRequestModel.Tax_ID3 = "";
                saveCustomerRequestModel.Tax_ID4 = "";

                saveCustomerRequestModel.Customer_Code = Setting.CustomerCode;

                //HttpClient APIClient = new HttpClient();

                //APIClient.BaseAddress = new Uri("https://localhost:44370/");
                //APIClient.DefaultRequestHeaders.Accept.Clear();
                //APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //HttpResponseMessage response = await APIClient.PostAsJsonAsync("api/CustomerDetails/SaveCustomer", saveCustomerRequestModel);
                //response.EnsureSuccessStatusCode();

                //SaveCustomerResponseModel apiResponse = await response.Content.ReadAsAsync<SaveCustomerResponseModel>();

                using (var client = new HttpClient())
                {
                    string jsonRequest = JsonConvert.SerializeObject(saveCustomerRequestModel);
                    var stringContent = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
                    var response = client.PostAsync("https://localhost:44370/api/Customer/SaveCustomer", stringContent).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = response.Content;
                        string jsonResponse = responseContent.ReadAsStringAsync().GetAwaiter().GetResult();
                        SaveCustomerResponse apiResponse = JsonConvert.DeserializeObject<SaveCustomerResponse>(jsonResponse);

                        if (apiResponse.result != null && !string.IsNullOrEmpty(apiResponse.result.ResponseStatus) && apiResponse.result.ResponseStatus.ToUpper() == "SUCCESS")
                        {
                            MessageBox.Show("Customer inserted/updated successfully");

                            panelOrder.Visible = true;
                            btnCustomer.Visible = false;
                            btnOrder.Visible = true;
                            listBoxOrder.Visible = true;
                            btnSaveCustomer.Visible = false;

                        }
                    }
                }


                //if (apiResponse.result != null && string.IsNullOrEmpty(apiResponse.result.ResponseStatus) && apiResponse.result.ResponseStatus.ToUpper() == "SUCCESS")
                //{
                //    MessageBox.Show("Customer Saved Successfully");
                //}


            }
            catch (Exception ex)
            {

            }
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            SaveCustomer();
        }
    }
}
