using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;
using System.Security.Cryptography;

namespace HYWJ
{
    public partial class Register : Form
    {
        private string AppPath = Environment.CurrentDirectory;//获取软件运行目录
        private HYWJ.HY_System.Ini ini;
        public Register()
        {
            InitializeComponent();
            ini=new HYWJ.HY_System.Ini(AppPath + @"\config.ini");
        }

        // 写入信息
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string cpname = this.CPName.Text.Trim();
                string user = this.User.Text.Trim();
                string license=this.License.Text.Trim();//~5~1~a~s~p~x
                string deslicense = null;
                if (license == GetMotherBoardSerialNumber())
                {
                    deslicense = Encrypt(license, "joy64000");
                    string AppPath = Environment.CurrentDirectory;//获取软件运行目录
                    ini.WriteValue("Company", "key", cpname);
                    ini.WriteValue("User", "key", user);
                    ini.WriteValue("License", "key", deslicense);
                    MessageBox.Show("软件注册成功,确定后重新运行程序！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.None);
                    this.Close();
                    this.Dispose();
                    Application.Exit();
                }
                else
                {
                   MessageBox.Show("注册码错误请获取正确的注册码","注册提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {
            // 读取ini
            string AppPath = Environment.CurrentDirectory;//获取软件运行目录
            string cpname= ini.ReadValue("Company", "key");
            string user = ini.ReadValue("User", "key");
            string license = ini.ReadValue("License", "key");
            this.label4.Text = GetMotherBoardSerialNumber();//获取本机主板ID
            if (cpname == string.Empty && user == string.Empty)
            {
                MessageBox.Show("软件还没有注册，注册后可使用", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            this.CPName.Text = cpname;
            this.User.Text = user;
            //this.License.Text = license;
        }
        //获取主板序号 
        private static string GetMotherBoardSerialNumber()
        {
            ManagementClass mc = new ManagementClass("WIN32_BaseBoard");
            ManagementObjectCollection moc = mc.GetInstances();
            string SerialNumber = "";
            foreach (ManagementObject mo in moc)
            {
                SerialNumber = mo["SerialNumber"].ToString();
                break;
            }
            return SerialNumber;
        }

        /// 进行DES加密。
        /// </summary>
        /// <param name="pToEncrypt">要加密的字符串。</param>
        /// <param name="sKey">密钥，且必须为8位。</param>
        /// <returns>以Base64格式返回的加密字符串。</returns>
        public string Encrypt(string pToEncrypt, string sKey)
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                byte[] inputByteArray = Encoding.UTF8.GetBytes(pToEncrypt);
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    cs.Close();
                }
                string str = Convert.ToBase64String(ms.ToArray());
                ms.Close();
                return str;
            }
        }

        /// <summary>
        /// 进行DES解密。
        /// </summary>
        /// <param name="pToDecrypt">要解密的以Base64</param>
        /// <param name="sKey">密钥，且必须为8位。</param>
        /// <returns>已解密的字符串。</returns>
        public string Decrypt(string pToDecrypt, string sKey)
        {
            byte[] inputByteArray = Convert.FromBase64String(pToDecrypt);
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    cs.Close();
                }
                string str = Encoding.UTF8.GetString(ms.ToArray());
                ms.Close();
                return str;
            }
        }        

        private void btnCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
