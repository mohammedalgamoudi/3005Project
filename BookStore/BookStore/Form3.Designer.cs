namespace BookStore
{
	partial class Form3
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.BillingBox1 = new System.Windows.Forms.TextBox();
			this.BillingBox2 = new System.Windows.Forms.TextBox();
			this.SubmitBtn = new System.Windows.Forms.Button();
			this.ShippingBox1 = new System.Windows.Forms.TextBox();
			this.ShippingBox2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(347, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Shipping Information";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Billing Information";
			// 
			// BillingBox1
			// 
			this.BillingBox1.Location = new System.Drawing.Point(36, 94);
			this.BillingBox1.Name = "BillingBox1";
			this.BillingBox1.Size = new System.Drawing.Size(253, 26);
			this.BillingBox1.TabIndex = 4;
			// 
			// BillingBox2
			// 
			this.BillingBox2.Location = new System.Drawing.Point(36, 138);
			this.BillingBox2.Name = "BillingBox2";
			this.BillingBox2.Size = new System.Drawing.Size(253, 26);
			this.BillingBox2.TabIndex = 5;
			// 
			// SubmitBtn
			// 
			this.SubmitBtn.Location = new System.Drawing.Point(245, 201);
			this.SubmitBtn.Name = "SubmitBtn";
			this.SubmitBtn.Size = new System.Drawing.Size(146, 43);
			this.SubmitBtn.TabIndex = 6;
			this.SubmitBtn.Text = "Submit";
			this.SubmitBtn.UseVisualStyleBackColor = true;
			this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
			// 
			// ShippingBox1
			// 
			this.ShippingBox1.Location = new System.Drawing.Point(351, 94);
			this.ShippingBox1.Name = "ShippingBox1";
			this.ShippingBox1.Size = new System.Drawing.Size(253, 26);
			this.ShippingBox1.TabIndex = 7;
			// 
			// ShippingBox2
			// 
			this.ShippingBox2.Location = new System.Drawing.Point(351, 138);
			this.ShippingBox2.Name = "ShippingBox2";
			this.ShippingBox2.Size = new System.Drawing.Size(253, 26);
			this.ShippingBox2.TabIndex = 8;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 285);
			this.Controls.Add(this.ShippingBox2);
			this.Controls.Add(this.ShippingBox1);
			this.Controls.Add(this.SubmitBtn);
			this.Controls.Add(this.BillingBox2);
			this.Controls.Add(this.BillingBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form3";
			this.Text = "Order Confirmation";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox BillingBox1;
		private System.Windows.Forms.TextBox BillingBox2;
		private System.Windows.Forms.Button SubmitBtn;
		private System.Windows.Forms.TextBox ShippingBox1;
		private System.Windows.Forms.TextBox ShippingBox2;
	}
}