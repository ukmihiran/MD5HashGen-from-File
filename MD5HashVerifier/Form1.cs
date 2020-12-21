using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD5HashVerifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var result = openDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtBoxUpload.Text = openDialog.FileName;
            }
        }

        private async void btnVerify_Click(object sender, EventArgs e)
        {
            string fileName = txtBoxUpload.Text;

            if (File.Exists(fileName))
            {
                byte[] md5HashBytes = await Task.Run(() => ComputeMd5Hash(fileName));

                lblResult.Text = ToHexadecimal(md5HashBytes);

                if (!string.IsNullOrWhiteSpace(txtBoxVerify.Text))
                {
                    if (txtBoxVerify.Text.ToUpper().Equals(lblResult.Text))
                    {
                        lblResult.Text += "   : Congratz! Your File is Verified !";
                    }
                    else
                    {
                        lblResult.Text += "    : Oops! Your File is Not Verified !";
                    }
                }
            }
            else
            {
                lblResult.Text = "Invalid File Upload!";
            }
        }

        private byte[] ComputeMd5Hash(string fileName)
        {
            byte[] result = null;

            using (MD5 md5 = MD5.Create())
            {
                int bufferSize = 10 * 1024 * 1024; //10MB
                using (var stream = new BufferedStream(File.OpenRead(fileName), bufferSize))
                {
                    result = md5.ComputeHash(stream);
                }
            }
            return result;
        }

        static string ToHexadecimal(byte[] source)
        {
            if (source == null) return string.Empty;

            StringBuilder sb = new StringBuilder();

            foreach (byte b in source)
            {
                sb.Append(b.ToString("X2")); // print byte as Hexadecimal string 
            }
            return sb.ToString();
        }

        private void btnUpGen_Click(object sender, EventArgs e)
        {
            var result = openDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtBoxUpGen.Text = openDialog.FileName;
            }
        }

        private async void btnGenHash_Click(object sender, EventArgs e)
        {
            string fileName = txtBoxUpGen.Text;

            if (File.Exists(fileName))
            {
                byte[] md5HashBytes = await Task.Run(() => GenMd5Hash(fileName));

                lblGenResult.Text = ToHexadecimal(md5HashBytes);

                lblGenResult.Text += "   : Your MD5 Hash Code!";
            }
        }

        private byte[] GenMd5Hash(string fileName)
        {
            byte[] result = null;

            using (MD5 md5 = MD5.Create())
            {
                int bufferSize = 10 * 1024 * 1024; //10MB
                using (var stream = new BufferedStream(File.OpenRead(fileName), bufferSize))
                {
                    result = md5.ComputeHash(stream);
                }
            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
