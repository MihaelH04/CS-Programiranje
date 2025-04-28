using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vubcaffe;

namespace VubCaffe;
public partial class FormMain : Form
{
    private Bill bill;

    public FormMain()
    {
        InitializeComponent();
        bill = new Bill();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Jeste li sigurni da želite izaći iz programa?", "Izlaz iz programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        {
            Close();
        }
    }

    private void RefreshBill()
    {
        RefreshItems();
        RefreshTotal();
    }

    private void RefreshItems()
    {
        lbItems.Items.Clear();
        foreach (var product in bill.Products)
        {
            lbItems.Items.Add(product);
        }
    }

    private void RefreshTotal()
    {
        lblTotalPrice.Text = string.Format("{0:0.00}€", bill.Total());
    }

    private void btnCocaCola_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new CocaCola()); 
        RefreshBill();
    }
    private void btnFanta_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new Fanta());
        RefreshBill();
    }

    private void btnEspresso_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new Espresso());
        RefreshBill();
    }

    private void btnLatte_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new Latte());
        RefreshBill();
    }

    private void btnSprite_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new Sprite());
        RefreshBill();
    }

    private void btnVoucher100Eur_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new Voucher100Eur());
        RefreshBill();
    }

    private void btnNewBill_Click(object sender, EventArgs e)
    {
        bill = new Bill();
        RefreshBill();
    }

    private void btnBill_Click(object sender, EventArgs e)
    {
        double totalAmount = bill.Total();

        DialogResult result = MessageBox.Show(
            $"Ukupno za plaćanje je: {totalAmount:0.00} €",
            "Naplata",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information
        );

   
        if (result == DialogResult.OK)
        {
            
            bill = new Bill(); 
            RefreshBill(); 
        }
    }


    private void btnSladoled_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new Sladoled());
        RefreshBill();
    }   
   
   private void btnKolac_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new Kolac());
        RefreshBill();
    }

  private void btnCappucino_Click(object sender, EventArgs e)
    {
        bill.AddProduct(new Cappucino());
        RefreshBill();  
    }
   
}

