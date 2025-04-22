namespace VubCaffe;
public partial class FormMain : Form {
  public FormMain() {
    InitializeComponent();
  }

  private void btnExit_Click(object sender, EventArgs e) {
    if (MessageBox.Show("Jeste li sigurni da želite izaæi iz programa?", "Izlaz iz programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
      Close();
    }
  }

  private void btnCocaCola_Click(object sender, EventArgs e) {
  }

  private void btnEspresso_Click(object sender, EventArgs e) {
  }

  private void btnLatte_Click(object sender, EventArgs e) {
  }

  private void btnSprite_Click(object sender, EventArgs e) {
  }

  private void btnVoucher100Eur_Click(object sender, EventArgs e) {
  }

  private void btnNewBill_Click(object sender, EventArgs e) {
  }

  private void btnBill_Click(object sender, EventArgs e) {
  }
}

