
namespace kalkulator2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.wynik = new System.Windows.Forms.TextBox();
			this.lbX = new System.Windows.Forms.Label();
			this.lbY = new System.Windows.Forms.Label();
			this.x_wartosc = new System.Windows.Forms.TextBox();
			this.y_wartosc = new System.Windows.Forms.TextBox();
			this.dodajBt = new System.Windows.Forms.Button();
			this.OdejmijBt = new System.Windows.Forms.Button();
			this.PodzielBt = new System.Windows.Forms.Button();
			this.PomnozBt = new System.Windows.Forms.Button();
			this.A_bt1 = new System.Windows.Forms.Button();
			this.B_bt1 = new System.Windows.Forms.Button();
			this.C_bt1 = new System.Windows.Forms.Button();
			this.D_bt1 = new System.Windows.Forms.Button();
			this.D_bt2 = new System.Windows.Forms.Button();
			this.C_bt2 = new System.Windows.Forms.Button();
			this.B_bt2 = new System.Windows.Forms.Button();
			this.A_bt2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.x_wynik = new System.Windows.Forms.Button();
			this.y_wynik = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.czyscBufor = new System.Windows.Forms.Button();
			this.Y_bufor_D = new System.Windows.Forms.Button();
			this.D_bufor_A = new System.Windows.Forms.Button();
			this.Y_bufor_C = new System.Windows.Forms.Button();
			this.C_bufor_A = new System.Windows.Forms.Button();
			this.Y_bufor_B = new System.Windows.Forms.Button();
			this.X_bufor_B = new System.Windows.Forms.Button();
			this.Y_bufor_A = new System.Windows.Forms.Button();
			this.X_bufor_A = new System.Windows.Forms.Button();
			this.D_bufor = new System.Windows.Forms.TextBox();
			this.C_bufor = new System.Windows.Forms.TextBox();
			this.B_bufor = new System.Windows.Forms.TextBox();
			this.A_bufor = new System.Windows.Forms.TextBox();
			this.buforD_Lb = new System.Windows.Forms.Label();
			this.buforC_Lb = new System.Windows.Forms.Label();
			this.buforB_Lb = new System.Windows.Forms.Label();
			this.buforA_Lb = new System.Windows.Forms.Label();
			this.notatnik = new System.Windows.Forms.Button();
			this.wysylka = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.bruttoPlus = new System.Windows.Forms.Button();
			this.button26 = new System.Windows.Forms.Button();
			this.czyscAll = new System.Windows.Forms.Button();
			this.wynikBtA = new System.Windows.Forms.Button();
			this.wynikBtB = new System.Windows.Forms.Button();
			this.wynikBtD = new System.Windows.Forms.Button();
			this.wynikBtC = new System.Windows.Forms.Button();
			this.czyscWynik = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// wynik
			// 
			this.wynik.BackColor = System.Drawing.Color.FloralWhite;
			this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wynik.Location = new System.Drawing.Point(16, 16);
			this.wynik.Name = "wynik";
			this.wynik.Size = new System.Drawing.Size(323, 44);
			this.wynik.TabIndex = 0;
			this.wynik.TabStop = false;
			this.wynik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbX
			// 
			this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbX.Location = new System.Drawing.Point(6, 17);
			this.lbX.Name = "lbX";
			this.lbX.Size = new System.Drawing.Size(20, 20);
			this.lbX.TabIndex = 1;
			this.lbX.Text = "X";
			this.lbX.Click += new System.EventHandler(this.LbXClick);
			// 
			// lbY
			// 
			this.lbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbY.Location = new System.Drawing.Point(118, 16);
			this.lbY.Name = "lbY";
			this.lbY.Size = new System.Drawing.Size(20, 20);
			this.lbY.TabIndex = 2;
			this.lbY.Text = "Y";
			this.lbY.Click += new System.EventHandler(this.LbYClick);
			// 
			// x_wartosc
			// 
			this.x_wartosc.CausesValidation = false;
			this.x_wartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.x_wartosc.Location = new System.Drawing.Point(34, 16);
			this.x_wartosc.Name = "x_wartosc";
			this.x_wartosc.Size = new System.Drawing.Size(106, 26);
			this.x_wartosc.TabIndex = 0;
			this.x_wartosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// y_wartosc
			// 
			this.y_wartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.y_wartosc.Location = new System.Drawing.Point(6, 16);
			this.y_wartosc.Name = "y_wartosc";
			this.y_wartosc.Size = new System.Drawing.Size(107, 26);
			this.y_wartosc.TabIndex = 1;
			this.y_wartosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dodajBt
			// 
			this.dodajBt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.dodajBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dodajBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dodajBt.Location = new System.Drawing.Point(6, 13);
			this.dodajBt.Name = "dodajBt";
			this.dodajBt.Size = new System.Drawing.Size(113, 38);
			this.dodajBt.TabIndex = 2;
			this.dodajBt.Text = " +";
			this.dodajBt.UseVisualStyleBackColor = false;
			this.dodajBt.Click += new System.EventHandler(this.DodajBtClick);
			// 
			// OdejmijBt
			// 
			this.OdejmijBt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.OdejmijBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OdejmijBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.OdejmijBt.Location = new System.Drawing.Point(138, 13);
			this.OdejmijBt.Name = "OdejmijBt";
			this.OdejmijBt.Size = new System.Drawing.Size(113, 38);
			this.OdejmijBt.TabIndex = 3;
			this.OdejmijBt.Text = " -";
			this.OdejmijBt.UseVisualStyleBackColor = false;
			this.OdejmijBt.Click += new System.EventHandler(this.OdejmijBtClick);
			// 
			// PodzielBt
			// 
			this.PodzielBt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.PodzielBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PodzielBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PodzielBt.Location = new System.Drawing.Point(138, 74);
			this.PodzielBt.Name = "PodzielBt";
			this.PodzielBt.Size = new System.Drawing.Size(113, 38);
			this.PodzielBt.TabIndex = 5;
			this.PodzielBt.Text = " /";
			this.PodzielBt.UseVisualStyleBackColor = false;
			this.PodzielBt.Click += new System.EventHandler(this.PodzielBtClick);
			// 
			// PomnozBt
			// 
			this.PomnozBt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.PomnozBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PomnozBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PomnozBt.Location = new System.Drawing.Point(6, 74);
			this.PomnozBt.Name = "PomnozBt";
			this.PomnozBt.Size = new System.Drawing.Size(113, 38);
			this.PomnozBt.TabIndex = 4;
			this.PomnozBt.Text = " *";
			this.PomnozBt.UseVisualStyleBackColor = false;
			this.PomnozBt.Click += new System.EventHandler(this.PomnozBtClick);
			// 
			// A_bt1
			// 
			this.A_bt1.Location = new System.Drawing.Point(44, 58);
			this.A_bt1.Name = "A_bt1";
			this.A_bt1.Size = new System.Drawing.Size(19, 23);
			this.A_bt1.TabIndex = 9;
			this.A_bt1.TabStop = false;
			this.A_bt1.Text = "A";
			this.A_bt1.UseVisualStyleBackColor = true;
			this.A_bt1.Click += new System.EventHandler(this.A_bt1Click);
			// 
			// B_bt1
			// 
			this.B_bt1.Location = new System.Drawing.Point(69, 58);
			this.B_bt1.Name = "B_bt1";
			this.B_bt1.Size = new System.Drawing.Size(19, 23);
			this.B_bt1.TabIndex = 10;
			this.B_bt1.TabStop = false;
			this.B_bt1.Text = "B";
			this.B_bt1.UseVisualStyleBackColor = true;
			this.B_bt1.Click += new System.EventHandler(this.B_bt1Click);
			// 
			// C_bt1
			// 
			this.C_bt1.Location = new System.Drawing.Point(94, 58);
			this.C_bt1.Name = "C_bt1";
			this.C_bt1.Size = new System.Drawing.Size(19, 23);
			this.C_bt1.TabIndex = 11;
			this.C_bt1.TabStop = false;
			this.C_bt1.Text = "C";
			this.C_bt1.UseVisualStyleBackColor = true;
			this.C_bt1.Click += new System.EventHandler(this.C_bt1Click);
			// 
			// D_bt1
			// 
			this.D_bt1.Location = new System.Drawing.Point(119, 58);
			this.D_bt1.Name = "D_bt1";
			this.D_bt1.Size = new System.Drawing.Size(19, 23);
			this.D_bt1.TabIndex = 12;
			this.D_bt1.TabStop = false;
			this.D_bt1.Text = "D";
			this.D_bt1.UseVisualStyleBackColor = true;
			this.D_bt1.Click += new System.EventHandler(this.D_bt1Click);
			// 
			// D_bt2
			// 
			this.D_bt2.Location = new System.Drawing.Point(83, 58);
			this.D_bt2.Name = "D_bt2";
			this.D_bt2.Size = new System.Drawing.Size(19, 23);
			this.D_bt2.TabIndex = 16;
			this.D_bt2.TabStop = false;
			this.D_bt2.Text = "D";
			this.D_bt2.UseVisualStyleBackColor = true;
			this.D_bt2.Click += new System.EventHandler(this.D_bt2Click);
			// 
			// C_bt2
			// 
			this.C_bt2.Location = new System.Drawing.Point(58, 58);
			this.C_bt2.Name = "C_bt2";
			this.C_bt2.Size = new System.Drawing.Size(19, 23);
			this.C_bt2.TabIndex = 15;
			this.C_bt2.TabStop = false;
			this.C_bt2.Text = "C";
			this.C_bt2.UseVisualStyleBackColor = true;
			this.C_bt2.Click += new System.EventHandler(this.C_bt2Click);
			// 
			// B_bt2
			// 
			this.B_bt2.Location = new System.Drawing.Point(33, 58);
			this.B_bt2.Name = "B_bt2";
			this.B_bt2.Size = new System.Drawing.Size(19, 23);
			this.B_bt2.TabIndex = 14;
			this.B_bt2.TabStop = false;
			this.B_bt2.Text = "B";
			this.B_bt2.UseVisualStyleBackColor = true;
			this.B_bt2.Click += new System.EventHandler(this.B_bt2Click);
			// 
			// A_bt2
			// 
			this.A_bt2.Location = new System.Drawing.Point(8, 58);
			this.A_bt2.Name = "A_bt2";
			this.A_bt2.Size = new System.Drawing.Size(19, 23);
			this.A_bt2.TabIndex = 13;
			this.A_bt2.TabStop = false;
			this.A_bt2.Text = "A";
			this.A_bt2.UseVisualStyleBackColor = true;
			this.A_bt2.Click += new System.EventHandler(this.A_bt2Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.PodzielBt);
			this.groupBox1.Controls.Add(this.dodajBt);
			this.groupBox1.Controls.Add(this.OdejmijBt);
			this.groupBox1.Controls.Add(this.PomnozBt);
			this.groupBox1.Location = new System.Drawing.Point(48, 210);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(257, 119);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			// 
			// x_wynik
			// 
			this.x_wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.x_wynik.Location = new System.Drawing.Point(6, 58);
			this.x_wynik.Name = "x_wynik";
			this.x_wynik.Size = new System.Drawing.Size(28, 23);
			this.x_wynik.TabIndex = 18;
			this.x_wynik.TabStop = false;
			this.x_wynik.Text = "W";
			this.x_wynik.UseVisualStyleBackColor = true;
			this.x_wynik.Click += new System.EventHandler(this.X_wynikClick);
			// 
			// y_wynik
			// 
			this.y_wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.y_wynik.Location = new System.Drawing.Point(112, 58);
			this.y_wynik.Name = "y_wynik";
			this.y_wynik.Size = new System.Drawing.Size(28, 23);
			this.y_wynik.TabIndex = 19;
			this.y_wynik.TabStop = false;
			this.y_wynik.Text = "W";
			this.y_wynik.UseVisualStyleBackColor = true;
			this.y_wynik.Click += new System.EventHandler(this.Y_wynikClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.czyscBufor);
			this.groupBox2.Controls.Add(this.Y_bufor_D);
			this.groupBox2.Controls.Add(this.D_bufor_A);
			this.groupBox2.Controls.Add(this.Y_bufor_C);
			this.groupBox2.Controls.Add(this.C_bufor_A);
			this.groupBox2.Controls.Add(this.Y_bufor_B);
			this.groupBox2.Controls.Add(this.X_bufor_B);
			this.groupBox2.Controls.Add(this.Y_bufor_A);
			this.groupBox2.Controls.Add(this.X_bufor_A);
			this.groupBox2.Controls.Add(this.D_bufor);
			this.groupBox2.Controls.Add(this.C_bufor);
			this.groupBox2.Controls.Add(this.B_bufor);
			this.groupBox2.Controls.Add(this.A_bufor);
			this.groupBox2.Controls.Add(this.buforD_Lb);
			this.groupBox2.Controls.Add(this.buforC_Lb);
			this.groupBox2.Controls.Add(this.buforB_Lb);
			this.groupBox2.Controls.Add(this.buforA_Lb);
			this.groupBox2.Location = new System.Drawing.Point(15, 424);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(323, 109);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			// 
			// czyscBufor
			// 
			this.czyscBufor.BackColor = System.Drawing.Color.Beige;
			this.czyscBufor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.czyscBufor.Location = new System.Drawing.Point(132, 29);
			this.czyscBufor.Name = "czyscBufor";
			this.czyscBufor.Size = new System.Drawing.Size(58, 58);
			this.czyscBufor.TabIndex = 32;
			this.czyscBufor.TabStop = false;
			this.czyscBufor.Text = "CLN BUFOR";
			this.czyscBufor.UseVisualStyleBackColor = false;
			this.czyscBufor.Click += new System.EventHandler(this.CzyscBuforClick);
			// 
			// Y_bufor_D
			// 
			this.Y_bufor_D.Location = new System.Drawing.Point(221, 63);
			this.Y_bufor_D.Name = "Y_bufor_D";
			this.Y_bufor_D.Size = new System.Drawing.Size(19, 23);
			this.Y_bufor_D.TabIndex = 28;
			this.Y_bufor_D.TabStop = false;
			this.Y_bufor_D.Text = "Y";
			this.Y_bufor_D.UseVisualStyleBackColor = true;
			this.Y_bufor_D.Click += new System.EventHandler(this.Y_bufor_DClick);
			// 
			// D_bufor_A
			// 
			this.D_bufor_A.Location = new System.Drawing.Point(201, 63);
			this.D_bufor_A.Name = "D_bufor_A";
			this.D_bufor_A.Size = new System.Drawing.Size(19, 23);
			this.D_bufor_A.TabIndex = 27;
			this.D_bufor_A.TabStop = false;
			this.D_bufor_A.Text = "X";
			this.D_bufor_A.UseVisualStyleBackColor = true;
			this.D_bufor_A.Click += new System.EventHandler(this.D_bufor_AClick);
			// 
			// Y_bufor_C
			// 
			this.Y_bufor_C.Location = new System.Drawing.Point(221, 29);
			this.Y_bufor_C.Name = "Y_bufor_C";
			this.Y_bufor_C.Size = new System.Drawing.Size(19, 23);
			this.Y_bufor_C.TabIndex = 26;
			this.Y_bufor_C.TabStop = false;
			this.Y_bufor_C.Text = "Y";
			this.Y_bufor_C.UseVisualStyleBackColor = true;
			this.Y_bufor_C.Click += new System.EventHandler(this.Y_bufor_CClick);
			// 
			// C_bufor_A
			// 
			this.C_bufor_A.Location = new System.Drawing.Point(201, 29);
			this.C_bufor_A.Name = "C_bufor_A";
			this.C_bufor_A.Size = new System.Drawing.Size(19, 23);
			this.C_bufor_A.TabIndex = 25;
			this.C_bufor_A.TabStop = false;
			this.C_bufor_A.Text = "X";
			this.C_bufor_A.UseVisualStyleBackColor = true;
			this.C_bufor_A.Click += new System.EventHandler(this.C_bufor_AClick);
			// 
			// Y_bufor_B
			// 
			this.Y_bufor_B.Location = new System.Drawing.Point(103, 63);
			this.Y_bufor_B.Name = "Y_bufor_B";
			this.Y_bufor_B.Size = new System.Drawing.Size(19, 23);
			this.Y_bufor_B.TabIndex = 24;
			this.Y_bufor_B.TabStop = false;
			this.Y_bufor_B.Text = "Y";
			this.Y_bufor_B.UseVisualStyleBackColor = true;
			this.Y_bufor_B.Click += new System.EventHandler(this.Y_bufor_BClick);
			// 
			// X_bufor_B
			// 
			this.X_bufor_B.Location = new System.Drawing.Point(83, 63);
			this.X_bufor_B.Name = "X_bufor_B";
			this.X_bufor_B.Size = new System.Drawing.Size(19, 23);
			this.X_bufor_B.TabIndex = 23;
			this.X_bufor_B.TabStop = false;
			this.X_bufor_B.Text = "X";
			this.X_bufor_B.UseVisualStyleBackColor = true;
			this.X_bufor_B.Click += new System.EventHandler(this.X_bufor_BClick);
			// 
			// Y_bufor_A
			// 
			this.Y_bufor_A.Location = new System.Drawing.Point(103, 29);
			this.Y_bufor_A.Name = "Y_bufor_A";
			this.Y_bufor_A.Size = new System.Drawing.Size(19, 23);
			this.Y_bufor_A.TabIndex = 22;
			this.Y_bufor_A.TabStop = false;
			this.Y_bufor_A.Text = "Y";
			this.Y_bufor_A.UseVisualStyleBackColor = true;
			this.Y_bufor_A.Click += new System.EventHandler(this.Y_bufor_AClick);
			// 
			// X_bufor_A
			// 
			this.X_bufor_A.Location = new System.Drawing.Point(83, 29);
			this.X_bufor_A.Name = "X_bufor_A";
			this.X_bufor_A.Size = new System.Drawing.Size(19, 23);
			this.X_bufor_A.TabIndex = 21;
			this.X_bufor_A.TabStop = false;
			this.X_bufor_A.Text = "X";
			this.X_bufor_A.UseVisualStyleBackColor = true;
			this.X_bufor_A.Click += new System.EventHandler(this.X_bufor_AClick);
			// 
			// D_bufor
			// 
			this.D_bufor.Location = new System.Drawing.Point(246, 66);
			this.D_bufor.Name = "D_bufor";
			this.D_bufor.Size = new System.Drawing.Size(69, 20);
			this.D_bufor.TabIndex = 7;
			this.D_bufor.TabStop = false;
			// 
			// C_bufor
			// 
			this.C_bufor.Location = new System.Drawing.Point(246, 33);
			this.C_bufor.Name = "C_bufor";
			this.C_bufor.Size = new System.Drawing.Size(69, 20);
			this.C_bufor.TabIndex = 6;
			this.C_bufor.TabStop = false;
			// 
			// B_bufor
			// 
			this.B_bufor.Location = new System.Drawing.Point(8, 65);
			this.B_bufor.Name = "B_bufor";
			this.B_bufor.Size = new System.Drawing.Size(69, 20);
			this.B_bufor.TabIndex = 5;
			this.B_bufor.TabStop = false;
			// 
			// A_bufor
			// 
			this.A_bufor.Location = new System.Drawing.Point(8, 32);
			this.A_bufor.Name = "A_bufor";
			this.A_bufor.Size = new System.Drawing.Size(69, 20);
			this.A_bufor.TabIndex = 4;
			this.A_bufor.TabStop = false;
			// 
			// buforD_Lb
			// 
			this.buforD_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buforD_Lb.Location = new System.Drawing.Point(303, 89);
			this.buforD_Lb.Name = "buforD_Lb";
			this.buforD_Lb.Size = new System.Drawing.Size(14, 17);
			this.buforD_Lb.TabIndex = 3;
			this.buforD_Lb.Text = "D";
			// 
			// buforC_Lb
			// 
			this.buforC_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buforC_Lb.Location = new System.Drawing.Point(303, 12);
			this.buforC_Lb.Name = "buforC_Lb";
			this.buforC_Lb.Size = new System.Drawing.Size(14, 17);
			this.buforC_Lb.TabIndex = 2;
			this.buforC_Lb.Text = "C";
			// 
			// buforB_Lb
			// 
			this.buforB_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buforB_Lb.Location = new System.Drawing.Point(6, 88);
			this.buforB_Lb.Name = "buforB_Lb";
			this.buforB_Lb.Size = new System.Drawing.Size(14, 17);
			this.buforB_Lb.TabIndex = 1;
			this.buforB_Lb.Text = "B";
			// 
			// buforA_Lb
			// 
			this.buforA_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buforA_Lb.Location = new System.Drawing.Point(6, 12);
			this.buforA_Lb.Name = "buforA_Lb";
			this.buforA_Lb.Size = new System.Drawing.Size(14, 17);
			this.buforA_Lb.TabIndex = 0;
			this.buforA_Lb.Text = "A";
			// 
			// notatnik
			// 
			this.notatnik.Location = new System.Drawing.Point(18, 341);
			this.notatnik.Name = "notatnik";
			this.notatnik.Size = new System.Drawing.Size(94, 23);
			this.notatnik.TabIndex = 21;
			this.notatnik.TabStop = false;
			this.notatnik.Text = "Notatnik";
			this.notatnik.UseVisualStyleBackColor = true;
			this.notatnik.Click += new System.EventHandler(this.Button23Click);
			// 
			// wysylka
			// 
			this.wysylka.Location = new System.Drawing.Point(242, 341);
			this.wysylka.Name = "wysylka";
			this.wysylka.Size = new System.Drawing.Size(94, 23);
			this.wysylka.TabIndex = 22;
			this.wysylka.TabStop = false;
			this.wysylka.Text = "Wysyłka";
			this.wysylka.UseVisualStyleBackColor = true;
			this.wysylka.Click += new System.EventHandler(this.Button24Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lbX);
			this.groupBox3.Controls.Add(this.x_wartosc);
			this.groupBox3.Controls.Add(this.A_bt1);
			this.groupBox3.Controls.Add(this.B_bt1);
			this.groupBox3.Controls.Add(this.C_bt1);
			this.groupBox3.Controls.Add(this.D_bt1);
			this.groupBox3.Controls.Add(this.x_wynik);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox3.Location = new System.Drawing.Point(16, 109);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(146, 87);
			this.groupBox3.TabIndex = 23;
			this.groupBox3.TabStop = false;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lbY);
			this.groupBox4.Controls.Add(this.y_wartosc);
			this.groupBox4.Controls.Add(this.A_bt2);
			this.groupBox4.Controls.Add(this.B_bt2);
			this.groupBox4.Controls.Add(this.C_bt2);
			this.groupBox4.Controls.Add(this.D_bt2);
			this.groupBox4.Controls.Add(this.y_wynik);
			this.groupBox4.Location = new System.Drawing.Point(190, 109);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(146, 87);
			this.groupBox4.TabIndex = 24;
			this.groupBox4.TabStop = false;
			// 
			// bruttoPlus
			// 
			this.bruttoPlus.Location = new System.Drawing.Point(18, 370);
			this.bruttoPlus.Name = "bruttoPlus";
			this.bruttoPlus.Size = new System.Drawing.Size(44, 23);
			this.bruttoPlus.TabIndex = 25;
			this.bruttoPlus.TabStop = false;
			this.bruttoPlus.Text = "BR +";
			this.bruttoPlus.UseVisualStyleBackColor = true;
			this.bruttoPlus.Click += new System.EventHandler(this.BruttoPlusClick);
			// 
			// button26
			// 
			this.button26.Location = new System.Drawing.Point(242, 370);
			this.button26.Name = "button26";
			this.button26.Size = new System.Drawing.Size(94, 23);
			this.button26.TabIndex = 26;
			this.button26.TabStop = false;
			this.button26.UseVisualStyleBackColor = true;
			// 
			// czyscAll
			// 
			this.czyscAll.BackColor = System.Drawing.Color.Tomato;
			this.czyscAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.czyscAll.Location = new System.Drawing.Point(125, 377);
			this.czyscAll.Name = "czyscAll";
			this.czyscAll.Size = new System.Drawing.Size(103, 36);
			this.czyscAll.TabIndex = 27;
			this.czyscAll.TabStop = false;
			this.czyscAll.Text = "CLN ALL";
			this.czyscAll.UseVisualStyleBackColor = false;
			this.czyscAll.Click += new System.EventHandler(this.CzyscAllClick);
			// 
			// wynikBtA
			// 
			this.wynikBtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wynikBtA.Location = new System.Drawing.Point(19, 74);
			this.wynikBtA.Name = "wynikBtA";
			this.wynikBtA.Size = new System.Drawing.Size(75, 22);
			this.wynikBtA.TabIndex = 28;
			this.wynikBtA.TabStop = false;
			this.wynikBtA.Text = "A";
			this.wynikBtA.UseVisualStyleBackColor = true;
			this.wynikBtA.Click += new System.EventHandler(this.WynikBtAClick);
			// 
			// wynikBtB
			// 
			this.wynikBtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wynikBtB.Location = new System.Drawing.Point(100, 74);
			this.wynikBtB.Name = "wynikBtB";
			this.wynikBtB.Size = new System.Drawing.Size(75, 22);
			this.wynikBtB.TabIndex = 29;
			this.wynikBtB.TabStop = false;
			this.wynikBtB.Text = "B";
			this.wynikBtB.UseVisualStyleBackColor = true;
			this.wynikBtB.Click += new System.EventHandler(this.WynikBtBClick);
			// 
			// wynikBtD
			// 
			this.wynikBtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wynikBtD.Location = new System.Drawing.Point(262, 74);
			this.wynikBtD.Name = "wynikBtD";
			this.wynikBtD.Size = new System.Drawing.Size(75, 22);
			this.wynikBtD.TabIndex = 31;
			this.wynikBtD.TabStop = false;
			this.wynikBtD.Text = "D";
			this.wynikBtD.UseVisualStyleBackColor = true;
			this.wynikBtD.Click += new System.EventHandler(this.WynikBtDClick);
			// 
			// wynikBtC
			// 
			this.wynikBtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wynikBtC.Location = new System.Drawing.Point(181, 74);
			this.wynikBtC.Name = "wynikBtC";
			this.wynikBtC.Size = new System.Drawing.Size(75, 22);
			this.wynikBtC.TabIndex = 30;
			this.wynikBtC.TabStop = false;
			this.wynikBtC.Text = "C";
			this.wynikBtC.UseVisualStyleBackColor = true;
			this.wynikBtC.Click += new System.EventHandler(this.WynikBtCClick);
			// 
			// czyscWynik
			// 
			this.czyscWynik.BackColor = System.Drawing.Color.PeachPuff;
			this.czyscWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.czyscWynik.Location = new System.Drawing.Point(125, 341);
			this.czyscWynik.Name = "czyscWynik";
			this.czyscWynik.Size = new System.Drawing.Size(103, 30);
			this.czyscWynik.TabIndex = 32;
			this.czyscWynik.TabStop = false;
			this.czyscWynik.Text = "CLN WYNIK";
			this.czyscWynik.UseVisualStyleBackColor = false;
			this.czyscWynik.Click += new System.EventHandler(this.CzyscWynikClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(166, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 17);
			this.label1.TabIndex = 33;
			this.label1.Text = "<>";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(19, 399);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 23);
			this.button1.TabIndex = 34;
			this.button1.TabStop = false;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(242, 399);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 23);
			this.button2.TabIndex = 35;
			this.button2.TabStop = false;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(68, 370);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(44, 23);
			this.button3.TabIndex = 36;
			this.button3.TabStop = false;
			this.button3.Text = "BR -";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// MainForm
			// 
			this.AcceptButton = this.PodzielBt;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 571);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.czyscWynik);
			this.Controls.Add(this.wynikBtD);
			this.Controls.Add(this.wynikBtC);
			this.Controls.Add(this.wynikBtB);
			this.Controls.Add(this.wynikBtA);
			this.Controls.Add(this.czyscAll);
			this.Controls.Add(this.button26);
			this.Controls.Add(this.bruttoPlus);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.wysylka);
			this.Controls.Add(this.notatnik);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.wynik);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CsR Kalk";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button czyscWynik;
		private System.Windows.Forms.Button czyscBufor;
		private System.Windows.Forms.Button wynikBtC;
		private System.Windows.Forms.Button wynikBtD;
		private System.Windows.Forms.Button wynikBtB;
		private System.Windows.Forms.Button wynikBtA;
		private System.Windows.Forms.Button czyscAll;
		private System.Windows.Forms.Button button26;
		private System.Windows.Forms.Button bruttoPlus;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button wysylka;
		private System.Windows.Forms.Button notatnik;
		private System.Windows.Forms.Button X_bufor_A;
		private System.Windows.Forms.Button Y_bufor_A;
		private System.Windows.Forms.Button X_bufor_B;
		private System.Windows.Forms.Button Y_bufor_B;
		private System.Windows.Forms.Button C_bufor_A;
		private System.Windows.Forms.Button Y_bufor_C;
		private System.Windows.Forms.Button D_bufor_A;
		private System.Windows.Forms.Button Y_bufor_D;
		private System.Windows.Forms.Label buforA_Lb;
		private System.Windows.Forms.Label buforB_Lb;
		private System.Windows.Forms.Label buforC_Lb;
		private System.Windows.Forms.Label buforD_Lb;
		private System.Windows.Forms.TextBox A_bufor;
		private System.Windows.Forms.TextBox B_bufor;
		private System.Windows.Forms.TextBox C_bufor;
		private System.Windows.Forms.TextBox D_bufor;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button y_wynik;
		private System.Windows.Forms.Button x_wynik;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button A_bt2;
		private System.Windows.Forms.Button B_bt2;
		private System.Windows.Forms.Button C_bt2;
		private System.Windows.Forms.Button D_bt2;
		private System.Windows.Forms.Button D_bt1;
		private System.Windows.Forms.Button C_bt1;
		private System.Windows.Forms.Button B_bt1;
		private System.Windows.Forms.Button A_bt1;
		private System.Windows.Forms.Button PomnozBt;
		private System.Windows.Forms.Button PodzielBt;
		private System.Windows.Forms.Button OdejmijBt;
		private System.Windows.Forms.Button dodajBt;
		private System.Windows.Forms.TextBox y_wartosc;
		private System.Windows.Forms.TextBox x_wartosc;
		private System.Windows.Forms.Label lbY;
		private System.Windows.Forms.Label lbX;
		private System.Windows.Forms.TextBox wynik;

	}
}
