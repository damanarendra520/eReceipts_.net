using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Threading;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace eReceipts
{
    public partial class Home : Form
    {
        public int random_number = 0;
        public string username = "";
        Thread thread;

        public Home()
        {
            InitializeComponent();
            loadCaptchaImage();
        }

        private void loadCaptchaImage()
        {
            Random r = new Random();
            random_number = r.Next(10000, 1000000);
            var image = new Bitmap(this.captcha_image.Width, this.captcha_image.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(random_number.ToString(), font, Brushes.Green, new Point(0, 0));
            captcha_image.Image = image;
            regester_captcha.Image = image;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lgn_user_name_value.Text) || string.IsNullOrWhiteSpace(lgn_password_value.Text))
            {
                MessageBox.Show("Username or password is missing !");
                return;
            }
            
            if(lgn_captcha_value.Text != random_number.ToString())
            {
                MessageBox.Show("Captcha mismatch!");
                loadCaptchaImage();
                lgn_captcha_value.Text = "";
                return;
            }

            MySqlConnection cnn = new MySqlConnection("server=localhost;database=ereceipts;uid=root;pwd='';");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            cmd.CommandText = "SELECT password FROM users WHERE user_name = '"+lgn_user_name_value.Text+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();

            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                using (MD5 md5hash = MD5.Create())
                {
                    string hash = getMD5Hash(md5hash, lgn_password_value.Text);

                    if(verifymd5hash(md5hash, reader[0].ToString(), hash))
                    {
                        username = lgn_user_name_value.Text;
                        this.Close();
                        thread = new Thread(runeReceiptsApplication);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                    }
                    else
                    {
                        Console.WriteLine("Does not matched:");
                    }
                }
                
            }
            cnn.Close();
           
        }

        public static string getMD5Hash(MD5 md5hash, string input)
        {
            byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sb = new StringBuilder();

            for(int i=0; i<data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static bool verifymd5hash(MD5 md5hash, string input, string hash)
        {
            string hasofinput = getMD5Hash(md5hash, hash);
            StringComparer compare = StringComparer.OrdinalIgnoreCase;

            if(compare.Compare(input, hash) == 0)
                return true;
            else
                return false;
        }

        private void register_new_user(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(reg_user_name_value.Text) || string.IsNullOrWhiteSpace(reg_password_value.Text) || string.IsNullOrWhiteSpace(reg_email_value.Text))
            {
                MessageBox.Show("Please fill all the fileds.!");
                return;
            }

            bool isValidEmail = IsEmailValid(reg_email_value.Text);
            if (!isValidEmail)
                return;

            string connetionString = "server=localhost;database=ereceipts;uid=root;pwd='';";
            MySqlConnection cnn = new MySqlConnection(connetionString);

            try
            {
                string password_hash = getMD5Hash(MD5.Create(), reg_password_value.Text);

                cnn.Open();
                using (MySqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = string.Format("INSERT INTO users (user_name, password, email) VALUES ('" + reg_user_name_value.Text + "', '" + password_hash + "', '" + reg_email_value.Text + "')");
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Successfully Registered.!");
                cnn.Close();

                // Show next form....
                username = reg_user_name_value.Text;
                this.Close();
                thread = new Thread(runeReceiptsApplication);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();


                // eMail regestred user ..!
                String emailsubject = "eReceipts: Thank you for your Regestraion..!";
                String emailBody = "Thank you for regestring into eReceipts. ";
                bool sendemail = sendEmail(reg_email_value.Text, emailsubject, emailBody);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception caught : {0}", ex.Message);
            }
        }

        private void runeReceiptsApplication(object obj)
        {
            Application.Run(new eReceipts(username));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadCaptchaImage();
            lgn_captcha_value.Text = "";
        }

        private void reg_captcha_refresh_Click(object sender, EventArgs e)
        {
            loadCaptchaImage();
            reg_captcha_value.Text = "";
        }

        public bool IsEmailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch(FormatException)
            {
                return false;
            }
        }

        public bool sendEmail(String to, string subject, string body)
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Timeout = 100000;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("dnarendra1310@gmail.com", "Narendra@520");
                MailMessage msg = new MailMessage();
                msg.To.Add(to);
                msg.From = new MailAddress("dnarendra1310@gmail.com");
                msg.Subject = subject;
                msg.Body = body;
                smtp.Send(msg);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeption is :" +e);
                return false;
            }
        }
        
    }
}
