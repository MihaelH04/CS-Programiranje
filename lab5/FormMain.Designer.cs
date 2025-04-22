namespace VubCaffe {
  partial class FormMain {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      pnlContainer = new Panel();
      lblTotalPrice = new Label();
      lblTotalMessage = new Label();
      btnExit = new Button();
      btnBill = new Button();
      btnNewBill = new Button();
      lbItems = new ListBox();
      gbVouchers = new GroupBox();
      btnVoucher100Eur = new Button();
      gbSweets = new GroupBox();
      btnCake = new Button();
      btnIceCream = new Button();
      gbBeverages = new GroupBox();
      btnFanta = new Button();
      btnSprite = new Button();
      btnCocaCola = new Button();
      gbCoffe = new GroupBox();
      btnLatte = new Button();
      btnCappucino = new Button();
      btnEspresso = new Button();
      lblLogo = new Label();
      pnlContainer.SuspendLayout();
      gbVouchers.SuspendLayout();
      gbSweets.SuspendLayout();
      gbBeverages.SuspendLayout();
      gbCoffe.SuspendLayout();
      SuspendLayout();
      // 
      // pnlContainer
      // 
      pnlContainer.BackColor = Color.Transparent;
      pnlContainer.BorderStyle = BorderStyle.FixedSingle;
      pnlContainer.Controls.Add(lblTotalPrice);
      pnlContainer.Controls.Add(lblTotalMessage);
      pnlContainer.Controls.Add(btnExit);
      pnlContainer.Controls.Add(btnBill);
      pnlContainer.Controls.Add(btnNewBill);
      pnlContainer.Controls.Add(lbItems);
      pnlContainer.Controls.Add(gbVouchers);
      pnlContainer.Controls.Add(gbSweets);
      pnlContainer.Controls.Add(gbBeverages);
      pnlContainer.Controls.Add(gbCoffe);
      pnlContainer.Controls.Add(lblLogo);
      pnlContainer.Location = new Point(0, 0);
      pnlContainer.Name = "pnlContainer";
      pnlContainer.Size = new Size(1024, 576);
      pnlContainer.TabIndex = 0;
      // 
      // lblTotalPrice
      // 
      lblTotalPrice.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
      lblTotalPrice.Location = new Point(705, 441);
      lblTotalPrice.Name = "lblTotalPrice";
      lblTotalPrice.Size = new Size(286, 30);
      lblTotalPrice.TabIndex = 10;
      lblTotalPrice.Text = "0,00 EUR";
      lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
      // 
      // lblTotalMessage
      // 
      lblTotalMessage.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
      lblTotalMessage.Location = new Point(593, 441);
      lblTotalMessage.Name = "lblTotalMessage";
      lblTotalMessage.Size = new Size(106, 30);
      lblTotalMessage.TabIndex = 9;
      lblTotalMessage.Text = "Ukupno:";
      // 
      // btnExit
      // 
      btnExit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
      btnExit.Location = new Point(477, 19);
      btnExit.Name = "btnExit";
      btnExit.Size = new Size(78, 59);
      btnExit.TabIndex = 8;
      btnExit.Text = "Izlaz";
      btnExit.UseVisualStyleBackColor = true;
      btnExit.Click += btnExit_Click;
      // 
      // btnBill
      // 
      btnBill.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
      btnBill.Location = new Point(804, 489);
      btnBill.Name = "btnBill";
      btnBill.Size = new Size(187, 59);
      btnBill.TabIndex = 7;
      btnBill.Text = "Naplata";
      btnBill.UseVisualStyleBackColor = true;
      btnBill.Click += btnBill_Click;
      // 
      // btnNewBill
      // 
      btnNewBill.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
      btnNewBill.Location = new Point(591, 489);
      btnNewBill.Name = "btnNewBill";
      btnNewBill.Size = new Size(187, 59);
      btnNewBill.TabIndex = 6;
      btnNewBill.Text = "Novi račun";
      btnNewBill.UseVisualStyleBackColor = true;
      btnNewBill.Click += btnNewBill_Click;
      // 
      // lbItems
      // 
      lbItems.FormattingEnabled = true;
      lbItems.ItemHeight = 15;
      lbItems.Location = new Point(591, 19);
      lbItems.Name = "lbItems";
      lbItems.Size = new Size(400, 409);
      lbItems.TabIndex = 5;
      // 
      // gbVouchers
      // 
      gbVouchers.Controls.Add(btnVoucher100Eur);
      gbVouchers.Location = new Point(34, 449);
      gbVouchers.Name = "gbVouchers";
      gbVouchers.Size = new Size(521, 99);
      gbVouchers.TabIndex = 4;
      gbVouchers.TabStop = false;
      gbVouchers.Text = " Poklon bonovi ";
      // 
      // btnVoucher100Eur
      // 
      btnVoucher100Eur.Location = new Point(17, 26);
      btnVoucher100Eur.Name = "btnVoucher100Eur";
      btnVoucher100Eur.Size = new Size(76, 57);
      btnVoucher100Eur.TabIndex = 3;
      btnVoucher100Eur.Text = "100€";
      btnVoucher100Eur.UseVisualStyleBackColor = true;
      btnVoucher100Eur.Click += btnVoucher100Eur_Click;
      // 
      // gbSweets
      // 
      gbSweets.Controls.Add(btnCake);
      gbSweets.Controls.Add(btnIceCream);
      gbSweets.Location = new Point(34, 327);
      gbSweets.Name = "gbSweets";
      gbSweets.Size = new Size(521, 99);
      gbSweets.TabIndex = 3;
      gbSweets.TabStop = false;
      gbSweets.Text = " Deserti ";
      // 
      // btnCake
      // 
      btnCake.Location = new Point(109, 26);
      btnCake.Name = "btnCake";
      btnCake.Size = new Size(76, 57);
      btnCake.TabIndex = 3;
      btnCake.Text = "Kolač";
      btnCake.UseVisualStyleBackColor = true;
      // 
      // btnIceCream
      // 
      btnIceCream.Location = new Point(17, 26);
      btnIceCream.Name = "btnIceCream";
      btnIceCream.Size = new Size(76, 57);
      btnIceCream.TabIndex = 2;
      btnIceCream.Text = "Sladoled";
      btnIceCream.UseVisualStyleBackColor = true;
      // 
      // gbBeverages
      // 
      gbBeverages.Controls.Add(btnFanta);
      gbBeverages.Controls.Add(btnSprite);
      gbBeverages.Controls.Add(btnCocaCola);
      gbBeverages.Location = new Point(34, 207);
      gbBeverages.Name = "gbBeverages";
      gbBeverages.Size = new Size(521, 99);
      gbBeverages.TabIndex = 2;
      gbBeverages.TabStop = false;
      gbBeverages.Text = " Bezalkoholna pića ";
      // 
      // btnFanta
      // 
      btnFanta.Location = new Point(200, 26);
      btnFanta.Name = "btnFanta";
      btnFanta.Size = new Size(76, 57);
      btnFanta.TabIndex = 3;
      btnFanta.Text = "Fanta";
      btnFanta.UseVisualStyleBackColor = true;
      // 
      // btnSprite
      // 
      btnSprite.Location = new Point(109, 26);
      btnSprite.Name = "btnSprite";
      btnSprite.Size = new Size(76, 57);
      btnSprite.TabIndex = 2;
      btnSprite.Text = "Sprite";
      btnSprite.UseVisualStyleBackColor = true;
      btnSprite.Click += btnSprite_Click;
      // 
      // btnCocaCola
      // 
      btnCocaCola.Location = new Point(17, 26);
      btnCocaCola.Name = "btnCocaCola";
      btnCocaCola.Size = new Size(76, 57);
      btnCocaCola.TabIndex = 1;
      btnCocaCola.Text = "Coca Cola";
      btnCocaCola.UseVisualStyleBackColor = true;
      btnCocaCola.Click += btnCocaCola_Click;
      // 
      // gbCoffe
      // 
      gbCoffe.Controls.Add(btnLatte);
      gbCoffe.Controls.Add(btnCappucino);
      gbCoffe.Controls.Add(btnEspresso);
      gbCoffe.Location = new Point(34, 85);
      gbCoffe.Name = "gbCoffe";
      gbCoffe.Size = new Size(521, 99);
      gbCoffe.TabIndex = 1;
      gbCoffe.TabStop = false;
      gbCoffe.Text = " Kave ";
      // 
      // btnLatte
      // 
      btnLatte.Location = new Point(200, 25);
      btnLatte.Name = "btnLatte";
      btnLatte.Size = new Size(76, 57);
      btnLatte.TabIndex = 2;
      btnLatte.Text = "Latte";
      btnLatte.UseVisualStyleBackColor = true;
      btnLatte.Click += btnLatte_Click;
      // 
      // btnCappucino
      // 
      btnCappucino.Location = new Point(109, 25);
      btnCappucino.Name = "btnCappucino";
      btnCappucino.Size = new Size(76, 57);
      btnCappucino.TabIndex = 1;
      btnCappucino.Text = "Cappucino";
      btnCappucino.UseVisualStyleBackColor = true;
      // 
      // btnEspresso
      // 
      btnEspresso.Location = new Point(17, 25);
      btnEspresso.Name = "btnEspresso";
      btnEspresso.Size = new Size(76, 57);
      btnEspresso.TabIndex = 0;
      btnEspresso.Text = "Espresso";
      btnEspresso.UseVisualStyleBackColor = true;
      btnEspresso.Click += btnEspresso_Click;
      // 
      // lblLogo
      // 
      lblLogo.AutoSize = true;
      lblLogo.Font = new Font("Segoe Script", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
      lblLogo.Location = new Point(34, 19);
      lblLogo.Name = "lblLogo";
      lblLogo.Size = new Size(175, 48);
      lblLogo.TabIndex = 0;
      lblLogo.Text = "VUB Caffe";
      // 
      // FormMain
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackgroundImage = Properties.Resources.gradient;
      ClientSize = new Size(1024, 576);
      Controls.Add(pnlContainer);
      FormBorderStyle = FormBorderStyle.None;
      Name = "FormMain";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "VubCaffe";
      pnlContainer.ResumeLayout(false);
      pnlContainer.PerformLayout();
      gbVouchers.ResumeLayout(false);
      gbSweets.ResumeLayout(false);
      gbBeverages.ResumeLayout(false);
      gbCoffe.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private Panel pnlContainer;
    private GroupBox gbCoffe;
    private Label lblLogo;
    private GroupBox gbSweets;
    private GroupBox gbBeverages;
    private GroupBox gbVouchers;
    private Button btnBill;
    private Button btnNewBill;
    private ListBox lbItems;
    private Button btnCappucino;
    private Button btnEspresso;
    private Button btnSprite;
    private Button btnCocaCola;
    private Button btnLatte;
    private Button btnIceCream;
    private Button btnFanta;
    private Button btnCake;
    private Button btnVoucher100Eur;
    private Button btnExit;
    private Label lblTotalMessage;
    private Label lblTotalPrice;
  }
}
