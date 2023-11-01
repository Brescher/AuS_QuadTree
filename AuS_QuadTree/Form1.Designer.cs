namespace AuS_QuadTree
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
            output = new TextBox();
            X1 = new TextBox();
            Y1 = new TextBox();
            X2 = new TextBox();
            Y2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            findParcels = new Button();
            findEstates = new Button();
            findBoth = new Button();
            label5 = new Label();
            label6 = new Label();
            number = new TextBox();
            description = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            insertY2 = new TextBox();
            insertX2 = new TextBox();
            insertY1 = new TextBox();
            insertX1 = new TextBox();
            insertParcel = new Button();
            insertEstate = new Button();
            SuspendLayout();
            // 
            // output
            // 
            output.Location = new Point(465, 12);
            output.Multiline = true;
            output.Name = "output";
            output.ReadOnly = true;
            output.Size = new Size(490, 685);
            output.TabIndex = 0;
            // 
            // X1
            // 
            X1.Location = new Point(101, 42);
            X1.Name = "X1";
            X1.Size = new Size(54, 23);
            X1.TabIndex = 1;
            // 
            // Y1
            // 
            Y1.Location = new Point(161, 42);
            Y1.Name = "Y1";
            Y1.Size = new Size(54, 23);
            Y1.TabIndex = 2;
            // 
            // X2
            // 
            X2.Location = new Point(219, 42);
            X2.Name = "X2";
            X2.Size = new Size(54, 23);
            X2.TabIndex = 3;
            // 
            // Y2
            // 
            Y2.Location = new Point(279, 42);
            Y2.Name = "Y2";
            Y2.Size = new Size(54, 23);
            Y2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 24);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 5;
            label1.Text = "X1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 24);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 6;
            label2.Text = "Y1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 24);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 7;
            label3.Text = "X2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 24);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 8;
            label4.Text = "Y2";
            // 
            // findParcels
            // 
            findParcels.Location = new Point(339, 12);
            findParcels.Name = "findParcels";
            findParcels.Size = new Size(120, 23);
            findParcels.TabIndex = 9;
            findParcels.Text = "Find parcels";
            findParcels.UseVisualStyleBackColor = true;
            findParcels.Click += findParcels_Click;
            // 
            // findEstates
            // 
            findEstates.Location = new Point(339, 41);
            findEstates.Name = "findEstates";
            findEstates.Size = new Size(120, 23);
            findEstates.TabIndex = 10;
            findEstates.Text = "Find estates";
            findEstates.UseVisualStyleBackColor = true;
            findEstates.Click += findEstates_Click;
            // 
            // findBoth
            // 
            findBoth.Location = new Point(339, 70);
            findBoth.Name = "findBoth";
            findBoth.Size = new Size(120, 23);
            findBoth.TabIndex = 11;
            findBoth.Text = "Find both";
            findBoth.UseVisualStyleBackColor = true;
            findBoth.Click += findBoth_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 159);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 12;
            label5.Text = "Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(179, 159);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 13;
            label6.Text = "Description";
            // 
            // number
            // 
            number.Location = new Point(101, 177);
            number.Name = "number";
            number.Size = new Size(72, 23);
            number.TabIndex = 18;
            // 
            // description
            // 
            description.Location = new Point(179, 177);
            description.Name = "description";
            description.Size = new Size(154, 23);
            description.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(279, 203);
            label11.Name = "label11";
            label11.Size = new Size(20, 15);
            label11.TabIndex = 27;
            label11.Text = "Y2";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(219, 203);
            label12.Name = "label12";
            label12.Size = new Size(20, 15);
            label12.TabIndex = 26;
            label12.Text = "X2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(161, 203);
            label13.Name = "label13";
            label13.Size = new Size(20, 15);
            label13.TabIndex = 25;
            label13.Text = "Y1";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(101, 203);
            label14.Name = "label14";
            label14.Size = new Size(20, 15);
            label14.TabIndex = 24;
            label14.Text = "X1";
            // 
            // insertY2
            // 
            insertY2.Location = new Point(279, 221);
            insertY2.Name = "insertY2";
            insertY2.Size = new Size(54, 23);
            insertY2.TabIndex = 23;
            // 
            // insertX2
            // 
            insertX2.Location = new Point(219, 221);
            insertX2.Name = "insertX2";
            insertX2.Size = new Size(54, 23);
            insertX2.TabIndex = 22;
            // 
            // insertY1
            // 
            insertY1.Location = new Point(161, 221);
            insertY1.Name = "insertY1";
            insertY1.Size = new Size(54, 23);
            insertY1.TabIndex = 21;
            // 
            // insertX1
            // 
            insertX1.Location = new Point(101, 221);
            insertX1.Name = "insertX1";
            insertX1.Size = new Size(54, 23);
            insertX1.TabIndex = 20;
            // 
            // insertParcel
            // 
            insertParcel.Location = new Point(339, 159);
            insertParcel.Name = "insertParcel";
            insertParcel.Size = new Size(120, 23);
            insertParcel.TabIndex = 28;
            insertParcel.Text = "Insert parcel";
            insertParcel.UseVisualStyleBackColor = true;
            insertParcel.Click += insertParcel_Click;
            // 
            // insertEstate
            // 
            insertEstate.Location = new Point(339, 188);
            insertEstate.Name = "insertEstate";
            insertEstate.Size = new Size(120, 23);
            insertEstate.TabIndex = 29;
            insertEstate.Text = "Insert estate";
            insertEstate.UseVisualStyleBackColor = true;
            insertEstate.Click += insertEstate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 709);
            Controls.Add(insertEstate);
            Controls.Add(insertParcel);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(insertY2);
            Controls.Add(insertX2);
            Controls.Add(insertY1);
            Controls.Add(insertX1);
            Controls.Add(description);
            Controls.Add(number);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(findBoth);
            Controls.Add(findEstates);
            Controls.Add(findParcels);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Y2);
            Controls.Add(X2);
            Controls.Add(Y1);
            Controls.Add(X1);
            Controls.Add(output);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox output;
        private TextBox X1;
        private TextBox Y1;
        private TextBox X2;
        private TextBox Y2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button findParcels;
        private Button findEstates;
        private Button findBoth;
        private Label label5;
        private Label label6;
        private TextBox number;
        private TextBox description;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox insertY2;
        private TextBox insertX2;
        private TextBox insertY1;
        private TextBox insertX1;
        private Button insertParcel;
        private Button insertEstate;
    }
}