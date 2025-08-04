using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YapayZeka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGonder_Click(object sender, EventArgs e)
        {
            // Kullanıcı girdilerini al
            int yas;
            if (!int.TryParse(txtYas.Text, out yas) || yas <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir yaş giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string cinsiyet = txtCinsiyet.Text.Trim();
            if (string.IsNullOrEmpty(cinsiyet))
            {
                MessageBox.Show("Lütfen cinsiyet bilgisini giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sevdikleri = txtSevdikleri.Text.Trim();
            if (string.IsNullOrEmpty(sevdikleri))
            {
                MessageBox.Show("Lütfen sevdiğiniz şeyleri giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sayi;
            if (!int.TryParse(txtYas.Text, out sayi) || sayi <= 0)
            {
                MessageBox.Show("Lütfen sevdiğiniz şeyleri giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mekan = txtMekan.Text.Trim();
            if (string.IsNullOrEmpty(mekan))
            {
                MessageBox.Show("Lütfen mekanı giriniz:", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // API isteği için prompt oluştur
            string prompt = $"{yas} yaşındaki, {sevdikleri} gibi şeyler seven {sayi} kişilik {mekan} da {cinsiyet} grubuna uygun bir etkinlik önerisi ver.";

            // ChatGPT API'sine istek gönder
            try
            {
                string apiKey = ConfigurationManager.AppSettings["OpenAI_API_Key"];

                if (string.IsNullOrEmpty(apiKey))
                {
                    MessageBox.Show("API anahtarı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string endpoint = "https://api.openai.com/v1/chat/completions";

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                    var requestBody = new
                    {
                        model = "gpt-3.5-turbo",
                        messages = new[]
                        {
                            new
                            {
                                role = "user",
                                content = prompt
                            }
                        },
                        temperature = 0.7
                    };

                    var json = JsonSerializer.Serialize(requestBody);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(endpoint, content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        using (JsonDocument document = JsonDocument.Parse(responseString))
                        {
                            var root = document.RootElement;
                            var choices = root.GetProperty("choices");
                            var firstChoice = choices[0];
                            var message = firstChoice.GetProperty("message");
                            var result = message.GetProperty("content").GetString();

                            // Sonucu göster
                            //MessageBox.Show(result, "Etkinlik Önerisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSonuc.Text = result;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"API hatası: {response.StatusCode}\n{responseString}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}