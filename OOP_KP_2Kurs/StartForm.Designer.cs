
namespace OOP_KP_2Kurs
{
    partial class StartForm
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
            this.railwayTransportBtn = new System.Windows.Forms.Button();
            this.BusBtn = new System.Windows.Forms.Button();
            this.riverTramBtn = new System.Windows.Forms.Button();
            this.informationListBox = new System.Windows.Forms.ListBox();
            this.numberOfBusTB = new System.Windows.Forms.TextBox();
            this.numberOfBusBtn = new System.Windows.Forms.Button();
            this.infoRouteBusLb = new System.Windows.Forms.Label();
            this.pointDepartueTb = new System.Windows.Forms.TextBox();
            this.pointDepartueLb = new System.Windows.Forms.Label();
            this.pointDepartueBtn = new System.Windows.Forms.Button();
            this.pointArrivalBtn = new System.Windows.Forms.Button();
            this.pointArrivalLb = new System.Windows.Forms.Label();
            this.pointArrivalTb = new System.Windows.Forms.TextBox();
            this.editingBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // railwayTransportBtn
            // 
            this.railwayTransportBtn.Location = new System.Drawing.Point(23, 491);
            this.railwayTransportBtn.Name = "railwayTransportBtn";
            this.railwayTransportBtn.Size = new System.Drawing.Size(267, 30);
            this.railwayTransportBtn.TabIndex = 0;
            this.railwayTransportBtn.Text = "Железнодорожный транспорт";
            this.railwayTransportBtn.UseVisualStyleBackColor = true;
            this.railwayTransportBtn.Click += new System.EventHandler(this.railwayTransportBtn_Click);
            // 
            // BusBtn
            // 
            this.BusBtn.Location = new System.Drawing.Point(359, 491);
            this.BusBtn.Name = "BusBtn";
            this.BusBtn.Size = new System.Drawing.Size(267, 30);
            this.BusBtn.TabIndex = 1;
            this.BusBtn.Text = "Автобусы";
            this.BusBtn.UseVisualStyleBackColor = true;
            this.BusBtn.Click += new System.EventHandler(this.BusBtn_Click);
            // 
            // riverTramBtn
            // 
            this.riverTramBtn.Location = new System.Drawing.Point(686, 491);
            this.riverTramBtn.Name = "riverTramBtn";
            this.riverTramBtn.Size = new System.Drawing.Size(267, 30);
            this.riverTramBtn.TabIndex = 2;
            this.riverTramBtn.Text = "Речные трамваи";
            this.riverTramBtn.UseVisualStyleBackColor = true;
            this.riverTramBtn.Click += new System.EventHandler(this.riverTramBtn_Click);
            // 
            // informationListBox
            // 
            this.informationListBox.FormattingEnabled = true;
            this.informationListBox.HorizontalScrollbar = true;
            this.informationListBox.ItemHeight = 16;
            this.informationListBox.Location = new System.Drawing.Point(13, 13);
            this.informationListBox.Name = "informationListBox";
            this.informationListBox.Size = new System.Drawing.Size(623, 468);
            this.informationListBox.TabIndex = 3;
            // 
            // numberOfBusTB
            // 
            this.numberOfBusTB.Location = new System.Drawing.Point(653, 41);
            this.numberOfBusTB.Name = "numberOfBusTB";
            this.numberOfBusTB.Size = new System.Drawing.Size(107, 22);
            this.numberOfBusTB.TabIndex = 4;
            // 
            // numberOfBusBtn
            // 
            this.numberOfBusBtn.Location = new System.Drawing.Point(784, 37);
            this.numberOfBusBtn.Name = "numberOfBusBtn";
            this.numberOfBusBtn.Size = new System.Drawing.Size(154, 31);
            this.numberOfBusBtn.TabIndex = 5;
            this.numberOfBusBtn.Text = "Поиск маршрута";
            this.numberOfBusBtn.UseVisualStyleBackColor = true;
            this.numberOfBusBtn.Click += new System.EventHandler(this.numberOfBusBtn_Click);
            // 
            // infoRouteBusLb
            // 
            this.infoRouteBusLb.AutoSize = true;
            this.infoRouteBusLb.Location = new System.Drawing.Point(713, 18);
            this.infoRouteBusLb.Name = "infoRouteBusLb";
            this.infoRouteBusLb.Size = new System.Drawing.Size(172, 17);
            this.infoRouteBusLb.TabIndex = 6;
            this.infoRouteBusLb.Text = "Введите номер автобуса";
            // 
            // pointDepartueTb
            // 
            this.pointDepartueTb.Location = new System.Drawing.Point(653, 108);
            this.pointDepartueTb.Name = "pointDepartueTb";
            this.pointDepartueTb.Size = new System.Drawing.Size(107, 22);
            this.pointDepartueTb.TabIndex = 7;
            // 
            // pointDepartueLb
            // 
            this.pointDepartueLb.AutoSize = true;
            this.pointDepartueLb.Location = new System.Drawing.Point(713, 84);
            this.pointDepartueLb.Name = "pointDepartueLb";
            this.pointDepartueLb.Size = new System.Drawing.Size(194, 17);
            this.pointDepartueLb.TabIndex = 8;
            this.pointDepartueLb.Text = "Введите пункт отправления";
            // 
            // pointDepartueBtn
            // 
            this.pointDepartueBtn.Location = new System.Drawing.Point(784, 104);
            this.pointDepartueBtn.Name = "pointDepartueBtn";
            this.pointDepartueBtn.Size = new System.Drawing.Size(154, 31);
            this.pointDepartueBtn.TabIndex = 9;
            this.pointDepartueBtn.Text = "Поиск маршрута";
            this.pointDepartueBtn.UseVisualStyleBackColor = true;
            this.pointDepartueBtn.Click += new System.EventHandler(this.pointDepartueBtn_Click);
            // 
            // pointArrivalBtn
            // 
            this.pointArrivalBtn.Location = new System.Drawing.Point(784, 171);
            this.pointArrivalBtn.Name = "pointArrivalBtn";
            this.pointArrivalBtn.Size = new System.Drawing.Size(154, 31);
            this.pointArrivalBtn.TabIndex = 12;
            this.pointArrivalBtn.Text = "Поиск маршрута";
            this.pointArrivalBtn.UseVisualStyleBackColor = true;
            this.pointArrivalBtn.Click += new System.EventHandler(this.pointArrivalBtn_Click);
            // 
            // pointArrivalLb
            // 
            this.pointArrivalLb.AutoSize = true;
            this.pointArrivalLb.Location = new System.Drawing.Point(713, 151);
            this.pointArrivalLb.Name = "pointArrivalLb";
            this.pointArrivalLb.Size = new System.Drawing.Size(173, 17);
            this.pointArrivalLb.TabIndex = 11;
            this.pointArrivalLb.Text = "Введите пункт прибытия";
            // 
            // pointArrivalTb
            // 
            this.pointArrivalTb.Location = new System.Drawing.Point(653, 175);
            this.pointArrivalTb.Name = "pointArrivalTb";
            this.pointArrivalTb.Size = new System.Drawing.Size(107, 22);
            this.pointArrivalTb.TabIndex = 10;
            // 
            // editingBtn
            // 
            this.editingBtn.Location = new System.Drawing.Point(738, 239);
            this.editingBtn.Name = "editingBtn";
            this.editingBtn.Size = new System.Drawing.Size(138, 73);
            this.editingBtn.TabIndex = 13;
            this.editingBtn.Text = "Редактирование";
            this.editingBtn.UseVisualStyleBackColor = true;
            this.editingBtn.Click += new System.EventHandler(this.editingBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(738, 353);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(138, 73);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Сохранить изменения";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 544);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.editingBtn);
            this.Controls.Add(this.pointArrivalBtn);
            this.Controls.Add(this.pointArrivalLb);
            this.Controls.Add(this.pointArrivalTb);
            this.Controls.Add(this.pointDepartueBtn);
            this.Controls.Add(this.pointDepartueLb);
            this.Controls.Add(this.pointDepartueTb);
            this.Controls.Add(this.infoRouteBusLb);
            this.Controls.Add(this.numberOfBusBtn);
            this.Controls.Add(this.numberOfBusTB);
            this.Controls.Add(this.informationListBox);
            this.Controls.Add(this.riverTramBtn);
            this.Controls.Add(this.BusBtn);
            this.Controls.Add(this.railwayTransportBtn);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button railwayTransportBtn;
        private System.Windows.Forms.Button BusBtn;
        private System.Windows.Forms.Button riverTramBtn;
        private System.Windows.Forms.ListBox informationListBox;
        private System.Windows.Forms.TextBox numberOfBusTB;
        private System.Windows.Forms.Button numberOfBusBtn;
        private System.Windows.Forms.Label infoRouteBusLb;
        private System.Windows.Forms.TextBox pointDepartueTb;
        private System.Windows.Forms.Label pointDepartueLb;
        private System.Windows.Forms.Button pointDepartueBtn;
        private System.Windows.Forms.Button pointArrivalBtn;
        private System.Windows.Forms.Label pointArrivalLb;
        private System.Windows.Forms.TextBox pointArrivalTb;
        private System.Windows.Forms.Button editingBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}

