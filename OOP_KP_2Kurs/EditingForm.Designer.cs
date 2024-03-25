
namespace OOP_KP_2Kurs
{
    partial class EditingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.choiceTransportGB = new System.Windows.Forms.GroupBox();
            this.riverTramRB = new System.Windows.Forms.RadioButton();
            this.busRB = new System.Windows.Forms.RadioButton();
            this.railwayTransportRB = new System.Windows.Forms.RadioButton();
            this.pointOfDepartureTb = new System.Windows.Forms.TextBox();
            this.pointOfArrivalTb = new System.Windows.Forms.TextBox();
            this.pathRailwayTransportTb = new System.Windows.Forms.TextBox();
            this.numberRailwayTransportTb = new System.Windows.Forms.TextBox();
            this.numberRailwayTransportLb = new System.Windows.Forms.Label();
            this.pointOfDepartureLb = new System.Windows.Forms.Label();
            this.pointOfArrivalLb = new System.Windows.Forms.Label();
            this.pathRailwayTransportLb = new System.Windows.Forms.Label();
            this.busNumberTB = new System.Windows.Forms.TextBox();
            this.busIntervalTB = new System.Windows.Forms.TextBox();
            this.busRouteTB = new System.Windows.Forms.TextBox();
            this.busNumberLb = new System.Windows.Forms.Label();
            this.busIntervalLb = new System.Windows.Forms.Label();
            this.busRouteLb = new System.Windows.Forms.Label();
            this.departurePierRiverTramTB = new System.Windows.Forms.TextBox();
            this.arrivalPierRiverTramTB = new System.Windows.Forms.TextBox();
            this.departureTimeRiverTramTB = new System.Windows.Forms.TextBox();
            this.timeArrivalRiverTramTB = new System.Windows.Forms.TextBox();
            this.departurePierRiverTramLb = new System.Windows.Forms.Label();
            this.arrivalPierRiverTramLb = new System.Windows.Forms.Label();
            this.departureTimeRiverTramLb = new System.Windows.Forms.Label();
            this.timeArrivalRiverTramLb = new System.Windows.Forms.Label();
            this.numberRiverTramLb = new System.Windows.Forms.Label();
            this.numberRiverTramTB = new System.Windows.Forms.TextBox();
            this.EditingRailwayTransportBtn = new System.Windows.Forms.Button();
            this.EditingBusBtn = new System.Windows.Forms.Button();
            this.EditingRiverTramBtn = new System.Windows.Forms.Button();
            this.choiceTransportGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // choiceTransportGB
            // 
            this.choiceTransportGB.Controls.Add(this.riverTramRB);
            this.choiceTransportGB.Controls.Add(this.busRB);
            this.choiceTransportGB.Controls.Add(this.railwayTransportRB);
            this.choiceTransportGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choiceTransportGB.Location = new System.Drawing.Point(12, 13);
            this.choiceTransportGB.Name = "choiceTransportGB";
            this.choiceTransportGB.Size = new System.Drawing.Size(961, 62);
            this.choiceTransportGB.TabIndex = 0;
            this.choiceTransportGB.TabStop = false;
            this.choiceTransportGB.Text = "Выберите транспорт";
            // 
            // riverTramRB
            // 
            this.riverTramRB.AutoSize = true;
            this.riverTramRB.Location = new System.Drawing.Point(766, 21);
            this.riverTramRB.Name = "riverTramRB";
            this.riverTramRB.Size = new System.Drawing.Size(139, 21);
            this.riverTramRB.TabIndex = 2;
            this.riverTramRB.TabStop = true;
            this.riverTramRB.Text = "Речные трамваи";
            this.riverTramRB.UseVisualStyleBackColor = true;
            this.riverTramRB.CheckedChanged += new System.EventHandler(this.riverTramRB_CheckedChanged);
            // 
            // busRB
            // 
            this.busRB.AutoSize = true;
            this.busRB.Location = new System.Drawing.Point(406, 21);
            this.busRB.Name = "busRB";
            this.busRB.Size = new System.Drawing.Size(92, 21);
            this.busRB.TabIndex = 1;
            this.busRB.TabStop = true;
            this.busRB.Text = "Автобусы";
            this.busRB.UseVisualStyleBackColor = true;
            this.busRB.CheckedChanged += new System.EventHandler(this.busRB_CheckedChanged);
            // 
            // railwayTransportRB
            // 
            this.railwayTransportRB.AutoSize = true;
            this.railwayTransportRB.Location = new System.Drawing.Point(40, 21);
            this.railwayTransportRB.Name = "railwayTransportRB";
            this.railwayTransportRB.Size = new System.Drawing.Size(232, 21);
            this.railwayTransportRB.TabIndex = 0;
            this.railwayTransportRB.TabStop = true;
            this.railwayTransportRB.Text = "Железно дородный транспорт";
            this.railwayTransportRB.UseVisualStyleBackColor = true;
            this.railwayTransportRB.CheckedChanged += new System.EventHandler(this.railwayTransportRB_CheckedChanged);
            // 
            // pointOfDepartureTb
            // 
            this.pointOfDepartureTb.Location = new System.Drawing.Point(84, 123);
            this.pointOfDepartureTb.Name = "pointOfDepartureTb";
            this.pointOfDepartureTb.Size = new System.Drawing.Size(114, 22);
            this.pointOfDepartureTb.TabIndex = 1;
            // 
            // pointOfArrivalTb
            // 
            this.pointOfArrivalTb.Location = new System.Drawing.Point(213, 123);
            this.pointOfArrivalTb.Name = "pointOfArrivalTb";
            this.pointOfArrivalTb.Size = new System.Drawing.Size(165, 22);
            this.pointOfArrivalTb.TabIndex = 2;
            // 
            // pathRailwayTransportTb
            // 
            this.pathRailwayTransportTb.Location = new System.Drawing.Point(394, 123);
            this.pathRailwayTransportTb.Name = "pathRailwayTransportTb";
            this.pathRailwayTransportTb.Size = new System.Drawing.Size(557, 22);
            this.pathRailwayTransportTb.TabIndex = 3;
            // 
            // numberRailwayTransportTb
            // 
            this.numberRailwayTransportTb.Location = new System.Drawing.Point(12, 123);
            this.numberRailwayTransportTb.Name = "numberRailwayTransportTb";
            this.numberRailwayTransportTb.Size = new System.Drawing.Size(45, 22);
            this.numberRailwayTransportTb.TabIndex = 4;
            // 
            // numberRailwayTransportLb
            // 
            this.numberRailwayTransportLb.AutoSize = true;
            this.numberRailwayTransportLb.Location = new System.Drawing.Point(13, 100);
            this.numberRailwayTransportLb.Name = "numberRailwayTransportLb";
            this.numberRailwayTransportLb.Size = new System.Drawing.Size(51, 17);
            this.numberRailwayTransportLb.TabIndex = 5;
            this.numberRailwayTransportLb.Text = "Номер";
            // 
            // pointOfDepartureLb
            // 
            this.pointOfDepartureLb.AutoSize = true;
            this.pointOfDepartureLb.Location = new System.Drawing.Point(84, 99);
            this.pointOfDepartureLb.Name = "pointOfDepartureLb";
            this.pointOfDepartureLb.Size = new System.Drawing.Size(137, 17);
            this.pointOfDepartureLb.TabIndex = 6;
            this.pointOfDepartureLb.Text = "Пункт отправления";
            // 
            // pointOfArrivalLb
            // 
            this.pointOfArrivalLb.AutoSize = true;
            this.pointOfArrivalLb.Location = new System.Drawing.Point(227, 99);
            this.pointOfArrivalLb.Name = "pointOfArrivalLb";
            this.pointOfArrivalLb.Size = new System.Drawing.Size(116, 17);
            this.pointOfArrivalLb.TabIndex = 7;
            this.pointOfArrivalLb.Text = "Пункт прибытия";
            // 
            // pathRailwayTransportLb
            // 
            this.pathRailwayTransportLb.AutoSize = true;
            this.pathRailwayTransportLb.Location = new System.Drawing.Point(536, 100);
            this.pathRailwayTransportLb.Name = "pathRailwayTransportLb";
            this.pathRailwayTransportLb.Size = new System.Drawing.Size(154, 17);
            this.pathRailwayTransportLb.TabIndex = 8;
            this.pathRailwayTransportLb.Text = "Путь Время прибытия";
            // 
            // busNumberTB
            // 
            this.busNumberTB.Location = new System.Drawing.Point(12, 218);
            this.busNumberTB.Name = "busNumberTB";
            this.busNumberTB.Size = new System.Drawing.Size(66, 22);
            this.busNumberTB.TabIndex = 9;
            // 
            // busIntervalTB
            // 
            this.busIntervalTB.Location = new System.Drawing.Point(113, 218);
            this.busIntervalTB.Name = "busIntervalTB";
            this.busIntervalTB.Size = new System.Drawing.Size(60, 22);
            this.busIntervalTB.TabIndex = 10;
            // 
            // busRouteTB
            // 
            this.busRouteTB.Location = new System.Drawing.Point(213, 218);
            this.busRouteTB.Name = "busRouteTB";
            this.busRouteTB.Size = new System.Drawing.Size(738, 22);
            this.busRouteTB.TabIndex = 11;
            // 
            // busNumberLb
            // 
            this.busNumberLb.AutoSize = true;
            this.busNumberLb.Location = new System.Drawing.Point(12, 195);
            this.busNumberLb.Name = "busNumberLb";
            this.busNumberLb.Size = new System.Drawing.Size(51, 17);
            this.busNumberLb.TabIndex = 12;
            this.busNumberLb.Text = "Номер";
            // 
            // busIntervalLb
            // 
            this.busIntervalLb.AutoSize = true;
            this.busIntervalLb.Location = new System.Drawing.Point(113, 194);
            this.busIntervalLb.Name = "busIntervalLb";
            this.busIntervalLb.Size = new System.Drawing.Size(72, 17);
            this.busIntervalLb.TabIndex = 13;
            this.busIntervalLb.Text = "Интервал";
            // 
            // busRouteLb
            // 
            this.busRouteLb.AutoSize = true;
            this.busRouteLb.Location = new System.Drawing.Point(438, 195);
            this.busRouteLb.Name = "busRouteLb";
            this.busRouteLb.Size = new System.Drawing.Size(68, 17);
            this.busRouteLb.TabIndex = 14;
            this.busRouteLb.Text = "Маршрут";
            // 
            // departurePierRiverTramTB
            // 
            this.departurePierRiverTramTB.Location = new System.Drawing.Point(100, 314);
            this.departurePierRiverTramTB.Name = "departurePierRiverTramTB";
            this.departurePierRiverTramTB.Size = new System.Drawing.Size(146, 22);
            this.departurePierRiverTramTB.TabIndex = 15;
            // 
            // arrivalPierRiverTramTB
            // 
            this.arrivalPierRiverTramTB.Location = new System.Drawing.Point(285, 314);
            this.arrivalPierRiverTramTB.Name = "arrivalPierRiverTramTB";
            this.arrivalPierRiverTramTB.Size = new System.Drawing.Size(146, 22);
            this.arrivalPierRiverTramTB.TabIndex = 16;
            // 
            // departureTimeRiverTramTB
            // 
            this.departureTimeRiverTramTB.Location = new System.Drawing.Point(482, 314);
            this.departureTimeRiverTramTB.Name = "departureTimeRiverTramTB";
            this.departureTimeRiverTramTB.Size = new System.Drawing.Size(146, 22);
            this.departureTimeRiverTramTB.TabIndex = 17;
            // 
            // timeArrivalRiverTramTB
            // 
            this.timeArrivalRiverTramTB.Location = new System.Drawing.Point(670, 314);
            this.timeArrivalRiverTramTB.Name = "timeArrivalRiverTramTB";
            this.timeArrivalRiverTramTB.Size = new System.Drawing.Size(146, 22);
            this.timeArrivalRiverTramTB.TabIndex = 18;
            // 
            // departurePierRiverTramLb
            // 
            this.departurePierRiverTramLb.AutoSize = true;
            this.departurePierRiverTramLb.Location = new System.Drawing.Point(105, 291);
            this.departurePierRiverTramLb.Name = "departurePierRiverTramLb";
            this.departurePierRiverTramLb.Size = new System.Drawing.Size(161, 17);
            this.departurePierRiverTramLb.TabIndex = 19;
            this.departurePierRiverTramLb.Text = "Пристань отправления";
            // 
            // arrivalPierRiverTramLb
            // 
            this.arrivalPierRiverTramLb.AutoSize = true;
            this.arrivalPierRiverTramLb.Location = new System.Drawing.Point(282, 291);
            this.arrivalPierRiverTramLb.Name = "arrivalPierRiverTramLb";
            this.arrivalPierRiverTramLb.Size = new System.Drawing.Size(140, 17);
            this.arrivalPierRiverTramLb.TabIndex = 20;
            this.arrivalPierRiverTramLb.Text = "Присьань прибытия";
            // 
            // departureTimeRiverTramLb
            // 
            this.departureTimeRiverTramLb.AutoSize = true;
            this.departureTimeRiverTramLb.Location = new System.Drawing.Point(479, 291);
            this.departureTimeRiverTramLb.Name = "departureTimeRiverTramLb";
            this.departureTimeRiverTramLb.Size = new System.Drawing.Size(140, 17);
            this.departureTimeRiverTramLb.TabIndex = 21;
            this.departureTimeRiverTramLb.Text = "Время отправления";
            // 
            // timeArrivalRiverTramLb
            // 
            this.timeArrivalRiverTramLb.AutoSize = true;
            this.timeArrivalRiverTramLb.Location = new System.Drawing.Point(667, 291);
            this.timeArrivalRiverTramLb.Name = "timeArrivalRiverTramLb";
            this.timeArrivalRiverTramLb.Size = new System.Drawing.Size(119, 17);
            this.timeArrivalRiverTramLb.TabIndex = 22;
            this.timeArrivalRiverTramLb.Text = "Время прибытия";
            // 
            // numberRiverTramLb
            // 
            this.numberRiverTramLb.AutoSize = true;
            this.numberRiverTramLb.Location = new System.Drawing.Point(16, 291);
            this.numberRiverTramLb.Name = "numberRiverTramLb";
            this.numberRiverTramLb.Size = new System.Drawing.Size(51, 17);
            this.numberRiverTramLb.TabIndex = 24;
            this.numberRiverTramLb.Text = "Номер";
            // 
            // numberRiverTramTB
            // 
            this.numberRiverTramTB.Location = new System.Drawing.Point(16, 314);
            this.numberRiverTramTB.Name = "numberRiverTramTB";
            this.numberRiverTramTB.Size = new System.Drawing.Size(66, 22);
            this.numberRiverTramTB.TabIndex = 23;
            // 
            // EditingRailwayTransportBtn
            // 
            this.EditingRailwayTransportBtn.Location = new System.Drawing.Point(778, 152);
            this.EditingRailwayTransportBtn.Name = "EditingRailwayTransportBtn";
            this.EditingRailwayTransportBtn.Size = new System.Drawing.Size(173, 41);
            this.EditingRailwayTransportBtn.TabIndex = 25;
            this.EditingRailwayTransportBtn.Text = "Изменить";
            this.EditingRailwayTransportBtn.UseVisualStyleBackColor = true;
            this.EditingRailwayTransportBtn.Click += new System.EventHandler(this.EditingRailwayTransportBtn_Click);
            // 
            // EditingBusBtn
            // 
            this.EditingBusBtn.Location = new System.Drawing.Point(778, 247);
            this.EditingBusBtn.Name = "EditingBusBtn";
            this.EditingBusBtn.Size = new System.Drawing.Size(173, 41);
            this.EditingBusBtn.TabIndex = 26;
            this.EditingBusBtn.Text = "Изменить";
            this.EditingBusBtn.UseVisualStyleBackColor = true;
            this.EditingBusBtn.Click += new System.EventHandler(this.EditingBusBtn_Click);
            // 
            // EditingRiverTramBtn
            // 
            this.EditingRiverTramBtn.Location = new System.Drawing.Point(778, 353);
            this.EditingRiverTramBtn.Name = "EditingRiverTramBtn";
            this.EditingRiverTramBtn.Size = new System.Drawing.Size(173, 41);
            this.EditingRiverTramBtn.TabIndex = 27;
            this.EditingRiverTramBtn.Text = "Изменить";
            this.EditingRiverTramBtn.UseVisualStyleBackColor = true;
            this.EditingRiverTramBtn.Click += new System.EventHandler(this.EditingRiverTramBtn_Click);
            // 
            // EditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 544);
            this.Controls.Add(this.EditingRiverTramBtn);
            this.Controls.Add(this.EditingBusBtn);
            this.Controls.Add(this.EditingRailwayTransportBtn);
            this.Controls.Add(this.numberRiverTramLb);
            this.Controls.Add(this.numberRiverTramTB);
            this.Controls.Add(this.timeArrivalRiverTramLb);
            this.Controls.Add(this.departureTimeRiverTramLb);
            this.Controls.Add(this.arrivalPierRiverTramLb);
            this.Controls.Add(this.departurePierRiverTramLb);
            this.Controls.Add(this.timeArrivalRiverTramTB);
            this.Controls.Add(this.departureTimeRiverTramTB);
            this.Controls.Add(this.arrivalPierRiverTramTB);
            this.Controls.Add(this.departurePierRiverTramTB);
            this.Controls.Add(this.busRouteLb);
            this.Controls.Add(this.busIntervalLb);
            this.Controls.Add(this.busNumberLb);
            this.Controls.Add(this.busRouteTB);
            this.Controls.Add(this.busIntervalTB);
            this.Controls.Add(this.busNumberTB);
            this.Controls.Add(this.pathRailwayTransportLb);
            this.Controls.Add(this.pointOfArrivalLb);
            this.Controls.Add(this.pointOfDepartureLb);
            this.Controls.Add(this.numberRailwayTransportLb);
            this.Controls.Add(this.numberRailwayTransportTb);
            this.Controls.Add(this.pathRailwayTransportTb);
            this.Controls.Add(this.pointOfArrivalTb);
            this.Controls.Add(this.pointOfDepartureTb);
            this.Controls.Add(this.choiceTransportGB);
            this.Name = "EditingForm";
            this.Text = "EditingForm";
            this.choiceTransportGB.ResumeLayout(false);
            this.choiceTransportGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox choiceTransportGB;
        private System.Windows.Forms.RadioButton riverTramRB;
        private System.Windows.Forms.RadioButton busRB;
        private System.Windows.Forms.RadioButton railwayTransportRB;
        private System.Windows.Forms.TextBox pointOfDepartureTb;
        private System.Windows.Forms.TextBox pointOfArrivalTb;
        private System.Windows.Forms.TextBox pathRailwayTransportTb;
        private System.Windows.Forms.TextBox numberRailwayTransportTb;
        private System.Windows.Forms.Label numberRailwayTransportLb;
        private System.Windows.Forms.Label pointOfDepartureLb;
        private System.Windows.Forms.Label pointOfArrivalLb;
        private System.Windows.Forms.Label pathRailwayTransportLb;
        private System.Windows.Forms.TextBox busNumberTB;
        private System.Windows.Forms.TextBox busIntervalTB;
        private System.Windows.Forms.TextBox busRouteTB;
        private System.Windows.Forms.Label busNumberLb;
        private System.Windows.Forms.Label busIntervalLb;
        private System.Windows.Forms.Label busRouteLb;
        private System.Windows.Forms.TextBox departurePierRiverTramTB;
        private System.Windows.Forms.TextBox arrivalPierRiverTramTB;
        private System.Windows.Forms.TextBox departureTimeRiverTramTB;
        private System.Windows.Forms.TextBox timeArrivalRiverTramTB;
        private System.Windows.Forms.Label departurePierRiverTramLb;
        private System.Windows.Forms.Label arrivalPierRiverTramLb;
        private System.Windows.Forms.Label departureTimeRiverTramLb;
        private System.Windows.Forms.Label timeArrivalRiverTramLb;
        private System.Windows.Forms.Label numberRiverTramLb;
        private System.Windows.Forms.TextBox numberRiverTramTB;
        private System.Windows.Forms.Button EditingRailwayTransportBtn;
        private System.Windows.Forms.Button EditingBusBtn;
        private System.Windows.Forms.Button EditingRiverTramBtn;
    }
}