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
        if (MessageBox.Show("Jeste li sigurni da želite izaæi iz programa?", "Izlaz iz programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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
    }

    private void btnNewBill_Click(object sender, EventArgs e)
    {
    }

    private void btnBill_Click(object sender, EventArgs e)
    {
    }
}

