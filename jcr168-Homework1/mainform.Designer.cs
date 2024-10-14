namespace jcr168_Homework1
{
    partial class Hungry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hungry));
            this.boxMeal = new System.Windows.Forms.GroupBox();
            this.labelSix = new System.Windows.Forms.Label();
            this.labelFour = new System.Windows.Forms.Label();
            this.labelTwo = new System.Windows.Forms.Label();
            this.numericSix = new System.Windows.Forms.NumericUpDown();
            this.numericFour = new System.Windows.Forms.NumericUpDown();
            this.numericTwo = new System.Windows.Forms.NumericUpDown();
            this.checkSix = new System.Windows.Forms.CheckBox();
            this.checkFour = new System.Windows.Forms.CheckBox();
            this.checkTwo = new System.Windows.Forms.CheckBox();
            this.boxMember = new System.Windows.Forms.GroupBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.radioBronze = new System.Windows.Forms.RadioButton();
            this.radioSilver = new System.Windows.Forms.RadioButton();
            this.radioGold = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textDiscount = new System.Windows.Forms.TextBox();
            this.textGST = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCalcConfirm = new System.Windows.Forms.Label();
            this.pictureAuthor = new System.Windows.Forms.PictureBox();
            this.boxMeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTwo)).BeginInit();
            this.boxMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // boxMeal
            // 
            this.boxMeal.BackColor = System.Drawing.SystemColors.Control;
            this.boxMeal.Controls.Add(this.labelSix);
            this.boxMeal.Controls.Add(this.labelFour);
            this.boxMeal.Controls.Add(this.labelTwo);
            this.boxMeal.Controls.Add(this.numericSix);
            this.boxMeal.Controls.Add(this.numericFour);
            this.boxMeal.Controls.Add(this.numericTwo);
            this.boxMeal.Controls.Add(this.checkSix);
            this.boxMeal.Controls.Add(this.checkFour);
            this.boxMeal.Controls.Add(this.checkTwo);
            this.boxMeal.Location = new System.Drawing.Point(12, 12);
            this.boxMeal.Name = "boxMeal";
            this.boxMeal.Size = new System.Drawing.Size(278, 114);
            this.boxMeal.TabIndex = 0;
            this.boxMeal.TabStop = false;
            this.boxMeal.Text = "How many people should each meal feed?";
            // 
            // labelSix
            // 
            this.labelSix.AutoSize = true;
            this.labelSix.Location = new System.Drawing.Point(202, 82);
            this.labelSix.Name = "labelSix";
            this.labelSix.Size = new System.Drawing.Size(52, 13);
            this.labelSix.TabIndex = 9;
            this.labelSix.Text = "$30 each";
            // 
            // labelFour
            // 
            this.labelFour.AutoSize = true;
            this.labelFour.Location = new System.Drawing.Point(202, 56);
            this.labelFour.Name = "labelFour";
            this.labelFour.Size = new System.Drawing.Size(52, 13);
            this.labelFour.TabIndex = 8;
            this.labelFour.Text = "$20 each";
            // 
            // labelTwo
            // 
            this.labelTwo.AutoSize = true;
            this.labelTwo.Location = new System.Drawing.Point(202, 33);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(52, 13);
            this.labelTwo.TabIndex = 7;
            this.labelTwo.Text = "$15 each";
            // 
            // numericSix
            // 
            this.numericSix.Enabled = false;
            this.numericSix.Location = new System.Drawing.Point(151, 77);
            this.numericSix.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericSix.Name = "numericSix";
            this.numericSix.Size = new System.Drawing.Size(42, 20);
            this.numericSix.TabIndex = 6;
            // 
            // numericFour
            // 
            this.numericFour.Enabled = false;
            this.numericFour.Location = new System.Drawing.Point(151, 54);
            this.numericFour.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericFour.Name = "numericFour";
            this.numericFour.Size = new System.Drawing.Size(42, 20);
            this.numericFour.TabIndex = 4;
            // 
            // numericTwo
            // 
            this.numericTwo.Enabled = false;
            this.numericTwo.Location = new System.Drawing.Point(151, 31);
            this.numericTwo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericTwo.Name = "numericTwo";
            this.numericTwo.Size = new System.Drawing.Size(42, 20);
            this.numericTwo.TabIndex = 2;
            // 
            // checkSix
            // 
            this.checkSix.AutoSize = true;
            this.checkSix.Location = new System.Drawing.Point(6, 78);
            this.checkSix.Name = "checkSix";
            this.checkSix.Size = new System.Drawing.Size(76, 17);
            this.checkSix.TabIndex = 5;
            this.checkSix.Text = "Six People";
            this.checkSix.UseVisualStyleBackColor = true;
            this.checkSix.CheckedChanged += new System.EventHandler(this.checkSix_CheckedChanged);
            // 
            // checkFour
            // 
            this.checkFour.AutoSize = true;
            this.checkFour.Location = new System.Drawing.Point(6, 55);
            this.checkFour.Name = "checkFour";
            this.checkFour.Size = new System.Drawing.Size(83, 17);
            this.checkFour.TabIndex = 3;
            this.checkFour.Text = "Four People";
            this.checkFour.UseVisualStyleBackColor = true;
            this.checkFour.CheckedChanged += new System.EventHandler(this.checkFour_CheckedChanged);
            // 
            // checkTwo
            // 
            this.checkTwo.AutoSize = true;
            this.checkTwo.Location = new System.Drawing.Point(6, 32);
            this.checkTwo.Name = "checkTwo";
            this.checkTwo.Size = new System.Drawing.Size(83, 17);
            this.checkTwo.TabIndex = 1;
            this.checkTwo.Text = "Two People";
            this.checkTwo.UseVisualStyleBackColor = true;
            this.checkTwo.CheckedChanged += new System.EventHandler(this.checkTwo_CheckedChanged);
            // 
            // boxMember
            // 
            this.boxMember.BackColor = System.Drawing.SystemColors.Control;
            this.boxMember.Controls.Add(this.pictureLogo);
            this.boxMember.Controls.Add(this.radioBronze);
            this.boxMember.Controls.Add(this.radioSilver);
            this.boxMember.Controls.Add(this.radioGold);
            this.boxMember.Location = new System.Drawing.Point(12, 132);
            this.boxMember.Name = "boxMember";
            this.boxMember.Size = new System.Drawing.Size(278, 114);
            this.boxMember.TabIndex = 1;
            this.boxMember.TabStop = false;
            this.boxMember.Text = "What membership do you have?";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::jcr168_Homework1.Properties.Resources.icon;
            this.pictureLogo.Location = new System.Drawing.Point(133, 13);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(121, 95);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 16;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.WaitOnLoad = true;
            this.pictureLogo.Click += new System.EventHandler(this.medalPicture_Click);
            // 
            // radioBronze
            // 
            this.radioBronze.AutoSize = true;
            this.radioBronze.Location = new System.Drawing.Point(6, 78);
            this.radioBronze.Name = "radioBronze";
            this.radioBronze.Size = new System.Drawing.Size(58, 17);
            this.radioBronze.TabIndex = 9;
            this.radioBronze.TabStop = true;
            this.radioBronze.Text = "Bronze";
            this.radioBronze.UseVisualStyleBackColor = true;
            // 
            // radioSilver
            // 
            this.radioSilver.AutoSize = true;
            this.radioSilver.Location = new System.Drawing.Point(6, 55);
            this.radioSilver.Name = "radioSilver";
            this.radioSilver.Size = new System.Drawing.Size(51, 17);
            this.radioSilver.TabIndex = 8;
            this.radioSilver.TabStop = true;
            this.radioSilver.Text = "Silver";
            this.radioSilver.UseVisualStyleBackColor = true;
            // 
            // radioGold
            // 
            this.radioGold.AutoSize = true;
            this.radioGold.Location = new System.Drawing.Point(6, 32);
            this.radioGold.Name = "radioGold";
            this.radioGold.Size = new System.Drawing.Size(47, 17);
            this.radioGold.TabIndex = 7;
            this.radioGold.TabStop = true;
            this.radioGold.Text = "Gold";
            this.radioGold.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 252);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(278, 38);
            this.buttonCalculate.TabIndex = 10;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(66, 309);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(74, 13);
            this.labelDiscount.TabIndex = 8;
            this.labelDiscount.Text = "Your Discount";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(72, 335);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(68, 13);
            this.labelTax.TabIndex = 9;
            this.labelTax.Text = "GST Amount";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(82, 361);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(58, 13);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "Total Price";
            // 
            // textDiscount
            // 
            this.textDiscount.Location = new System.Drawing.Point(146, 306);
            this.textDiscount.Name = "textDiscount";
            this.textDiscount.ReadOnly = true;
            this.textDiscount.Size = new System.Drawing.Size(103, 20);
            this.textDiscount.TabIndex = 11;
            // 
            // textGST
            // 
            this.textGST.Location = new System.Drawing.Point(146, 332);
            this.textGST.Name = "textGST";
            this.textGST.ReadOnly = true;
            this.textGST.Size = new System.Drawing.Size(103, 20);
            this.textGST.TabIndex = 12;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(146, 358);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(103, 20);
            this.textTotal.TabIndex = 13;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Enabled = false;
            this.buttonOrder.Location = new System.Drawing.Point(12, 397);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(278, 38);
            this.buttonOrder.TabIndex = 11;
            this.buttonOrder.Text = "Place my order!";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(12, 441);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(278, 38);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelCalcConfirm
            // 
            this.labelCalcConfirm.AutoSize = true;
            this.labelCalcConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalcConfirm.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelCalcConfirm.Location = new System.Drawing.Point(42, 381);
            this.labelCalcConfirm.Name = "labelCalcConfirm";
            this.labelCalcConfirm.Size = new System.Drawing.Size(220, 13);
            this.labelCalcConfirm.TabIndex = 16;
            this.labelCalcConfirm.Text = "Price calculated successfully - ready to order!";
            this.labelCalcConfirm.Visible = false;
            // 
            // pictureAuthor
            // 
            this.pictureAuthor.Image = global::jcr168_Homework1.Properties.Resources.Artboard_2_copy_1;
            this.pictureAuthor.Location = new System.Drawing.Point(12, 485);
            this.pictureAuthor.Name = "pictureAuthor";
            this.pictureAuthor.Size = new System.Drawing.Size(278, 139);
            this.pictureAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAuthor.TabIndex = 17;
            this.pictureAuthor.TabStop = false;
            this.pictureAuthor.Click += new System.EventHandler(this.pictureAuthor_Click);
            // 
            // Hungry
            // 
            this.AcceptButton = this.buttonOrder;
            this.AccessibleDescription = "Food box order form.";
            this.AccessibleName = "Hungry?";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(305, 636);
            this.Controls.Add(this.pictureAuthor);
            this.Controls.Add(this.labelCalcConfirm);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textGST);
            this.Controls.Add(this.textDiscount);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.boxMember);
            this.Controls.Add(this.boxMeal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(321, 675);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(321, 675);
            this.Name = "Hungry";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hungry?";
            this.boxMeal.ResumeLayout(false);
            this.boxMeal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTwo)).EndInit();
            this.boxMember.ResumeLayout(false);
            this.boxMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox boxMeal;
        private System.Windows.Forms.CheckBox checkSix;
        private System.Windows.Forms.CheckBox checkFour;
        private System.Windows.Forms.CheckBox checkTwo;
        private System.Windows.Forms.GroupBox boxMember;
        private System.Windows.Forms.RadioButton radioBronze;
        private System.Windows.Forms.RadioButton radioSilver;
        private System.Windows.Forms.RadioButton radioGold;
        private System.Windows.Forms.NumericUpDown numericSix;
        private System.Windows.Forms.NumericUpDown numericFour;
        private System.Windows.Forms.NumericUpDown numericTwo;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelSix;
        private System.Windows.Forms.Label labelFour;
        private System.Windows.Forms.Label labelTwo;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textDiscount;
        private System.Windows.Forms.TextBox textGST;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label labelCalcConfirm;
        private System.Windows.Forms.PictureBox pictureAuthor;
    }
}

