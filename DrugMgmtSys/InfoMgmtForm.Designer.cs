namespace DrugMgmtSys
{
    partial class InfoMgmtForm
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
            this.lb_head = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_spec = new System.Windows.Forms.TextBox();
            this.tb_lot_num = new System.Windows.Forms.TextBox();
            this.nud_reserve = new System.Windows.Forms.NumericUpDown();
            this.nud_w_price = new System.Windows.Forms.NumericUpDown();
            this.nud_r_price = new System.Windows.Forms.NumericUpDown();
            this.cb_unit = new System.Windows.Forms.ComboBox();
            this.tb_origin = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_reserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_w_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_r_price)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_head
            // 
            this.lb_head.AutoSize = true;
            this.lb_head.Font = new System.Drawing.Font("楷体", 16F, System.Drawing.FontStyle.Bold);
            this.lb_head.Location = new System.Drawing.Point(72, 9);
            this.lb_head.Name = "lb_head";
            this.lb_head.Size = new System.Drawing.Size(263, 22);
            this.lb_head.TabIndex = 0;
            this.lb_head.Text = "请在此添加新的药品信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "——————————————————————————————————";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 394);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "红色为必填项";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "药品名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文楷体", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(46, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "产地：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文楷体", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(46, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "规格：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文楷体", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(46, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "单位：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文楷体", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(26, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "批发价：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("华文楷体", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(26, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "库存量：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("华文楷体", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(46, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "批号：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("华文楷体", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(150, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "利润：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("华文楷体", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(26, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "零售价：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("华文楷体", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(213, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "0元";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.Location = new System.Drawing.Point(129, 483);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 44);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(210, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "清空";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_origin);
            this.groupBox2.Controls.Add(this.cb_unit);
            this.groupBox2.Controls.Add(this.nud_r_price);
            this.groupBox2.Controls.Add(this.nud_w_price);
            this.groupBox2.Controls.Add(this.nud_reserve);
            this.groupBox2.Controls.Add(this.tb_lot_num);
            this.groupBox2.Controls.Add(this.tb_spec);
            this.groupBox2.Controls.Add(this.tb_name);
            this.groupBox2.Location = new System.Drawing.Point(102, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 375);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_name.Location = new System.Drawing.Point(20, 20);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(245, 26);
            this.tb_name.TabIndex = 0;
            // 
            // tb_spec
            // 
            this.tb_spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_spec.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_spec.Location = new System.Drawing.Point(20, 106);
            this.tb_spec.Name = "tb_spec";
            this.tb_spec.Size = new System.Drawing.Size(206, 26);
            this.tb_spec.TabIndex = 2;
            // 
            // tb_lot_num
            // 
            this.tb_lot_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_lot_num.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_lot_num.Location = new System.Drawing.Point(20, 201);
            this.tb_lot_num.Name = "tb_lot_num";
            this.tb_lot_num.Size = new System.Drawing.Size(245, 26);
            this.tb_lot_num.TabIndex = 4;
            // 
            // nud_reserve
            // 
            this.nud_reserve.Font = new System.Drawing.Font("楷体", 14F);
            this.nud_reserve.Location = new System.Drawing.Point(21, 246);
            this.nud_reserve.Name = "nud_reserve";
            this.nud_reserve.Size = new System.Drawing.Size(120, 29);
            this.nud_reserve.TabIndex = 5;
            this.nud_reserve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_reserve.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // nud_w_price
            // 
            this.nud_w_price.Font = new System.Drawing.Font("楷体", 14F);
            this.nud_w_price.Location = new System.Drawing.Point(21, 293);
            this.nud_w_price.Name = "nud_w_price";
            this.nud_w_price.Size = new System.Drawing.Size(120, 29);
            this.nud_w_price.TabIndex = 6;
            this.nud_w_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_w_price.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // nud_r_price
            // 
            this.nud_r_price.Font = new System.Drawing.Font("楷体", 14F);
            this.nud_r_price.Location = new System.Drawing.Point(21, 337);
            this.nud_r_price.Name = "nud_r_price";
            this.nud_r_price.Size = new System.Drawing.Size(120, 29);
            this.nud_r_price.TabIndex = 7;
            this.nud_r_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_r_price.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // cb_unit
            // 
            this.cb_unit.Font = new System.Drawing.Font("楷体", 12F);
            this.cb_unit.FormattingEnabled = true;
            this.cb_unit.Location = new System.Drawing.Point(20, 63);
            this.cb_unit.Name = "cb_unit";
            this.cb_unit.Size = new System.Drawing.Size(121, 24);
            this.cb_unit.TabIndex = 8;
            // 
            // tb_origin
            // 
            this.tb_origin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_origin.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_origin.Location = new System.Drawing.Point(20, 154);
            this.tb_origin.Name = "tb_origin";
            this.tb_origin.Size = new System.Drawing.Size(245, 26);
            this.tb_origin.TabIndex = 9;
            // 
            // InfoMgmtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_head);
            this.Name = "InfoMgmtForm";
            this.Text = "药品信息添加";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_reserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_w_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_r_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_head;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_lot_num;
        private System.Windows.Forms.TextBox tb_spec;
        private System.Windows.Forms.NumericUpDown nud_reserve;
        private System.Windows.Forms.NumericUpDown nud_r_price;
        private System.Windows.Forms.NumericUpDown nud_w_price;
        private System.Windows.Forms.ComboBox cb_unit;
        private System.Windows.Forms.TextBox tb_origin;
    }
}