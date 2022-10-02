namespace Oefening4
{
    partial class Form4
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.id_item = new System.Windows.Forms.Label();
            this.id_quantity = new System.Windows.Forms.Label();
            this.id_price = new System.Windows.Forms.Label();
            this.ext_price = new System.Windows.Forms.Label();
            this.id_gloves = new System.Windows.Forms.TextBox();
            this.id_boots = new System.Windows.Forms.TextBox();
            this.id_skis = new System.Windows.Forms.TextBox();
            this.id_hat = new System.Windows.Forms.TextBox();
            this.hat_price = new System.Windows.Forms.TextBox();
            this.skis_price = new System.Windows.Forms.TextBox();
            this.boots_price = new System.Windows.Forms.TextBox();
            this.gloves_pricee = new System.Windows.Forms.TextBox();
            this.ext_hat = new System.Windows.Forms.TextBox();
            this.ext_skis = new System.Windows.Forms.TextBox();
            this.ext_boots = new System.Windows.Forms.TextBox();
            this.ext_gloves = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label_subtotal = new System.Windows.Forms.Label();
            this.label_tax_rate = new System.Windows.Forms.Label();
            this.label_grand_total = new System.Windows.Forms.Label();
            this.label_shipping = new System.Windows.Forms.Label();
            this.label_sales_tax = new System.Windows.Forms.Label();
            this.qgloves = new System.Windows.Forms.NumericUpDown();
            this.qskis = new System.Windows.Forms.NumericUpDown();
            this.qhat = new System.Windows.Forms.NumericUpDown();
            this.qboots = new System.Windows.Forms.NumericUpDown();
            this.calculatebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qgloves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qskis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qboots)).BeginInit();
            this.SuspendLayout();
            // 
            // id_item
            // 
            this.id_item.AutoSize = true;
            this.id_item.Location = new System.Drawing.Point(218, 79);
            this.id_item.Name = "id_item";
            this.id_item.Size = new System.Drawing.Size(31, 15);
            this.id_item.TabIndex = 0;
            this.id_item.Text = "Item";
            // 
            // id_quantity
            // 
            this.id_quantity.AutoSize = true;
            this.id_quantity.Location = new System.Drawing.Point(292, 79);
            this.id_quantity.Name = "id_quantity";
            this.id_quantity.Size = new System.Drawing.Size(53, 15);
            this.id_quantity.TabIndex = 1;
            this.id_quantity.Text = "Quantity";
            // 
            // id_price
            // 
            this.id_price.AutoSize = true;
            this.id_price.Location = new System.Drawing.Point(377, 79);
            this.id_price.Name = "id_price";
            this.id_price.Size = new System.Drawing.Size(61, 15);
            this.id_price.TabIndex = 2;
            this.id_price.Text = "Price Each";
            // 
            // ext_price
            // 
            this.ext_price.AutoSize = true;
            this.ext_price.Location = new System.Drawing.Point(470, 79);
            this.ext_price.Name = "ext_price";
            this.ext_price.Size = new System.Drawing.Size(55, 15);
            this.ext_price.TabIndex = 3;
            this.ext_price.Text = "Ext. Price";
            // 
            // id_gloves
            // 
            this.id_gloves.Location = new System.Drawing.Point(186, 97);
            this.id_gloves.Name = "id_gloves";
            this.id_gloves.Size = new System.Drawing.Size(100, 23);
            this.id_gloves.TabIndex = 4;
            this.id_gloves.Text = "Gloves";
            // 
            // id_boots
            // 
            this.id_boots.Location = new System.Drawing.Point(186, 126);
            this.id_boots.Name = "id_boots";
            this.id_boots.Size = new System.Drawing.Size(100, 23);
            this.id_boots.TabIndex = 6;
            this.id_boots.Text = "Boots";
            // 
            // id_skis
            // 
            this.id_skis.Location = new System.Drawing.Point(186, 184);
            this.id_skis.Name = "id_skis";
            this.id_skis.Size = new System.Drawing.Size(100, 23);
            this.id_skis.TabIndex = 7;
            this.id_skis.Text = "Skis";
            // 
            // id_hat
            // 
            this.id_hat.Location = new System.Drawing.Point(186, 155);
            this.id_hat.Name = "id_hat";
            this.id_hat.Size = new System.Drawing.Size(100, 23);
            this.id_hat.TabIndex = 8;
            this.id_hat.Text = "Hat";
            // 
            // hat_price
            // 
            this.hat_price.Location = new System.Drawing.Point(377, 155);
            this.hat_price.Name = "hat_price";
            this.hat_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hat_price.Size = new System.Drawing.Size(61, 23);
            this.hat_price.TabIndex = 14;
            this.hat_price.Text = "6";
            this.hat_price.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // skis_price
            // 
            this.skis_price.Location = new System.Drawing.Point(377, 184);
            this.skis_price.Name = "skis_price";
            this.skis_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.skis_price.Size = new System.Drawing.Size(61, 23);
            this.skis_price.TabIndex = 13;
            this.skis_price.Text = "700";
            // 
            // boots_price
            // 
            this.boots_price.Location = new System.Drawing.Point(377, 126);
            this.boots_price.Name = "boots_price";
            this.boots_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.boots_price.Size = new System.Drawing.Size(61, 23);
            this.boots_price.TabIndex = 12;
            this.boots_price.Text = "30";
            // 
            // gloves_pricee
            // 
            this.gloves_pricee.Location = new System.Drawing.Point(377, 97);
            this.gloves_pricee.Name = "gloves_pricee";
            this.gloves_pricee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gloves_pricee.Size = new System.Drawing.Size(61, 23);
            this.gloves_pricee.TabIndex = 11;
            this.gloves_pricee.Text = "10";
            // 
            // ext_hat
            // 
            this.ext_hat.Location = new System.Drawing.Point(450, 155);
            this.ext_hat.Name = "ext_hat";
            this.ext_hat.Size = new System.Drawing.Size(100, 23);
            this.ext_hat.TabIndex = 18;
            // 
            // ext_skis
            // 
            this.ext_skis.Location = new System.Drawing.Point(450, 184);
            this.ext_skis.Name = "ext_skis";
            this.ext_skis.Size = new System.Drawing.Size(100, 23);
            this.ext_skis.TabIndex = 17;
            // 
            // ext_boots
            // 
            this.ext_boots.Location = new System.Drawing.Point(450, 126);
            this.ext_boots.Name = "ext_boots";
            this.ext_boots.Size = new System.Drawing.Size(100, 23);
            this.ext_boots.TabIndex = 16;
            // 
            // ext_gloves
            // 
            this.ext_gloves.Location = new System.Drawing.Point(450, 97);
            this.ext_gloves.Name = "ext_gloves";
            this.ext_gloves.Size = new System.Drawing.Size(100, 23);
            this.ext_gloves.TabIndex = 15;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(450, 316);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 23);
            this.textBox13.TabIndex = 22;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(450, 345);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 23);
            this.textBox14.TabIndex = 21;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(450, 287);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 23);
            this.textBox15.TabIndex = 20;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(450, 258);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 23);
            this.textBox16.TabIndex = 19;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(450, 376);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 23);
            this.textBox17.TabIndex = 23;
            // 
            // label_subtotal
            // 
            this.label_subtotal.AutoSize = true;
            this.label_subtotal.Location = new System.Drawing.Point(347, 266);
            this.label_subtotal.Name = "label_subtotal";
            this.label_subtotal.Size = new System.Drawing.Size(51, 15);
            this.label_subtotal.TabIndex = 24;
            this.label_subtotal.Text = "Subtotal";
            this.label_subtotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_tax_rate
            // 
            this.label_tax_rate.AutoSize = true;
            this.label_tax_rate.Location = new System.Drawing.Point(347, 295);
            this.label_tax_rate.Name = "label_tax_rate";
            this.label_tax_rate.Size = new System.Drawing.Size(50, 15);
            this.label_tax_rate.TabIndex = 25;
            this.label_tax_rate.Text = "Tax Rate";
            // 
            // label_grand_total
            // 
            this.label_grand_total.AutoSize = true;
            this.label_grand_total.Location = new System.Drawing.Point(347, 384);
            this.label_grand_total.Name = "label_grand_total";
            this.label_grand_total.Size = new System.Drawing.Size(67, 15);
            this.label_grand_total.TabIndex = 26;
            this.label_grand_total.Text = "Grand Total";
            // 
            // label_shipping
            // 
            this.label_shipping.AutoSize = true;
            this.label_shipping.Location = new System.Drawing.Point(347, 353);
            this.label_shipping.Name = "label_shipping";
            this.label_shipping.Size = new System.Drawing.Size(54, 15);
            this.label_shipping.TabIndex = 27;
            this.label_shipping.Text = "Shipping";
            // 
            // label_sales_tax
            // 
            this.label_sales_tax.AutoSize = true;
            this.label_sales_tax.Location = new System.Drawing.Point(347, 324);
            this.label_sales_tax.Name = "label_sales_tax";
            this.label_sales_tax.Size = new System.Drawing.Size(53, 15);
            this.label_sales_tax.TabIndex = 28;
            this.label_sales_tax.Text = "Sales Tax";
            // 
            // qgloves
            // 
            this.qgloves.Location = new System.Drawing.Point(292, 98);
            this.qgloves.Name = "qgloves";
            this.qgloves.Size = new System.Drawing.Size(53, 23);
            this.qgloves.TabIndex = 29;
            // 
            // qskis
            // 
            this.qskis.Location = new System.Drawing.Point(292, 184);
            this.qskis.Name = "qskis";
            this.qskis.Size = new System.Drawing.Size(53, 23);
            this.qskis.TabIndex = 30;
            this.qskis.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // qhat
            // 
            this.qhat.Location = new System.Drawing.Point(292, 156);
            this.qhat.Name = "qhat";
            this.qhat.Size = new System.Drawing.Size(53, 23);
            this.qhat.TabIndex = 31;
            // 
            // qboots
            // 
            this.qboots.Location = new System.Drawing.Point(292, 127);
            this.qboots.Name = "qboots";
            this.qboots.Size = new System.Drawing.Size(53, 23);
            this.qboots.TabIndex = 32;
            // 
            // calculatebtn
            // 
            this.calculatebtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calculatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculatebtn.Location = new System.Drawing.Point(186, 316);
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(121, 31);
            this.calculatebtn.TabIndex = 33;
            this.calculatebtn.Text = "Calculate";
            this.calculatebtn.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 480);
            this.Controls.Add(this.calculatebtn);
            this.Controls.Add(this.qboots);
            this.Controls.Add(this.qhat);
            this.Controls.Add(this.qskis);
            this.Controls.Add(this.qgloves);
            this.Controls.Add(this.label_sales_tax);
            this.Controls.Add(this.label_shipping);
            this.Controls.Add(this.label_grand_total);
            this.Controls.Add(this.label_tax_rate);
            this.Controls.Add(this.label_subtotal);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.ext_hat);
            this.Controls.Add(this.ext_skis);
            this.Controls.Add(this.ext_boots);
            this.Controls.Add(this.ext_gloves);
            this.Controls.Add(this.hat_price);
            this.Controls.Add(this.skis_price);
            this.Controls.Add(this.boots_price);
            this.Controls.Add(this.gloves_pricee);
            this.Controls.Add(this.id_hat);
            this.Controls.Add(this.id_skis);
            this.Controls.Add(this.id_boots);
            this.Controls.Add(this.id_gloves);
            this.Controls.Add(this.ext_price);
            this.Controls.Add(this.id_price);
            this.Controls.Add(this.id_quantity);
            this.Controls.Add(this.id_item);
            this.Name = "Form4";
            this.Text = "SalesTaxCalculator";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qgloves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qskis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qboots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label id_item;
        private Label id_quantity;
        private Label id_price;
        private Label ext_price;
        private TextBox id_gloves;
        private TextBox id_boots;
        private TextBox id_skis;
        private TextBox id_hat;
        private TextBox hat_price;
        private TextBox skis_price;
        private TextBox boots_price;
        private TextBox gloves_pricee;
        private TextBox ext_hat;
        private TextBox ext_skis;
        private TextBox ext_boots;
        private TextBox ext_gloves;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private Label label_subtotal;
        private Label label_tax_rate;
        private Label label_grand_total;
        private Label label_shipping;
        private Label label_sales_tax;
        private NumericUpDown qgloves;
        private NumericUpDown qskis;
        private NumericUpDown qhat;
        private NumericUpDown qboots;
        private Button calculatebtn;
    }
}