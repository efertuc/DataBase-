namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.датаПриемаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПриемаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКабинетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.табельныйНомерВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЛечебногоУчрежденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерСтраховогоПолисаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.идентификаторДиагнозаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерПроцедурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приемBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данных11DataSet = new WindowsFormsApp4.База_данных11DataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.приемTableAdapter = new WindowsFormsApp4.База_данных11DataSetTableAdapters.ПриемTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button22 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button23 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приемBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датаПриемаDataGridViewTextBoxColumn,
            this.времяПриемаDataGridViewTextBoxColumn,
            this.номерКабинетаDataGridViewTextBoxColumn,
            this.табельныйНомерВрачаDataGridViewTextBoxColumn,
            this.номерЛечебногоУчрежденияDataGridViewTextBoxColumn,
            this.номерСтраховогоПолисаDataGridViewTextBoxColumn,
            this.идентификаторДиагнозаDataGridViewTextBoxColumn,
            this.номерПроцедурыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.приемBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridView1.Location = new System.Drawing.Point(26, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(841, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // датаПриемаDataGridViewTextBoxColumn
            // 
            this.датаПриемаDataGridViewTextBoxColumn.DataPropertyName = "ДатаПриема";
            this.датаПриемаDataGridViewTextBoxColumn.HeaderText = "ДатаПриема";
            this.датаПриемаDataGridViewTextBoxColumn.Name = "датаПриемаDataGridViewTextBoxColumn";
            // 
            // времяПриемаDataGridViewTextBoxColumn
            // 
            this.времяПриемаDataGridViewTextBoxColumn.DataPropertyName = "ВремяПриема";
            this.времяПриемаDataGridViewTextBoxColumn.HeaderText = "ВремяПриема";
            this.времяПриемаDataGridViewTextBoxColumn.Name = "времяПриемаDataGridViewTextBoxColumn";
            // 
            // номерКабинетаDataGridViewTextBoxColumn
            // 
            this.номерКабинетаDataGridViewTextBoxColumn.DataPropertyName = "Номер кабинета";
            this.номерКабинетаDataGridViewTextBoxColumn.HeaderText = "Номер кабинета";
            this.номерКабинетаDataGridViewTextBoxColumn.Name = "номерКабинетаDataGridViewTextBoxColumn";
            // 
            // табельныйНомерВрачаDataGridViewTextBoxColumn
            // 
            this.табельныйНомерВрачаDataGridViewTextBoxColumn.DataPropertyName = "ТабельныйНомерВрача";
            this.табельныйНомерВрачаDataGridViewTextBoxColumn.HeaderText = "ТабельныйНомерВрача";
            this.табельныйНомерВрачаDataGridViewTextBoxColumn.Name = "табельныйНомерВрачаDataGridViewTextBoxColumn";
            // 
            // номерЛечебногоУчрежденияDataGridViewTextBoxColumn
            // 
            this.номерЛечебногоУчрежденияDataGridViewTextBoxColumn.DataPropertyName = "Номер лечебного учреждения";
            this.номерЛечебногоУчрежденияDataGridViewTextBoxColumn.HeaderText = "Номер лечебного учреждения";
            this.номерЛечебногоУчрежденияDataGridViewTextBoxColumn.Name = "номерЛечебногоУчрежденияDataGridViewTextBoxColumn";
            // 
            // номерСтраховогоПолисаDataGridViewTextBoxColumn
            // 
            this.номерСтраховогоПолисаDataGridViewTextBoxColumn.DataPropertyName = "НомерСтраховогоПолиса";
            this.номерСтраховогоПолисаDataGridViewTextBoxColumn.HeaderText = "НомерСтраховогоПолиса";
            this.номерСтраховогоПолисаDataGridViewTextBoxColumn.Name = "номерСтраховогоПолисаDataGridViewTextBoxColumn";
            // 
            // идентификаторДиагнозаDataGridViewTextBoxColumn
            // 
            this.идентификаторДиагнозаDataGridViewTextBoxColumn.DataPropertyName = "ИдентификаторДиагноза";
            this.идентификаторДиагнозаDataGridViewTextBoxColumn.HeaderText = "ИдентификаторДиагноза";
            this.идентификаторДиагнозаDataGridViewTextBoxColumn.Name = "идентификаторДиагнозаDataGridViewTextBoxColumn";
            // 
            // номерПроцедурыDataGridViewTextBoxColumn
            // 
            this.номерПроцедурыDataGridViewTextBoxColumn.DataPropertyName = "Номер процедуры";
            this.номерПроцедурыDataGridViewTextBoxColumn.HeaderText = "Номер процедуры";
            this.номерПроцедурыDataGridViewTextBoxColumn.Name = "номерПроцедурыDataGridViewTextBoxColumn";
            // 
            // приемBindingSource
            // 
            this.приемBindingSource.DataMember = "Прием";
            this.приемBindingSource.DataSource = this.база_данных11DataSet;
            // 
            // база_данных11DataSet
            // 
            this.база_данных11DataSet.DataSetName = "База_данных11DataSet";
            this.база_данных11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridView2.Location = new System.Drawing.Point(26, 355);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(841, 312);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // приемTableAdapter
            // 
            this.приемTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(904, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 225);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблицы";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Диагноз";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Процедура";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Пациент";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Лечебное учреждение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Врач";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(904, 442);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 150);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 107);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(187, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Удалить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7, 63);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(187, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Изменит";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Location = new System.Drawing.Point(904, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 144);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Прием";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(7, 105);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(187, 23);
            this.button11.TabIndex = 2;
            this.button11.Text = "Удалить";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(7, 64);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(187, 23);
            this.button10.TabIndex = 1;
            this.button10.Text = "Изменить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(7, 22);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(187, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "Добавить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button22);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.button19);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Controls.Add(this.button17);
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Location = new System.Drawing.Point(1123, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 401);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Запросы";
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(8, 321);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(311, 23);
            this.button22.TabIndex = 11;
            this.button22.Text = "Изменить Иванова Ивана";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(190, 236);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 8;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(7, 359);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(312, 23);
            this.button19.TabIndex = 7;
            this.button19.Text = "Удалить Иванова ИВана ";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(7, 278);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(312, 23);
            this.button18.TabIndex = 6;
            this.button18.Text = "Длобавить Врача И.И.И";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(8, 236);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(163, 23);
            this.button17.TabIndex = 5;
            this.button17.Text = "Приемы врача";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(7, 153);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(162, 23);
            this.button16.TabIndex = 4;
            this.button16.Text = "Поиск врачей по леч учреждению";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(8, 194);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(162, 23);
            this.button15.TabIndex = 3;
            this.button15.Text = "Приемы пациента";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(7, 105);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(189, 23);
            this.button14.TabIndex = 2;
            this.button14.Text = "Запрос 3";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(7, 64);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(189, 23);
            this.button13.TabIndex = 1;
            this.button13.Text = "Запрос 2";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(7, 21);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(189, 23);
            this.button12.TabIndex = 0;
            this.button12.Text = "Запрос 1";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button23);
            this.groupBox5.Controls.Add(this.button21);
            this.groupBox5.Controls.Add(this.button20);
            this.groupBox5.Location = new System.Drawing.Point(1123, 442);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(217, 150);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Альтернативное удаление";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(7, 107);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(189, 23);
            this.button23.TabIndex = 2;
            this.button23.Text = "Врачи из леч учреждаения";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(7, 62);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(189, 23);
            this.button21.TabIndex = 1;
            this.button21.Text = "Название процедуры";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(7, 21);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(189, 23);
            this.button20.TabIndex = 0;
            this.button20.Text = "ФИО пациента";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1460, 709);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приемBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private База_данных11DataSet база_данных11DataSet;
        private System.Windows.Forms.BindingSource приемBindingSource;
        private База_данных11DataSetTableAdapters.ПриемTableAdapter приемTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПриемаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПриемаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКабинетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn табельныйНомерВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЛечебногоУчрежденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерСтраховогоПолисаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn идентификаторДиагнозаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПроцедурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button22;
    }
}

