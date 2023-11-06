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
            save = new Button();
            load = new Button();
            dataGridView1 = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            KeyCol = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            LowerX = new DataGridViewTextBoxColumn();
            LowerY = new DataGridViewTextBoxColumn();
            UpperX = new DataGridViewTextBoxColumn();
            UpperY = new DataGridViewTextBoxColumn();
            SpanFrom = new DataGridViewTextBoxColumn();
            SpanTo = new DataGridViewTextBoxColumn();
            label7 = new Label();
            indexToEdit = new TextBox();
            Edit = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label15 = new Label();
            editY2 = new TextBox();
            editX2 = new TextBox();
            editY1 = new TextBox();
            editX1 = new TextBox();
            editDesc = new TextBox();
            editNumber = new TextBox();
            label16 = new Label();
            label17 = new Label();
            keyBox = new TextBox();
            label19 = new Label();
            label18 = new Label();
            indexToDelete = new TextBox();
            delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // X1
            // 
            X1.Location = new Point(140, 37);
            X1.Name = "X1";
            X1.Size = new Size(72, 23);
            X1.TabIndex = 1;
            // 
            // Y1
            // 
            Y1.Location = new Point(218, 37);
            Y1.Name = "Y1";
            Y1.Size = new Size(72, 23);
            Y1.TabIndex = 2;
            // 
            // X2
            // 
            X2.Location = new Point(296, 37);
            X2.Name = "X2";
            X2.Size = new Size(71, 23);
            X2.TabIndex = 3;
            // 
            // Y2
            // 
            Y2.Location = new Point(373, 37);
            Y2.Name = "Y2";
            Y2.Size = new Size(72, 23);
            Y2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 19);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 5;
            label1.Text = "X1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 18);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 6;
            label2.Text = "Y1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 18);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 7;
            label3.Text = "X2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 19);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 8;
            label4.Text = "Y2";
            // 
            // findParcels
            // 
            findParcels.Location = new Point(451, 10);
            findParcels.Name = "findParcels";
            findParcels.Size = new Size(120, 23);
            findParcels.TabIndex = 9;
            findParcels.Text = "Find parcels";
            findParcels.UseVisualStyleBackColor = true;
            findParcels.Click += findParcels_Click;
            // 
            // findEstates
            // 
            findEstates.Location = new Point(451, 36);
            findEstates.Name = "findEstates";
            findEstates.Size = new Size(120, 23);
            findEstates.TabIndex = 10;
            findEstates.Text = "Find estates";
            findEstates.UseVisualStyleBackColor = true;
            findEstates.Click += findEstates_Click;
            // 
            // findBoth
            // 
            findBoth.Location = new Point(451, 65);
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
            label5.Location = new Point(586, 19);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 12;
            label5.Text = "Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(753, 19);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 13;
            label6.Text = "Description";
            // 
            // number
            // 
            number.Location = new Point(586, 37);
            number.Name = "number";
            number.Size = new Size(72, 23);
            number.TabIndex = 18;
            // 
            // description
            // 
            description.Location = new Point(753, 37);
            description.Name = "description";
            description.Size = new Size(154, 23);
            description.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(820, 64);
            label11.Name = "label11";
            label11.Size = new Size(20, 15);
            label11.TabIndex = 27;
            label11.Text = "Y2";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(742, 64);
            label12.Name = "label12";
            label12.Size = new Size(20, 15);
            label12.TabIndex = 26;
            label12.Text = "X2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(664, 64);
            label13.Name = "label13";
            label13.Size = new Size(20, 15);
            label13.TabIndex = 25;
            label13.Text = "Y1";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(586, 64);
            label14.Name = "label14";
            label14.Size = new Size(20, 15);
            label14.TabIndex = 24;
            label14.Text = "X1";
            // 
            // insertY2
            // 
            insertY2.Location = new Point(820, 81);
            insertY2.Name = "insertY2";
            insertY2.Size = new Size(72, 23);
            insertY2.TabIndex = 23;
            // 
            // insertX2
            // 
            insertX2.Location = new Point(742, 82);
            insertX2.Name = "insertX2";
            insertX2.Size = new Size(72, 23);
            insertX2.TabIndex = 22;
            // 
            // insertY1
            // 
            insertY1.Location = new Point(664, 82);
            insertY1.Name = "insertY1";
            insertY1.Size = new Size(72, 23);
            insertY1.TabIndex = 21;
            // 
            // insertX1
            // 
            insertX1.Location = new Point(586, 82);
            insertX1.Name = "insertX1";
            insertX1.Size = new Size(72, 23);
            insertX1.TabIndex = 20;
            // 
            // insertParcel
            // 
            insertParcel.Location = new Point(913, 36);
            insertParcel.Name = "insertParcel";
            insertParcel.Size = new Size(120, 25);
            insertParcel.TabIndex = 28;
            insertParcel.Text = "Insert parcel";
            insertParcel.UseVisualStyleBackColor = true;
            insertParcel.Click += insertParcel_Click;
            // 
            // insertEstate
            // 
            insertEstate.Location = new Point(913, 63);
            insertEstate.Name = "insertEstate";
            insertEstate.Size = new Size(120, 25);
            insertEstate.TabIndex = 29;
            insertEstate.Text = "Insert estate";
            insertEstate.UseVisualStyleBackColor = true;
            insertEstate.Click += insertEstate_Click;
            // 
            // save
            // 
            save.Location = new Point(12, 11);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 30;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            // 
            // load
            // 
            load.Location = new Point(12, 40);
            load.Name = "load";
            load.Size = new Size(75, 23);
            load.TabIndex = 31;
            load.Text = "Load";
            load.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { No, Id, KeyCol, dataGridViewTextBoxColumn1, LowerX, LowerY, UpperX, UpperY, SpanFrom, SpanTo });
            dataGridView1.Location = new Point(12, 349);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1130, 465);
            dataGridView1.TabIndex = 32;
            // 
            // No
            // 
            No.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            No.HeaderText = "No.";
            No.Name = "No";
            No.ReadOnly = true;
            No.Width = 51;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // KeyCol
            // 
            KeyCol.HeaderText = "Key";
            KeyCol.Name = "KeyCol";
            KeyCol.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Description";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // LowerX
            // 
            LowerX.HeaderText = "Lower X";
            LowerX.Name = "LowerX";
            LowerX.ReadOnly = true;
            // 
            // LowerY
            // 
            LowerY.HeaderText = "Lower Y";
            LowerY.Name = "LowerY";
            LowerY.ReadOnly = true;
            // 
            // UpperX
            // 
            UpperX.HeaderText = "Upper X";
            UpperX.Name = "UpperX";
            UpperX.ReadOnly = true;
            // 
            // UpperY
            // 
            UpperY.HeaderText = "Upper Y";
            UpperY.Name = "UpperY";
            UpperY.ReadOnly = true;
            // 
            // SpanFrom
            // 
            SpanFrom.HeaderText = "Span From";
            SpanFrom.Name = "SpanFrom";
            SpanFrom.ReadOnly = true;
            // 
            // SpanTo
            // 
            SpanTo.HeaderText = "Span To";
            SpanTo.Name = "SpanTo";
            SpanTo.ReadOnly = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(171, 138);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 33;
            label7.Text = "Index";
            // 
            // indexToEdit
            // 
            indexToEdit.Location = new Point(171, 156);
            indexToEdit.Name = "indexToEdit";
            indexToEdit.Size = new Size(36, 23);
            indexToEdit.TabIndex = 34;
            // 
            // Edit
            // 
            Edit.Location = new Point(451, 154);
            Edit.Name = "Edit";
            Edit.Size = new Size(75, 25);
            Edit.TabIndex = 35;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(351, 181);
            label8.Name = "label8";
            label8.Size = new Size(20, 15);
            label8.TabIndex = 47;
            label8.Text = "Y2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(291, 182);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 46;
            label9.Text = "X2";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(231, 181);
            label10.Name = "label10";
            label10.Size = new Size(20, 15);
            label10.TabIndex = 45;
            label10.Text = "Y1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(171, 182);
            label15.Name = "label15";
            label15.Size = new Size(20, 15);
            label15.TabIndex = 44;
            label15.Text = "X1";
            // 
            // editY2
            // 
            editY2.Location = new Point(351, 199);
            editY2.Name = "editY2";
            editY2.Size = new Size(54, 23);
            editY2.TabIndex = 43;
            // 
            // editX2
            // 
            editX2.Location = new Point(291, 199);
            editX2.Name = "editX2";
            editX2.Size = new Size(54, 23);
            editX2.TabIndex = 42;
            // 
            // editY1
            // 
            editY1.Location = new Point(231, 199);
            editY1.Name = "editY1";
            editY1.Size = new Size(54, 23);
            editY1.TabIndex = 41;
            // 
            // editX1
            // 
            editX1.Location = new Point(171, 199);
            editX1.Name = "editX1";
            editX1.Size = new Size(54, 23);
            editX1.TabIndex = 40;
            // 
            // editDesc
            // 
            editDesc.Location = new Point(291, 155);
            editDesc.Name = "editDesc";
            editDesc.Size = new Size(154, 23);
            editDesc.TabIndex = 39;
            // 
            // editNumber
            // 
            editNumber.Location = new Point(213, 156);
            editNumber.Name = "editNumber";
            editNumber.Size = new Size(72, 23);
            editNumber.TabIndex = 38;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(291, 137);
            label16.Name = "label16";
            label16.Size = new Size(67, 15);
            label16.TabIndex = 37;
            label16.Text = "Description";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(213, 137);
            label17.Name = "label17";
            label17.Size = new Size(51, 15);
            label17.TabIndex = 36;
            label17.Text = "Number";
            // 
            // keyBox
            // 
            keyBox.Location = new Point(664, 37);
            keyBox.Name = "keyBox";
            keyBox.Size = new Size(83, 23);
            keyBox.TabIndex = 50;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(664, 19);
            label19.Name = "label19";
            label19.Size = new Size(26, 15);
            label19.TabIndex = 51;
            label19.Text = "Key";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(586, 137);
            label18.Name = "label18";
            label18.Size = new Size(36, 15);
            label18.TabIndex = 52;
            label18.Text = "Index";
            // 
            // indexToDelete
            // 
            indexToDelete.Location = new Point(586, 156);
            indexToDelete.Name = "indexToDelete";
            indexToDelete.Size = new Size(72, 23);
            indexToDelete.TabIndex = 53;
            // 
            // delete
            // 
            delete.Location = new Point(664, 156);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 54;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 826);
            Controls.Add(delete);
            Controls.Add(indexToDelete);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(keyBox);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label15);
            Controls.Add(editY2);
            Controls.Add(editX2);
            Controls.Add(editY1);
            Controls.Add(editX1);
            Controls.Add(editDesc);
            Controls.Add(editNumber);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(Edit);
            Controls.Add(indexToEdit);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(load);
            Controls.Add(save);
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
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button save;
        private Button load;
        private DataGridView dataGridView1;
        private Label label7;
        private TextBox indexToEdit;
        private Button Edit;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label15;
        private TextBox editY2;
        private TextBox editX2;
        private TextBox editY1;
        private TextBox editX1;
        private TextBox editDesc;
        private TextBox editNumber;
        private Label label16;
        private Label label17;
        private TextBox keyBox;
        private Label label19;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn KeyCol;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn LowerX;
        private DataGridViewTextBoxColumn LowerY;
        private DataGridViewTextBoxColumn UpperX;
        private DataGridViewTextBoxColumn UpperY;
        private DataGridViewTextBoxColumn SpanFrom;
        private DataGridViewTextBoxColumn SpanTo;
        private Label label18;
        private TextBox indexToDelete;
        private Button delete;
    }
}