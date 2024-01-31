using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Vxod_Click(object sender, EventArgs e)
        {
            {
                if (comboBox1.Text == "Посетитель" && textBox1.Text == "admin" && textBox2.Text != "")
                    MessageBox.Show("У вас нет доступа!", "Ошибка");

                {


                    string connect = "data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user52_db;persist security info=True;user id=user52_db;password=user52;MultipleActiveResultSets=True;App=EntityFramework";
                    SqlConnection myConnection = new SqlConnection(connect);
                    string command = "SELECT Login, Parol FROM KURS1_Posetitel WHERE Login = '" + textBox1.Text + "' AND Parol = '" + textBox2.Text + "'";
                    myConnection.Open();
                    SqlCommand myCommand = new SqlCommand(command, myConnection);
                    SqlDataReader row;
                    row = myCommand.ExecuteReader();
                    string Login = "";
                    string Parol = "";
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            Login = row["Login"].ToString();
                            Parol = row["Parol"].ToString();

                        }

                    }
                    else if (comboBox1.Text == "Работник" && textBox1.Text != "" && textBox2.Text != "")

                    {
                        string connect1 = "data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user52_db;persist security info=True;user id=user52_db;password=user52;MultipleActiveResultSets=True;App=EntityFramework";
                        SqlConnection myConnection1 = new SqlConnection(connect1);
                        string command1 = "SELECT Login1, Parol1 FROM KURS_Admin WHERE Login1 = '" + textBox1.Text + "' AND Parol1 = '" + textBox2.Text + "'";
                        myConnection1.Open();
                        SqlCommand myCommand1 = new SqlCommand(command1, myConnection1);
                        SqlDataReader row1;
                        row1 = myCommand1.ExecuteReader();
                        string Login1 = "";
                        string Parol1 = "";
                        if (row1.HasRows)
                        {
                            while (row1.Read())
                            {
                                Login1 = row1["Login1"].ToString();
                                Parol1 = row1["Parol1"].ToString();

                            }


                        }


                    }
                }
            }
        }
    }
}

            
