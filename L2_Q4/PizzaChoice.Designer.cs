
namespace L2_Q4
{
    partial class PizzaChoice
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.gbBase = new System.Windows.Forms.GroupBox();
            this.rbCheese = new System.Windows.Forms.RadioButton();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.lblToppings = new System.Windows.Forms.Label();
            this.clbToppings = new System.Windows.Forms.CheckedListBox();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(365, 71);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(704, 94);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(490, 36);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(103, 36);
            this.rbLarge.TabIndex = 6;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(257, 36);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(135, 36);
            this.rbMedium.TabIndex = 5;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(24, 40);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(103, 36);
            this.rbSmall.TabIndex = 3;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(54, 111);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(165, 32);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Choose a size:";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(45, 252);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(174, 32);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Choose a base:";
            // 
            // gbBase
            // 
            this.gbBase.Controls.Add(this.rbCheese);
            this.gbBase.Controls.Add(this.rbThick);
            this.gbBase.Controls.Add(this.rbThin);
            this.gbBase.Location = new System.Drawing.Point(365, 212);
            this.gbBase.Name = "gbBase";
            this.gbBase.Size = new System.Drawing.Size(704, 94);
            this.gbBase.TabIndex = 3;
            this.gbBase.TabStop = false;
            // 
            // rbCheese
            // 
            this.rbCheese.AutoSize = true;
            this.rbCheese.Location = new System.Drawing.Point(474, 40);
            this.rbCheese.Name = "rbCheese";
            this.rbCheese.Size = new System.Drawing.Size(236, 36);
            this.rbCheese.TabIndex = 7;
            this.rbCheese.TabStop = true;
            this.rbCheese.Text = "Cheese (extra €2) ";
            this.rbCheese.UseVisualStyleBackColor = true;
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(257, 38);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(101, 36);
            this.rbThick.TabIndex = 5;
            this.rbThick.TabStop = true;
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(24, 38);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(92, 36);
            this.rbThin.TabIndex = 4;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(66, 575);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(200, 32);
            this.lblToppings.TabIndex = 4;
            this.lblToppings.Text = "Choose toppings:";
            // 
            // clbToppings
            // 
            this.clbToppings.FormattingEnabled = true;
            this.clbToppings.Items.AddRange(new object[] {
            "Pepperoni",
            "Mushrooms",
            "Sweetcorn",
            "Pineapple",
            "Ham",
            "Jalapeno Peppers",
            "Bacon",
            "Olives",
            "Pork Meatballs",
            "Chorizo"});
            this.clbToppings.Location = new System.Drawing.Point(389, 409);
            this.clbToppings.Name = "clbToppings";
            this.clbToppings.Size = new System.Drawing.Size(448, 364);
            this.clbToppings.TabIndex = 5;
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.Location = new System.Drawing.Point(915, 575);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(264, 68);
            this.btnAddPizza.TabIndex = 6;
            this.btnAddPizza.Text = "ADD TO ORDER";
            this.btnAddPizza.UseVisualStyleBackColor = true;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click);
            // 
            // PizzaChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1228, 927);
            this.Controls.Add(this.btnAddPizza);
            this.Controls.Add(this.clbToppings);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.gbBase);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.gbSize);
            this.Name = "PizzaChoice";
            this.Text = "Make Your Pizza";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbBase.ResumeLayout(false);
            this.gbBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.GroupBox gbBase;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.CheckedListBox clbToppings;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.RadioButton rbCheese;
    }
}