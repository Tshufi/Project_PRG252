using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Project_PRG252
{
    class FileHandler
    {
        string path = @"passwords.txt";
        public void CheckFiles()
        {

            using (StreamReader sr = new StreamReader(path))
            {
                string data;

                while ((data = sr.ReadLine()) != null)
                {
                    string[] splitData = data.Split(' ');

                    if (splitData[0] = txtBStnum_LogIn.Text && splitData[1] = txtBStNm_LogIn.Text && splitData[2] = txtBStSrn_LogIn.Text && splitData[3] = txtBMdc_LogIn.Text)
                    {
                        MessageBox.Show("Your details are correct, Do you want to see a full list of all students?");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox(ex);
            }
            finally
            {

            }
        }
    }
}
