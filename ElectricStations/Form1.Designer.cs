namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_accept = new System.Windows.Forms.Button();
            this.button_reload = new System.Windows.Forms.Button();
            this.comboAdm = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboDist = new System.Windows.Forms.ComboBox();
            this.button_showInfo = new System.Windows.Forms.Button();
            this.button_clearRoutes = new System.Windows.Forms.Button();
            this.textBox_mInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_nearRoute = new System.Windows.Forms.Button();
            this.button_table = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(304, 2);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaximumSize = new System.Drawing.Size(532, 490);
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(532, 490);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.GMapControl1_Load);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1071, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Уличные";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(856, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Режим отображения карт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(970, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Настроить фильтр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Административный округ";
            // 
            // button_accept
            // 
            this.button_accept.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_accept.Location = new System.Drawing.Point(61, 110);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(114, 32);
            this.button_accept.TabIndex = 8;
            this.button_accept.Text = "Применить";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.Button_accept_Click);
            // 
            // button_reload
            // 
            this.button_reload.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reload.Location = new System.Drawing.Point(230, 110);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(114, 32);
            this.button_reload.TabIndex = 9;
            this.button_reload.Text = "Сбросить";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.Button_reload_Click);
            // 
            // comboAdm
            // 
            this.comboAdm.DropDownWidth = 200;
            this.comboAdm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboAdm.FormattingEnabled = true;
            this.comboAdm.Location = new System.Drawing.Point(223, 16);
            this.comboAdm.Name = "comboAdm";
            this.comboAdm.Size = new System.Drawing.Size(121, 21);
            this.comboAdm.TabIndex = 22;
            this.comboAdm.Text = "Выберите";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(145, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Район";
            // 
            // comboDist
            // 
            this.comboDist.DropDownWidth = 200;
            this.comboDist.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboDist.FormattingEnabled = true;
            this.comboDist.Location = new System.Drawing.Point(223, 71);
            this.comboDist.Name = "comboDist";
            this.comboDist.Size = new System.Drawing.Size(121, 21);
            this.comboDist.TabIndex = 29;
            this.comboDist.Text = "Выберите";
            // 
            // button_showInfo
            // 
            this.button_showInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_showInfo.Location = new System.Drawing.Point(12, 2);
            this.button_showInfo.Name = "button_showInfo";
            this.button_showInfo.Size = new System.Drawing.Size(269, 38);
            this.button_showInfo.TabIndex = 30;
            this.button_showInfo.Text = "Показать информацию";
            this.button_showInfo.UseVisualStyleBackColor = true;
            this.button_showInfo.Click += new System.EventHandler(this.Button_showInfo_Click);
            // 
            // button_clearRoutes
            // 
            this.button_clearRoutes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clearRoutes.Location = new System.Drawing.Point(57, 77);
            this.button_clearRoutes.Name = "button_clearRoutes";
            this.button_clearRoutes.Size = new System.Drawing.Size(283, 38);
            this.button_clearRoutes.TabIndex = 31;
            this.button_clearRoutes.Text = "Сбросить маршруты";
            this.button_clearRoutes.UseVisualStyleBackColor = true;
            this.button_clearRoutes.Click += new System.EventHandler(this.Button_clearRoutes_Click);
            // 
            // textBox_mInfo
            // 
            this.textBox_mInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_mInfo.Location = new System.Drawing.Point(12, 84);
            this.textBox_mInfo.Multiline = true;
            this.textBox_mInfo.Name = "textBox_mInfo";
            this.textBox_mInfo.Size = new System.Drawing.Size(269, 408);
            this.textBox_mInfo.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1005, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Маршруты";
            // 
            // button_nearRoute
            // 
            this.button_nearRoute.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_nearRoute.Location = new System.Drawing.Point(57, 7);
            this.button_nearRoute.Name = "button_nearRoute";
            this.button_nearRoute.Size = new System.Drawing.Size(283, 38);
            this.button_nearRoute.TabIndex = 34;
            this.button_nearRoute.Text = "Проложить маршрут до ближайшей станции подзарядки";
            this.button_nearRoute.UseVisualStyleBackColor = true;
            this.button_nearRoute.Click += new System.EventHandler(this.Button_nearRoute_Click);
            // 
            // button_table
            // 
            this.button_table.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_table.Location = new System.Drawing.Point(12, 40);
            this.button_table.Name = "button_table";
            this.button_table.Size = new System.Drawing.Size(269, 38);
            this.button_table.TabIndex = 35;
            this.button_table.Text = "Список станций";
            this.button_table.UseVisualStyleBackColor = true;
            this.button_table.Click += new System.EventHandler(this.Button_table_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboDist);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboAdm);
            this.groupBox1.Controls.Add(this.button_reload);
            this.groupBox1.Controls.Add(this.button_accept);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(848, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 148);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_nearRoute);
            this.groupBox2.Controls.Add(this.button_clearRoutes);
            this.groupBox2.Location = new System.Drawing.Point(852, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 115);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1261, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_table);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_mInfo);
            this.Controls.Add(this.button_showInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gMapControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ChargeStation v.1.0.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.ComboBox comboAdm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboDist;
        private System.Windows.Forms.Button button_showInfo;
        private System.Windows.Forms.Button button_clearRoutes;
        private System.Windows.Forms.TextBox textBox_mInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_nearRoute;
        private System.Windows.Forms.Button button_table;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

