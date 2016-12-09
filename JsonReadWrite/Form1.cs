using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JsonReadWrite
{
    public partial class Form1 : Form
    {
        List<StudentProp> list = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list = new List<StudentProp>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentProp data = new StudentProp();
            //customiste this value with you textbox value
            data.Rollno = 1;
            data.Name = "mike";
            data.Cls = "MCA";
            data.Sem = "5th";
            data.Subjects = new SubProp()
            {

                //customiste this value with you textbox value
                Adbms = 50,
                An = 50,
                Mc = 50,
                Ns = 50,
                Se = 50,
                Total = 250,
                Percentage = 50
            };
            list.Add(data);
            File.WriteAllText(Path.Combine(Application.StartupPath, "Student.json"), JsonConvert.SerializeObject(list));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (StreamReader reader = new StreamReader(Path.Combine(Application.StartupPath, "Student.json")))
            {
                string json = reader.ReadToEnd();
                List<StudentProp> readObject = JsonConvert.DeserializeObject<List<StudentProp>>(json);
                foreach (StudentProp pr in readObject)
                {
                    //show item as per your requirement
                    //all code for fetching the data and show on the graph will be write here..
                    

                    //for fetch the subject mark
                    /*
                     *  
                     *  var sb = pr.Subjects;
                        int a=sb.Adbms;
                        sb.An;
                        sb.Mc;
                        sb.Ns;
                        sb.Se;
                    *
                    *
                    */

                    listView1.Items.Add(pr.Name);
                }
            }
        }
    }
}
