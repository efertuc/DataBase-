using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
       private OleDbConnection cn = new OleDbConnection(

           @"Provider=Microsoft.ACE.OLEDB.12.0;" +
           @"Data Source=""C:\\Users\\Victory\\source\\repos\\WindowsFormsApp4\\WindowsFormsApp4\\База данных11.accdb"";"+
           @"Jet OLEDB:Create System Database=true;" +
           @"Jet OLEDB:System database=C:\Users\Victory\source\repos\WindowsFormsApp4\WindowsFormsApp4\System.mdw");

        public string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                          "Data Source=C:\\Users\\Victory\\source\\repos\\WindowsFormsApp4\\WindowsFormsApp4\\База данных11.accdb";
        private int act_table = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных11DataSet.Прием". При необходимости она может быть перемещена или удалена.
            this.приемTableAdapter.Fill(this.база_данных11DataSet.Прием);

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Get_Priem()
        {
            string CommandText2 = "SELECT * FROM [Прием]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText2, ConnectionString);
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Прием]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        private void Get_Bilets()
        {
            string CommandText = "SELECT * FROM [Врач]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Врач]");
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
            //dataGridView2.Columns[0].Visible = false; // Прячем поле ID_Bilets
        }
        private void Get_Marshruts()
        {
            string CommandText2 = "SELECT * FROM [Пациент]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText2, ConnectionString);
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Пациент]");
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
        }
        private void Get_Lets()
        {
            string CommandText2 = "SELECT * FROM [ЛечебноеУчреждение]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText2, ConnectionString);
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[ЛечебноеУчреждение]");
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
        }
        private void Get_Protsedura()
        {
            string CommandText2 = "SELECT * FROM [Процедура]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText2, ConnectionString);
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Процедура]");
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
        }
        private void Get_Diagnos()
        {
            string CommandText2 = "SELECT * FROM [Диагноз]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText2, ConnectionString);
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Диагноз]");
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
        }
        private void Get_Zapr1()
        {
            string CommandText2 = "SELECT Врач.ТабельныйНомерВрача, Врач.Специальность FROM Врач;";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText2, ConnectionString);
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Врач]");
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
        }
        private void Get_Zapr2()
        {
            string CommandText2 = "SELECT ТабельныйНомерВрача, Фамилия, Имя, Отчество FROM Врач;";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText2, ConnectionString);
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Врач]");
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
        }
        private void Get_Zapr3()
        {
            string CommandText2 = "SELECT Пациент.НомерСтраховогоПолисаНомерСтраховогоПолиса, Прием.ДатаПриема, " +
                "Прием.ВремяПриема, Прием.[Номер кабинета] FROM Пациент INNER JOIN Прием ON " +
                "Пациент.НомерСтраховогоПолисаНомерСтраховогоПолиса = Прием.НомерСтраховогоПолиса;";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText2, ConnectionString);
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Врач]");
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
        }
   
      
        private void button1_Click(object sender, EventArgs e)
        {
            Get_Bilets();
            act_table = 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Get_Lets();
            act_table = 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Get_Marshruts();
            act_table = 3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Get_Protsedura();
            act_table = 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Get_Diagnos();
            act_table = 5;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Get_Zapr1();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Get_Zapr2();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Get_Zapr3();
        }


        private void Delete_Vrac(String family)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM Врач WHERE ТабельныйНомерВрача=@Family";
                cmd.Parameters.AddWithValue("@Family", family);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");

            }
            finally
            {
                cn.Close();
            }
        }
        private void Delete_Priem(String s_otpr, String vrac, String num)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM Прием WHERE[Номер процедуры]=@Family AND ТабельныйНомерВрача=@name AND НомерСтраховогоПолиса=@num ";
                cmd.Parameters.AddWithValue("@Family", s_otpr);
                cmd.Parameters.AddWithValue("@name", vrac);
                cmd.Parameters.AddWithValue("@num", num);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");

            }
            finally
            {
                cn.Close();
            }
        }
        private void Add_Priem(DateTime vremja, DateTime vremja_otpr, string cabinet, string famil, string name, string otset, string d_r, string adres)
        {
            string vremja_2 = Convert.ToString(vremja);
            string s_otpr = Convert.ToString(vremja_otpr);
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                "INSERT INTO Прием(ДатаПриема, ВремяПриема,[Номер кабинета], ТабельныйНомерВрача, [Номер лечебного учреждения], НомерСтраховогоПолиса,ИдентификаторДиагноза,[Номер процедуры])" +
                " VALUES (@Family, @Time,@Cab, @Fam,@Name, @Otset,@Dr, @Adres)";
                cmd.Parameters.AddWithValue("@Family", vremja_2);
                cmd.Parameters.AddWithValue("@Time", s_otpr);
                cmd.Parameters.AddWithValue("@Cab", cabinet);
                cmd.Parameters.AddWithValue("@Fam", famil);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Otset", otset);
                cmd.Parameters.AddWithValue("@Dr", d_r);
                cmd.Parameters.AddWithValue("@Adres", adres);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");

            }
            finally
            {
                cn.Close();
            }
        }
        private void Update_Priem(DateTime vremja, string time, string cabinet, string famil, string name, string otset, string d_r, string adres)
        {
            string vremja_2 = Convert.ToString(vremja);
            
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                "UPDATE Прием SET ДатаПриема=@Family, ВремяПриема=@Time,[Номер кабинета]=@Cab , ТабельныйНомерВрача=@Fam, [Номер лечебного учреждения]=@Name, НомерСтраховогоПолиса=@Otset," +
                "ИдентификаторДиагноза=@Dr,[Номер процедуры]=@Adres " +
                " WHERE ДатаПриема=@Family  AND [Номер кабинета]=@Cab ";
                cmd.Parameters.AddWithValue("@Family", vremja_2);
                cmd.Parameters.AddWithValue("@Time", time);
                cmd.Parameters.AddWithValue("@Cab", cabinet);
                cmd.Parameters.AddWithValue("@Fam", famil);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Otset", otset);
                cmd.Parameters.AddWithValue("@Dr", d_r);
                cmd.Parameters.AddWithValue("@Adres", adres);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");

            }
            finally
            {
                cn.Close();
            }
        }
        private void Add_Brath(string nomer, string nlets, string famil, string name, string otshe, string spets)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                "INSERT INTO Врач(ТабельныйНомерВрача, НомерЛечебногоУчреждения, Фамилия, Имя, Отчество, Специальность)" +
                " VALUES (@Family, @Time, @Fam,@Name, @Otset,@Dr)";
                cmd.Parameters.AddWithValue("@Family", nomer);
                cmd.Parameters.AddWithValue("@Time", nlets);
            
                cmd.Parameters.AddWithValue("@Fam", famil);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Otset", otshe);
                cmd.Parameters.AddWithValue("@Dr", spets);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");
                Console.WriteLine($"Исключение: {ex.Message}");

            }
            finally
            {
                cn.Close();
            }

        }
        private void Upp_Brath(string nomer, string nlets, string famil, string name, string otshe, string spets)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                "UPDATE Врач SET ТабельныйНомерВрача=@Family,НомерЛечебногоУчреждения=@Time, Фамилия=@Fam," +
                "Имя=@Name,Отчество=@Otset , Специальность=@Dr" +
                " WHERE  ТабельныйНомерВрача=@Family ";
                cmd.Parameters.AddWithValue("@Family", nomer);
                cmd.Parameters.AddWithValue("@Time", nlets);

                cmd.Parameters.AddWithValue("@Fam", famil);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Otset", otshe);
                cmd.Parameters.AddWithValue("@Dr", spets);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");

            }
            finally
            {
                cn.Close();
            }

        }
        private void Add_Patsient(string num_marsh, string famil, string name, string otset, string d_r, string adres)
        {

            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                "INSERT INTO Пациент([НомерСтраховогоПолисаНомерСтраховогоПолиса], Фамилия, Имя, Отчество, ДатаРождения, Адрес)" +
                " VALUES (@Family, @Time,@Fam,@Name, @Otset,@Dr)";
                cmd.Parameters.AddWithValue("@Family", num_marsh);
                cmd.Parameters.AddWithValue("@Time", famil);

                cmd.Parameters.AddWithValue("@Fam", name);
                cmd.Parameters.AddWithValue("@Name", otset);
                cmd.Parameters.AddWithValue("@Otset", d_r);
                cmd.Parameters.AddWithValue("@Dr", adres);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");

            }
            finally
            {
                cn.Close();
            }
          
        }
        private void Upp_Patsient(string num_marsh, string famil, string name, string otset, string d_r, string adres)
        {

            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                "UPDATE Пациент SET НомерСтраховогоПолисаНомерСтраховогоПолиса=@Family,Фамилия=@Time, Имя=@Fam," +
                "Отчество=@Name,ДатаРождения=@Otset , Адрес=@Dr" +
                " WHERE  НомерСтраховогоПолисаНомерСтраховогоПолиса=@Family ";
               
                cmd.Parameters.AddWithValue("@Family", num_marsh);
                cmd.Parameters.AddWithValue("@Time", famil);

                cmd.Parameters.AddWithValue("@Fam", name);
                cmd.Parameters.AddWithValue("@Name", otset);
                cmd.Parameters.AddWithValue("@Otset", d_r);
                cmd.Parameters.AddWithValue("@Dr", adres);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");

            }
            finally
            {
                cn.Close();
            }

        }
        private void Delete_Patsient(String family)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM Пациент WHERE НомерСтраховогоПолисаНомерСтраховогоПолиса=@Family";
                cmd.Parameters.AddWithValue("@Family", family);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");

            }
            finally
            {
                cn.Close();
            }
        }
        private void Add_Lets(string num, string model, string znak, string k_mest)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                "INSERT INTO ЛечебноеУчреждение([НомерЛечебногоУчреждения], [Тип лечебного учреждения], [Специализация лечебного учреждения], [Адрес])" +
                " VALUES (@Family, @Time, @Fam,@Name)";
                cmd.Parameters.AddWithValue("@Family", num);
                cmd.Parameters.AddWithValue("@Time", model);

                cmd.Parameters.AddWithValue("@Fam", znak);
                cmd.Parameters.AddWithValue("@Name", k_mest);
                cmd.ExecuteNonQuery();


            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");

            }
            finally
            {
                cn.Close();
            }

        }
        private void Upp_Lets(string num, string model, string znak, string k_mest)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                "UPDATE ЛечебноеУчреждение SET НомерЛечебногоУчреждения=@Family,[Тип лечебного учреждения]=@Time, [Специализация лечебного учреждения]=@Fam," +
                "Адрес=@Name WHERE  НомерЛечебногоУчреждения=@Family ";
               
                cmd.Parameters.AddWithValue("@Family", num);
                cmd.Parameters.AddWithValue("@Time", model);

                cmd.Parameters.AddWithValue("@Fam", znak);
                cmd.Parameters.AddWithValue("@Name", k_mest);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");
            }
            finally
            {
                cn.Close();
            }

        }
        private void Delete_Lets(String family)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM ЛечебноеУчреждение WHERE НомерЛечебногоУчреждения=@Family";
                cmd.Parameters.AddWithValue("@Family", family);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");

            }
            finally
            {
                cn.Close();
            }
        }
        private void Add_Prots(string num, string model, string znak, string k_mest)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                "INSERT INTO Процедура([НомерПроцедуры], Название, Длительность, Цена)" +
                " VALUES (@Family, @Time, @Fam,@Name)";
                cmd.Parameters.AddWithValue("@Family", num);
                cmd.Parameters.AddWithValue("@Time", model);

                cmd.Parameters.AddWithValue("@Fam", znak);
                cmd.Parameters.AddWithValue("@Name", k_mest);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");

            }

            finally
            {
                cn.Close();
            }

        }
        private void Upp_Prots(string num, string model, string znak, string k_mest)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                    "UPDATE Процедура SET НомерПроцедуры=@Family,Название=@Time, Длительность=@Fam," +
                "Цена=@Name WHERE  НомерПроцедуры=@Family ";
               
                cmd.Parameters.AddWithValue("@Family", num);
                cmd.Parameters.AddWithValue("@Time", model);

                cmd.Parameters.AddWithValue("@Fam", znak);
                cmd.Parameters.AddWithValue("@Name", k_mest);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");

            }
            finally
            {
                cn.Close();
            }

        }
        private void Delete_Prots(String family)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM Процедура WHERE НомерПроцедуры=@Family";
                cmd.Parameters.AddWithValue("@Family", family);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");

            }
            finally
            {
                cn.Close();
            }
        }
        private void Add_Diagnos(string num, string model, string znak)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                "INSERT INTO Диагноз(ИдентификаторДиагноза, ОписаниеДиагноза, Лечение)" +
                " VALUES (@Family, @Time, @Fam)";
                cmd.Parameters.AddWithValue("@Family", num);
                cmd.Parameters.AddWithValue("@Time", model);

                cmd.Parameters.AddWithValue("@Fam", znak);
 
                cmd.ExecuteNonQuery();


            }

            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");

            }
            finally
            {
                cn.Close();
            }

        }
        private void Upp_Diagnos(string num, string model, string znak)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                    "UPDATE Диагноз SET ИдентификаторДиагноза=@Family,ОписаниеДиагноза=@Time, Лечение=@Fam," +
                " WHERE  ИдентификаторДиагноза=@Family ";
                
                cmd.Parameters.AddWithValue("@Family", num);
                cmd.Parameters.AddWithValue("@Time", model);

                cmd.Parameters.AddWithValue("@Fam", znak);

                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");
            }
            finally
            {
                cn.Close();
            }

        }
        private void Delete_Diagnos(String family)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM Диагноз WHERE ИдентификаторДиагноза=@Family";
                cmd.Parameters.AddWithValue("@Family", family);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show($"Исключение: {ex.Message}");

            }
            finally
            {
                cn.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (act_table == 1) // обрабатываем таблицу "Билет"
            {
                AddVrac f = new AddVrac();

                if (f.ShowDialog() == DialogResult.OK)
       
                {
                    // добавляем данные в таблицу "Врач"
                    if (f.textBox2.Text != "" & f.textBox3.Text != "" & f.textBox4.Text != "" & f.textBox5.Text != "" & f.textBox6.Text != "")
                    {
                        Add_Brath(f.textBox1.Text, f.textBox2.Text, f.textBox3.Text, f.textBox4.Text, f.textBox5.Text, f.textBox6.Text);
                        Get_Bilets();
                    }
                    else MessageBox.Show("Вы не заполнили поля, попробуйте снова");
                }
            }

            else
                if (act_table == 2) // обрабатываем таблицу "Пациент"
            {
                AddLec f = new AddLec();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // добавляем данные в таблицу "Лечучрежд"
                    if ( f.textBox2.Text != "" & f.textBox3.Text != "" & f.textBox4.Text != "")
                    {
                        Add_Lets(f.textBox1.Text, f.textBox2.Text, f.textBox3.Text, f.textBox4.Text);
                        Get_Lets();
                    }
                    else MessageBox.Show("Вы не заполнили поля, попробуйте снова");
                }
            }
            else
                    if (act_table == 3) // обрабатываем таблицу "Автобус"
            {
                AddPac f = new AddPac();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    if (f.textBox2.Text != "" & f.textBox3.Text != "" & f.textBox4.Text != "" && f.textBox5.Text != "")
                    {
                        // добавляем данные в таблицу "Автобус"
                        Add_Patsient(f.textBox1.Text, f.textBox2.Text, f.textBox3.Text, f.textBox4.Text,
                       Convert.ToString(f.dateTimePicker1.Value), f.textBox5.Text);
                        Get_Marshruts();
                    }
                    else MessageBox.Show("Вы не заполнили поля, попробуйте снова");
                }
            }
            else
                if (act_table == 4) // обрабатываем таблицу "Водитель"
            {
                AddProc f = new AddProc();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // добавляем данные в таблицу "Водитель"
                    Add_Prots(f.textBox1.Text, f.textBox2.Text, Convert.ToString(f.dateTimePicker3.Value), f.textBox4.Text);
                    Get_Protsedura();
                }
            }
            else
                    if (act_table == 5) // обрабатываем таблицу "Диспетчер"
            {
                AddDiagnos f = new AddDiagnos();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    if (f.textBox2.Text != "" & f.textBox3.Text != "")
                    {
                        // добавляем данные в таблицу "Диспетчер"
                        Add_Diagnos(f.textBox1.Text, f.textBox2.Text, f.textBox3.Text);
                        Get_Diagnos();
                    }
                    else MessageBox.Show("Вы не заполнили поля, попробуйте снова");
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {

            if (act_table == 1) // обрабатываем таблицу "Билет"
            {
                DelID f1 = new DelID();
                Form4 f = new Form4();
                if (f1.ShowDialog() == DialogResult.OK)
                {
                    if (f1.textBox1.Text != "")
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                        
                            if (f.textBox1.Text != "" & f.textBox2.Text != "" & f.textBox3.Text != "" & f.textBox4.Text != "" & f.textBox5.Text != "")
                            {
                                // добавляем данные в таблицу "Врач"
                                Upp_Brath(f1.textBox1.Text, f.textBox1.Text, f.textBox2.Text, f.textBox3.Text, f.textBox4.Text, f.textBox5.Text);
                                Get_Bilets();
                            }
                            else MessageBox.Show("Вы не заполнили поля, попробуйте снова");
                        }
                       
                    }
                    else MessageBox.Show("Вы не ввели первичный ключ");
                }

            }
           
            else
                if (act_table == 3) // обрабатываем таблицу "Пациент"
            {
                DelID f1 = new DelID();
                UppPac f = new UppPac();
                if (f1.ShowDialog() == DialogResult.OK)
                {
                    if (f1.textBox1.Text != "")
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            if (f.textBox1.Text != "" & f.textBox2.Text != "" & f.textBox3.Text != "" &  f.textBox5.Text != "")
                            {
                                // добавляем данные в таблицу "Врач"
                                Upp_Patsient(f1.textBox1.Text, f.textBox1.Text, f.textBox2.Text, f.textBox3.Text, Convert.ToString(f.dateTimePicker1.Value), f.textBox5.Text);
                                Get_Marshruts();
                            }
                        }
                        else MessageBox.Show("Вы не заполнили поля, попробуйте снова");
                    }
                    else MessageBox.Show("Вы не ввели первичный ключ");
                }
     
            }
            else
                    if (act_table == 2) // обрабатываем таблицу "Автобус"
            {
                DelID f1 = new DelID();
                UppLets f = new UppLets();
                if (f1.ShowDialog() == DialogResult.OK)
                {
                    if (f1.textBox1.Text != "")
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            if (f.textBox1.Text != "" & f.textBox2.Text != "" & f.textBox3.Text != "" )
                            {
                                // добавляем данные в таблицу "Врач"
                                Upp_Lets(f1.textBox1.Text, f.textBox1.Text, f.textBox2.Text, f.textBox3.Text);
                                Get_Lets();
                            }
                            else MessageBox.Show("Вы не заполнили поля, попробуйте снова");
                        }
                    }
                    else MessageBox.Show("Вы не ввели первичный ключ");
                }
               
            }
            else
                if (act_table == 4) // обрабатываем таблицу "Водитель"
            {
                DelID f1 = new DelID();
                UppP f = new UppP();
                if (f1.ShowDialog() == DialogResult.OK)
                {
                    if (f1.textBox1.Text != "")
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            if (f.textBox1.Text != "" & f.textBox3.Text != "")
                            {
                                // добавляем данные в таблицу "Врач"
                                Upp_Prots(f1.textBox1.Text, f.textBox1.Text, Convert.ToString(f.dateTimePicker3.Value), f.textBox3.Text);
                                Get_Protsedura();
                            }
                            else MessageBox.Show("Вы не заполнили поля, попробуйте снова");
                        }
                    }
                    else MessageBox.Show("Вы не ввели первичный ключ");
                }
              
            }
            else
                    if (act_table == 5) // обрабатываем таблицу "Диспетчер"
            {
                DelID f1 = new DelID();
                UppD f = new UppD();
                if (f1.ShowDialog() == DialogResult.OK)
                {
                    if (f1.textBox1.Text != "")
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            if (f.textBox1.Text != "" & f.textBox2.Text != "")
                            {
                                // добавляем данные в таблицу "Врач"
                                Upp_Diagnos(f1.textBox1.Text, f.textBox1.Text, f.textBox2.Text);
                                Get_Diagnos();
                            }
                            else MessageBox.Show("Вы не заполнили поля, попробуйте снова");
                        }
                    }
                    else MessageBox.Show("Вы не ввели первичный ключ");
                }
               
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int n;
            bool isNumeric;
            if (act_table == 1) // обрабатываем таблицу "Билет"
            {
                DelID f = new DelID();
                isNumeric = int.TryParse(textBox1.Text, out n);
               
                    if (f.ShowDialog() == DialogResult.OK)
                {
                    if (isNumeric)
                    {
                        // добавляем данные в таблицу "Врач"
                        Delete_Vrac(f.textBox1.Text);
                        Get_Bilets();
                    }
                    else MessageBox.Show("Введите число");
                }
            }
            else
                if (act_table == 2) // обрабатываем таблицу "Пациент"
            {
                DelID f = new DelID();
                isNumeric = int.TryParse(textBox1.Text, out n);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    if (isNumeric)
                    {
                        // добавляем данные в таблицу "Лечучрежд"

                        Delete_Lets(f.textBox1.Text);
                        Get_Lets();
                    }
                    else MessageBox.Show("Введите число");
                }
            }
            else
                    if (act_table == 3) // обрабатываем таблицу "Автобус"
            {
                DelID f = new DelID();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // добавляем данные в таблицу "Автобус"
                    Delete_Patsient(f.textBox1.Text);
                    Get_Marshruts();
                }
            }
            else
                if (act_table == 4) // обрабатываем таблицу "Водитель"
            {
                DelID f = new DelID();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // добавляем данные в таблицу "Водитель"
                    Delete_Prots(f.textBox1.Text);
                    Get_Protsedura();
                }
            }
            else
                    if (act_table == 5) // обрабатываем таблицу "Диспетчер"
            {
                DelID f = new DelID();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // добавляем данные в таблицу "Диспетчер"
                    Delete_Diagnos(f.textBox1.Text);
                    Get_Diagnos();
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            AddPriemcs f = new AddPriemcs();

            if (f.ShowDialog() == DialogResult.OK)
            {
                if (f.textBox1.Text != "" & f.textBox2.Text != "" & f.textBox3.Text != ""& f.textBox4.Text != "" & f.textBox5.Text != ""& f.textBox6.Text != "" )
                {
                    // добавляем данные в таблицу "Врач"
                    Add_Priem(f.dateTimePicker1.Value, f.dateTimePicker3.Value, f.textBox1.Text, f.textBox2.Text, f.textBox3.Text, f.textBox4.Text, f.textBox5.Text, f.textBox6.Text);
                    Get_Priem();
                }
                else MessageBox.Show("Вы не заполнили поля, попробуйте снова");
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            UppPriemcs f = new UppPriemcs();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                if (f1.textBox1.Text != "")
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        if (f.textBox1.Text != "" & f.textBox2.Text != "" & f.textBox3.Text != "" & f.textBox4.Text != "" & f.textBox5.Text != "")
                        {
                            // добавляем данные в таблицу "Врач"

                            Update_Priem(f1.dateTimePicker1.Value, Convert.ToString(f.dateTimePicker3.Value), f1.textBox1.Text, f.textBox1.Text, f.textBox2.Text, f.textBox3.Text, f.textBox4.Text, f.textBox5.Text);
                            Get_Priem();
                        }
                        else MessageBox.Show("Вы не заполнили поля, попробуйте снова");
                    }
                }
                else MessageBox.Show("Вы не ввели первичный ключ");
            }
        }

        private void Paraam1()

        {
            string CommandText2 = "SELECT * FROM Врач  WHERE НомерЛечебногоУчреждения IS NOT NULL ";
            //string CommandText2 = "EXEC [Параметр  Поиск врачей по лечучрежд] IS NOT NULL";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText2, ConnectionString);
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Врач]");
            dataGridView2.DataSource = ds.Tables["[Врач]"].DefaultView;
            
        }
        private void Paraam1_1()

        {
            //string CommandText2 = "SELECT * FROM Врач  WHERE НомерЛечебногоУчреждения IS NOT NULL ";
            string CommandText2 = "EXEC [Параметр  Поиск врачей по лечучрежд] '" + textBox1.Text + "' ";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText2, ConnectionString);
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Врач]");
            dataGridView2.DataSource = ds.Tables["[Врач]"].DefaultView;

        }
        private void Paraam2()

        {
            string CommandText2 = "SELECT * FROM Прием ";
            //string CommandText2 = "EXEC [Параметр  Поиск врачей по лечучрежд] IS NOT NULL";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText2, ConnectionString);
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Врач]");
            dataGridView2.DataSource = ds.Tables["[Врач]"].DefaultView;

        }
        private void Paraam2_2()

        {
            //string CommandText2 = "SELECT * FROM Врач  WHERE НомерЛечебногоУчреждения IS NOT NULL ";
            string CommandText2 = "EXEC [Параметр Прием по полису] '" + textBox2.Text + "' ";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText2, ConnectionString);
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Врач]");
            dataGridView2.DataSource = ds.Tables["[Врач]"].DefaultView;

        }
        private void Paraam3()

        {
            string CommandText2 = "SELECT * FROM Прием ";
            //string CommandText2 = "EXEC [Параметр  Поиск врачей по лечучрежд] IS NOT NULL";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText2, ConnectionString);
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Врач]");
            dataGridView2.DataSource = ds.Tables["[Врач]"].DefaultView;

        }
        private void Paraam3_3()

        {
            //string CommandText2 = "SELECT * FROM Врач  WHERE НомерЛечебногоУчреждения IS NOT NULL ";
            string CommandText2 = "EXEC [Параметр Приемы врача] '" + textBox3.Text + "' ";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText2, ConnectionString);
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "[Врач]");
            dataGridView2.DataSource = ds.Tables["[Врач]"].DefaultView;

        }
   
        private void button18_Click(object sender, EventArgs e)
        {
            Add_Brath("12515", "45854", "Иванов", "Ivan", "Ivanovitc", "Zelegrad");
            Get_Bilets();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            Delete_Vrac("12515");
            Get_Bilets();
        }
      
        private void button11_Click(object sender, EventArgs e)
        {
    
            DelPriemcs f = new DelPriemcs();
            if (f.ShowDialog() == DialogResult.OK)
            {
                // добавляем данные в таблицу "Диспетчер"

                Delete_Priem(f.textBox3.Text, f.textBox1.Text, f.textBox2.Text);
                Get_Priem();
            }
        }

        private void Pa1()
        {
            
            //string CommandText2 = "SELECT * FROM Врач WHERE НомерЛечебногоУчреждения";
            //if (textBox1.Text != "")  // если набран текст в поле фильтра
            //{
            //    CommandText2 = CommandText2 + " AND (Врач.НомерЛечебногоУчреждения = ?) ";

            //}
            //OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText2, ConnectionString);
            //DataSet ds = new DataSet();  // создаем объект DataSet
            //dataAdapter.Fill(ds, "[Врач]");
            //dataGridView2.DataSource = ds.Tables["[Врач]"].DefaultView;
            cn.Open();
            try
            {
                
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                
                cmd.CommandText = "SELECT * FROM Врач WHERE НомерЛечебногоУчреждения";
                if (textBox1.Text != "")  // если набран текст в поле фильтра
                {
                    cmd.CommandText = cmd.CommandText + " AND (Врач.НомерЛечебногоУчреждения = Номер ) ";

                }
                cmd.Parameters.AddWithValue("Номер", textBox1.Text);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
            

            //cn.Open();
            //try
            //{
            //    OleDbCommand cmd = new OleDbCommand();
            //    cmd.Connection = cn;
            //    cmd.CommandText =
            //     "SELECT * FROM Врач WHERE НомерЛечебногоУчреждения LIKE @Templ";

            //    cmd.Parameters.AddWithValue("@Templ", textBox1.Text);
            //    cmd.ExecuteNonQuery();
            //}
            //finally
            //{
            //    cn.Close();
            //}
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "") {
                int n;
                bool isNumeric = int.TryParse(textBox1.Text, out n);
                if(isNumeric) Paraam1_1();
                else  MessageBox.Show("Введите число");

            }
                
            else Paraam1();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int n;
                bool isNumeric = int.TryParse(textBox1.Text, out n);
                if (isNumeric) Paraam2_2();
                else MessageBox.Show("Введите число");

            }       
            else Paraam2();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int n;
                bool isNumeric = int.TryParse(textBox1.Text, out n);
                if (isNumeric) Paraam3_3();
                else MessageBox.Show("Введите число");

            }
           
            else Paraam3();
        }
        private void button22_Click(object sender, EventArgs e)
        {

        }

      

        private void Delete_Pac_2(String family, String name, String Otset)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM Пациент WHERE Фамилия LIKE @Family AND Имя LIKE @Name AND Отчество LIKE @Otset ";
                cmd.Parameters.AddWithValue("@Family", family);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Otset", Otset);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }
        private void Delete3(String family)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM Процедура WHERE Название LIKE @Family";
                cmd.Parameters.AddWithValue("@Family", family);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }
        private void Delete4(String family)
        {
            cn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM Врач WHERE НомерЛечебногоУчреждения LIKE @Family";
                cmd.Parameters.AddWithValue("@Family", family);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }


        private void button20_Click(object sender, EventArgs e)
        {
            del3 f = new del3();

            if (f.ShowDialog() == DialogResult.OK)
            {
                // добавляем данные в таблицу "Врач"
                Delete_Pac_2( f.textBox1.Text, f.textBox2.Text, f.textBox3.Text);
                Get_Marshruts();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            del4cs f = new del4cs();

            if (f.ShowDialog() == DialogResult.OK)
            {
                // добавляем данные в таблицу "Врач"
                Delete3(f.textBox1.Text);
                Get_Protsedura();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DelID f = new DelID();

            if (f.ShowDialog() == DialogResult.OK)
            {
                // добавляем данные в таблицу "Врач"
                Delete4(f.textBox1.Text);
                Get_Marshruts();
            }
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            Upp_Brath("12515", "45854", "Petrov", "Petr", "Ivanovitc", "Zelegrad");
            Get_Bilets();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
    

    
}
