
namespace BirthdayCatdBuilder
{
    partial class Form1
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
            this.btn_load = new System.Windows.Forms.Button();
            this.list_Card = new System.Windows.Forms.ListBox();
            this.pic_display = new System.Windows.Forms.PictureBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_record = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_display)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(13, 13);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(105, 23);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load Excel";
            this.btn_load.UseVisualStyleBackColor = true;
            // 
            // list_Card
            // 
            this.list_Card.FormattingEnabled = true;
            this.list_Card.ItemHeight = 15;
            this.list_Card.Location = new System.Drawing.Point(13, 55);
            this.list_Card.Name = "list_Card";
            this.list_Card.Size = new System.Drawing.Size(167, 349);
            this.list_Card.TabIndex = 1;
            // 
            // pic_display
            // 
            this.pic_display.Location = new System.Drawing.Point(213, 38);
            this.pic_display.Name = "pic_display";
            this.pic_display.Size = new System.Drawing.Size(562, 387);
            this.pic_display.TabIndex = 2;
            this.pic_display.TabStop = false;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(615, 9);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(534, 9);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 23);
            this.btn_prev.TabIndex = 4;
            this.btn_prev.Text = "Prev";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_record
            // 
            this.btn_record.Location = new System.Drawing.Point(700, 9);
            this.btn_record.Name = "btn_record";
            this.btn_record.Size = new System.Drawing.Size(75, 23);
            this.btn_record.TabIndex = 5;
            this.btn_record.Text = "Record";
            this.btn_record.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_record);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.pic_display);
            this.Controls.Add(this.list_Card);
            this.Controls.Add(this.btn_load);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ListBox list_Card;
        private System.Windows.Forms.PictureBox op;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_record;
        private System.Windows.Forms.PictureBox pic_display;
    }
}

