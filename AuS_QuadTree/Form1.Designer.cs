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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            parcelsX1 = new TextBox();
            parcelsY1 = new TextBox();
            parcelsX2 = new TextBox();
            parcelsY2 = new TextBox();
            parcelsHeight = new TextBox();
            parcelsItems = new TextBox();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            label37 = new Label();
            label36 = new Label();
            label35 = new Label();
            eMaxLength = new TextBox();
            eMaxWidth = new TextBox();
            pMaxLength = new TextBox();
            pMaxWidth = new TextBox();
            label34 = new Label();
            Populate = new Button();
            label33 = new Label();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            estatesX1 = new TextBox();
            estatesItems = new TextBox();
            estatesY1 = new TextBox();
            estatesHeight = new TextBox();
            estatesX2 = new TextBox();
            estatesY2 = new TextBox();
            tabPage3 = new TabPage();
            tabPage1 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            optimizeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // X1
            // 
            X1.Location = new Point(6, 25);
            X1.Name = "X1";
            X1.Size = new Size(65, 23);
            X1.TabIndex = 1;
            // 
            // Y1
            // 
            Y1.Location = new Point(77, 24);
            Y1.Name = "Y1";
            Y1.Size = new Size(65, 23);
            Y1.TabIndex = 2;
            // 
            // X2
            // 
            X2.Location = new Point(148, 24);
            X2.Name = "X2";
            X2.Size = new Size(65, 23);
            X2.TabIndex = 3;
            // 
            // Y2
            // 
            Y2.Location = new Point(219, 24);
            Y2.Name = "Y2";
            Y2.Size = new Size(65, 23);
            Y2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 5;
            label1.Text = "X1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 7);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 6;
            label2.Text = "Y1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 7);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 7;
            label3.Text = "X2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 7);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 8;
            label4.Text = "Y2";
            // 
            // findParcels
            // 
            findParcels.Location = new Point(290, 24);
            findParcels.Name = "findParcels";
            findParcels.Size = new Size(120, 23);
            findParcels.TabIndex = 9;
            findParcels.Text = "Find parcels";
            findParcels.UseVisualStyleBackColor = true;
            findParcels.Click += findParcels_Click;
            // 
            // findEstates
            // 
            findEstates.Location = new Point(290, 53);
            findEstates.Name = "findEstates";
            findEstates.Size = new Size(120, 23);
            findEstates.TabIndex = 10;
            findEstates.Text = "Find estates";
            findEstates.UseVisualStyleBackColor = true;
            findEstates.Click += findEstates_Click;
            // 
            // findBoth
            // 
            findBoth.Location = new Point(290, 82);
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
            label5.Location = new Point(7, 12);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 12;
            label5.Text = "Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(174, 12);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 13;
            label6.Text = "Description";
            // 
            // number
            // 
            number.Location = new Point(7, 30);
            number.Name = "number";
            number.Size = new Size(72, 23);
            number.TabIndex = 18;
            // 
            // description
            // 
            description.Location = new Point(166, 30);
            description.Name = "description";
            description.Size = new Size(150, 23);
            description.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(241, 57);
            label11.Name = "label11";
            label11.Size = new Size(20, 15);
            label11.TabIndex = 27;
            label11.Text = "Y2";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(163, 57);
            label12.Name = "label12";
            label12.Size = new Size(20, 15);
            label12.TabIndex = 26;
            label12.Text = "X2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(85, 57);
            label13.Name = "label13";
            label13.Size = new Size(20, 15);
            label13.TabIndex = 25;
            label13.Text = "Y1";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 57);
            label14.Name = "label14";
            label14.Size = new Size(20, 15);
            label14.TabIndex = 24;
            label14.Text = "X1";
            // 
            // insertY2
            // 
            insertY2.Location = new Point(241, 75);
            insertY2.Name = "insertY2";
            insertY2.Size = new Size(72, 23);
            insertY2.TabIndex = 23;
            // 
            // insertX2
            // 
            insertX2.Location = new Point(163, 75);
            insertX2.Name = "insertX2";
            insertX2.Size = new Size(72, 23);
            insertX2.TabIndex = 22;
            // 
            // insertY1
            // 
            insertY1.Location = new Point(85, 75);
            insertY1.Name = "insertY1";
            insertY1.Size = new Size(72, 23);
            insertY1.TabIndex = 21;
            // 
            // insertX1
            // 
            insertX1.Location = new Point(7, 75);
            insertX1.Name = "insertX1";
            insertX1.Size = new Size(72, 23);
            insertX1.TabIndex = 20;
            // 
            // insertParcel
            // 
            insertParcel.Location = new Point(322, 28);
            insertParcel.Name = "insertParcel";
            insertParcel.Size = new Size(120, 25);
            insertParcel.TabIndex = 28;
            insertParcel.Text = "Insert parcel";
            insertParcel.UseVisualStyleBackColor = true;
            insertParcel.Click += insertParcel_Click;
            // 
            // insertEstate
            // 
            insertEstate.Location = new Point(322, 59);
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
            save.Click += save_Click;
            // 
            // load
            // 
            load.Location = new Point(12, 40);
            load.Name = "load";
            load.Size = new Size(75, 23);
            load.TabIndex = 31;
            load.Text = "Load";
            load.UseVisualStyleBackColor = true;
            load.Click += load_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { No, Id, KeyCol, dataGridViewTextBoxColumn1, LowerX, LowerY, UpperX, UpperY, SpanFrom, SpanTo });
            dataGridView1.Location = new Point(12, 304);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1130, 510);
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
            label7.Location = new Point(9, 12);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 33;
            label7.Text = "Index";
            // 
            // indexToEdit
            // 
            indexToEdit.Location = new Point(9, 29);
            indexToEdit.Name = "indexToEdit";
            indexToEdit.Size = new Size(36, 23);
            indexToEdit.TabIndex = 34;
            // 
            // Edit
            // 
            Edit.Location = new Point(295, 27);
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
            label8.Location = new Point(189, 54);
            label8.Name = "label8";
            label8.Size = new Size(20, 15);
            label8.TabIndex = 47;
            label8.Text = "Y2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(129, 55);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 46;
            label9.Text = "X2";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(69, 54);
            label10.Name = "label10";
            label10.Size = new Size(20, 15);
            label10.TabIndex = 45;
            label10.Text = "Y1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(9, 55);
            label15.Name = "label15";
            label15.Size = new Size(20, 15);
            label15.TabIndex = 44;
            label15.Text = "X1";
            // 
            // editY2
            // 
            editY2.Location = new Point(189, 72);
            editY2.Name = "editY2";
            editY2.Size = new Size(54, 23);
            editY2.TabIndex = 43;
            // 
            // editX2
            // 
            editX2.Location = new Point(129, 72);
            editX2.Name = "editX2";
            editX2.Size = new Size(54, 23);
            editX2.TabIndex = 42;
            // 
            // editY1
            // 
            editY1.Location = new Point(69, 72);
            editY1.Name = "editY1";
            editY1.Size = new Size(54, 23);
            editY1.TabIndex = 41;
            // 
            // editX1
            // 
            editX1.Location = new Point(9, 72);
            editX1.Name = "editX1";
            editX1.Size = new Size(54, 23);
            editX1.TabIndex = 40;
            // 
            // editDesc
            // 
            editDesc.Location = new Point(129, 30);
            editDesc.Name = "editDesc";
            editDesc.Size = new Size(160, 23);
            editDesc.TabIndex = 39;
            // 
            // editNumber
            // 
            editNumber.Location = new Point(51, 29);
            editNumber.Name = "editNumber";
            editNumber.Size = new Size(72, 23);
            editNumber.TabIndex = 38;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(129, 12);
            label16.Name = "label16";
            label16.Size = new Size(67, 15);
            label16.TabIndex = 37;
            label16.Text = "Description";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(51, 12);
            label17.Name = "label17";
            label17.Size = new Size(51, 15);
            label17.TabIndex = 36;
            label17.Text = "Number";
            // 
            // keyBox
            // 
            keyBox.Location = new Point(85, 30);
            keyBox.Name = "keyBox";
            keyBox.Size = new Size(75, 23);
            keyBox.TabIndex = 50;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(85, 12);
            label19.Name = "label19";
            label19.Size = new Size(26, 15);
            label19.TabIndex = 51;
            label19.Text = "Key";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 9);
            label18.Name = "label18";
            label18.Size = new Size(36, 15);
            label18.TabIndex = 52;
            label18.Text = "Index";
            // 
            // indexToDelete
            // 
            indexToDelete.Location = new Point(6, 28);
            indexToDelete.Name = "indexToDelete";
            indexToDelete.Size = new Size(72, 23);
            indexToDelete.TabIndex = 53;
            // 
            // delete
            // 
            delete.Location = new Point(84, 28);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 54;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // parcelsX1
            // 
            parcelsX1.Location = new Point(3, 58);
            parcelsX1.Name = "parcelsX1";
            parcelsX1.Size = new Size(62, 23);
            parcelsX1.TabIndex = 55;
            // 
            // parcelsY1
            // 
            parcelsY1.Location = new Point(71, 58);
            parcelsY1.Name = "parcelsY1";
            parcelsY1.Size = new Size(62, 23);
            parcelsY1.TabIndex = 56;
            // 
            // parcelsX2
            // 
            parcelsX2.Location = new Point(139, 58);
            parcelsX2.Name = "parcelsX2";
            parcelsX2.Size = new Size(62, 23);
            parcelsX2.TabIndex = 57;
            // 
            // parcelsY2
            // 
            parcelsY2.Location = new Point(207, 58);
            parcelsY2.Name = "parcelsY2";
            parcelsY2.Size = new Size(62, 23);
            parcelsY2.TabIndex = 58;
            // 
            // parcelsHeight
            // 
            parcelsHeight.Location = new Point(275, 58);
            parcelsHeight.Name = "parcelsHeight";
            parcelsHeight.Size = new Size(62, 23);
            parcelsHeight.TabIndex = 59;
            // 
            // parcelsItems
            // 
            parcelsItems.Location = new Point(343, 58);
            parcelsItems.Name = "parcelsItems";
            parcelsItems.Size = new Size(72, 23);
            parcelsItems.TabIndex = 60;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(185, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(692, 199);
            tabControl1.TabIndex = 61;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label37);
            tabPage2.Controls.Add(label36);
            tabPage2.Controls.Add(label35);
            tabPage2.Controls.Add(eMaxLength);
            tabPage2.Controls.Add(eMaxWidth);
            tabPage2.Controls.Add(pMaxLength);
            tabPage2.Controls.Add(pMaxWidth);
            tabPage2.Controls.Add(label34);
            tabPage2.Controls.Add(Populate);
            tabPage2.Controls.Add(label33);
            tabPage2.Controls.Add(label32);
            tabPage2.Controls.Add(label31);
            tabPage2.Controls.Add(label30);
            tabPage2.Controls.Add(label29);
            tabPage2.Controls.Add(label28);
            tabPage2.Controls.Add(label27);
            tabPage2.Controls.Add(label26);
            tabPage2.Controls.Add(label25);
            tabPage2.Controls.Add(label24);
            tabPage2.Controls.Add(label23);
            tabPage2.Controls.Add(label22);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(estatesX1);
            tabPage2.Controls.Add(estatesItems);
            tabPage2.Controls.Add(estatesY1);
            tabPage2.Controls.Add(estatesHeight);
            tabPage2.Controls.Add(estatesX2);
            tabPage2.Controls.Add(estatesY2);
            tabPage2.Controls.Add(parcelsX1);
            tabPage2.Controls.Add(parcelsItems);
            tabPage2.Controls.Add(parcelsY1);
            tabPage2.Controls.Add(parcelsHeight);
            tabPage2.Controls.Add(parcelsX2);
            tabPage2.Controls.Add(parcelsY2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(684, 171);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Populate tree";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(499, 103);
            label37.Name = "label37";
            label37.Size = new Size(67, 15);
            label37.TabIndex = 88;
            label37.Text = "Max length";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(421, 103);
            label36.Name = "label36";
            label36.Size = new Size(63, 15);
            label36.TabIndex = 87;
            label36.Text = "Max width";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(499, 40);
            label35.Name = "label35";
            label35.Size = new Size(67, 15);
            label35.TabIndex = 86;
            label35.Text = "Max length";
            // 
            // eMaxLength
            // 
            eMaxLength.Location = new Point(499, 121);
            eMaxLength.Name = "eMaxLength";
            eMaxLength.Size = new Size(72, 23);
            eMaxLength.TabIndex = 85;
            // 
            // eMaxWidth
            // 
            eMaxWidth.Location = new Point(421, 121);
            eMaxWidth.Name = "eMaxWidth";
            eMaxWidth.Size = new Size(72, 23);
            eMaxWidth.TabIndex = 84;
            // 
            // pMaxLength
            // 
            pMaxLength.Location = new Point(499, 58);
            pMaxLength.Name = "pMaxLength";
            pMaxLength.Size = new Size(72, 23);
            pMaxLength.TabIndex = 83;
            // 
            // pMaxWidth
            // 
            pMaxWidth.Location = new Point(421, 58);
            pMaxWidth.Name = "pMaxWidth";
            pMaxWidth.Size = new Size(72, 23);
            pMaxWidth.TabIndex = 82;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(421, 40);
            label34.Name = "label34";
            label34.Size = new Size(63, 15);
            label34.TabIndex = 81;
            label34.Text = "Max width";
            // 
            // Populate
            // 
            Populate.Location = new Point(592, 121);
            Populate.Name = "Populate";
            Populate.Size = new Size(75, 23);
            Populate.TabIndex = 80;
            Populate.Text = "Populate";
            Populate.UseVisualStyleBackColor = true;
            Populate.Click += Populate_Click;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(343, 103);
            label33.Name = "label33";
            label33.Size = new Size(72, 15);
            label33.TabIndex = 79;
            label33.Text = "No. of items";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(343, 40);
            label32.Name = "label32";
            label32.Size = new Size(72, 15);
            label32.TabIndex = 78;
            label32.Text = "No. of items";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(275, 103);
            label31.Name = "label31";
            label31.Size = new Size(43, 15);
            label31.TabIndex = 77;
            label31.Text = "Height";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(275, 40);
            label30.Name = "label30";
            label30.Size = new Size(43, 15);
            label30.TabIndex = 76;
            label30.Text = "Height";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(207, 40);
            label29.Name = "label29";
            label29.Size = new Size(20, 15);
            label29.TabIndex = 75;
            label29.Text = "Y2";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(207, 103);
            label28.Name = "label28";
            label28.Size = new Size(20, 15);
            label28.TabIndex = 74;
            label28.Text = "Y2";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(139, 103);
            label27.Name = "label27";
            label27.Size = new Size(20, 15);
            label27.TabIndex = 73;
            label27.Text = "X2";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(139, 40);
            label26.Name = "label26";
            label26.Size = new Size(20, 15);
            label26.TabIndex = 72;
            label26.Text = "X2";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(71, 103);
            label25.Name = "label25";
            label25.Size = new Size(20, 15);
            label25.TabIndex = 71;
            label25.Text = "Y1";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(71, 40);
            label24.Name = "label24";
            label24.Size = new Size(20, 15);
            label24.TabIndex = 70;
            label24.Text = "Y1";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(6, 103);
            label23.Name = "label23";
            label23.Size = new Size(20, 15);
            label23.TabIndex = 69;
            label23.Text = "X1";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(3, 40);
            label22.Name = "label22";
            label22.Size = new Size(20, 15);
            label22.TabIndex = 62;
            label22.Text = "X1";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(3, 88);
            label21.Name = "label21";
            label21.Size = new Size(43, 15);
            label21.TabIndex = 68;
            label21.Text = "Estates";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(3, 25);
            label20.Name = "label20";
            label20.Size = new Size(44, 15);
            label20.TabIndex = 67;
            label20.Text = "Parcels";
            // 
            // estatesX1
            // 
            estatesX1.Location = new Point(3, 121);
            estatesX1.Name = "estatesX1";
            estatesX1.Size = new Size(62, 23);
            estatesX1.TabIndex = 61;
            // 
            // estatesItems
            // 
            estatesItems.Location = new Point(343, 121);
            estatesItems.Name = "estatesItems";
            estatesItems.Size = new Size(72, 23);
            estatesItems.TabIndex = 66;
            // 
            // estatesY1
            // 
            estatesY1.Location = new Point(71, 121);
            estatesY1.Name = "estatesY1";
            estatesY1.Size = new Size(62, 23);
            estatesY1.TabIndex = 62;
            // 
            // estatesHeight
            // 
            estatesHeight.Location = new Point(275, 121);
            estatesHeight.Name = "estatesHeight";
            estatesHeight.Size = new Size(62, 23);
            estatesHeight.TabIndex = 65;
            // 
            // estatesX2
            // 
            estatesX2.Location = new Point(139, 121);
            estatesX2.Name = "estatesX2";
            estatesX2.Size = new Size(62, 23);
            estatesX2.TabIndex = 63;
            // 
            // estatesY2
            // 
            estatesY2.Location = new Point(207, 121);
            estatesY2.Name = "estatesY2";
            estatesY2.Size = new Size(62, 23);
            estatesY2.TabIndex = 64;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(findBoth);
            tabPage3.Controls.Add(X1);
            tabPage3.Controls.Add(Y1);
            tabPage3.Controls.Add(X2);
            tabPage3.Controls.Add(Y2);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(findParcels);
            tabPage3.Controls.Add(findEstates);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(684, 171);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Find data";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(insertEstate);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(number);
            tabPage1.Controls.Add(description);
            tabPage1.Controls.Add(insertX1);
            tabPage1.Controls.Add(insertY1);
            tabPage1.Controls.Add(insertX2);
            tabPage1.Controls.Add(insertY2);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(keyBox);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(insertParcel);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(684, 171);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Insert data";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(Edit);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(indexToEdit);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(editNumber);
            tabPage4.Controls.Add(editDesc);
            tabPage4.Controls.Add(editX1);
            tabPage4.Controls.Add(editY1);
            tabPage4.Controls.Add(editX2);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(editY2);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(label10);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(684, 171);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Edit data";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(delete);
            tabPage5.Controls.Add(label18);
            tabPage5.Controls.Add(indexToDelete);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(684, 171);
            tabPage5.TabIndex = 5;
            tabPage5.Text = "Delete data";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(optimizeBtn);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(684, 171);
            tabPage6.TabIndex = 6;
            tabPage6.Text = "Optimize";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // optimizeBtn
            // 
            optimizeBtn.Location = new Point(6, 6);
            optimizeBtn.Name = "optimizeBtn";
            optimizeBtn.Size = new Size(105, 31);
            optimizeBtn.TabIndex = 0;
            optimizeBtn.Text = "Optimize trees";
            optimizeBtn.UseVisualStyleBackColor = true;
            optimizeBtn.Click += optimizeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 826);
            Controls.Add(tabControl1);
            Controls.Add(dataGridView1);
            Controls.Add(load);
            Controls.Add(save);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox parcelsX1;
        private TextBox parcelsY1;
        private TextBox parcelsX2;
        private TextBox parcelsY2;
        private TextBox parcelsHeight;
        private TextBox parcelsItems;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button Populate;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private TextBox estatesX1;
        private TextBox estatesItems;
        private TextBox estatesY1;
        private TextBox estatesHeight;
        private TextBox estatesX2;
        private TextBox estatesY2;
        private TabPage tabPage1;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Button optimizeBtn;
        private Label label37;
        private Label label36;
        private Label label35;
        private TextBox eMaxLength;
        private TextBox eMaxWidth;
        private TextBox pMaxLength;
        private TextBox pMaxWidth;
        private Label label34;
    }
}