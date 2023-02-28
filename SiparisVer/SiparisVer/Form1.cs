namespace SiparisVer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindDataContext db = new NorthwindDataContext();
            dgvUrunler.DataSource = db.Products;
            cmbMusteri.DataSource = db.Customers;
            cmbMusteri.DisplayMember= "CompanyName";
            cmbMusteri.ValueMember = "CustomerID";
            cmbNakliye.DataSource = db.Shippers; 
            cmbNakliye.DisplayMember = "CompanyName";
            cmbNakliye.ValueMember = "ShipperID";
            /*cmbPersonel.DataSource = from per in db.Employees
                                     select new
                                     {
                                         per.EmployeeID,
                                         AdSoyad = per.FirstName + " " + per.LastName
                                     };*/
            //lambda hali
            cmbPersonel.DataSource = db.Employees.Select(per => new
            {
                per.EmployeeID,
                AdSoyad = per.FirstName + " " + per.LastName
            });
            cmbPersonel.DisplayMember = "AdSoyad";
            cmbPersonel.ValueMember = "EmployeeID";

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow != null) return;
            DataGridViewRow row = dgvUrunler.CurrentRow;

            ListViewItem li = new ListViewItem();
            li.Text = row.Cells["ProductName"].Value.ToString();
            li.SubItems.Add(row.Cells["UnitPrice"].Value.ToString());
            li.SubItems.Add(numAdet.Value.ToString());
            li.SubItems.Add(numIndirim.Value.ToString());
            li.Tag = row.Cells["ProductID"].Value;
            lsvUrunler.Items.Add(li);

            numIndirim.Value = 0;
            numAdet.Value = 1;
        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedItem != null || cmbNakliye.SelectedItem == null || cmbPersonel.SelectedItem == null)
            {
                MessageBox.Show("Eksik birþey mi var hayatýnda, gözlerin neden bakýyor uzaklara");
                return;
            }
            NorthwindDataContext db = new NorthwindDataContext();
            Order yenisatis = new Order();
            yenisatis.OrderDate = DateTime.Now;
            yenisatis.CustomerID=cmbMusteri.SelectedValue.ToString();
            yenisatis.EmployeeID = (int)cmbPersonel.SelectedValue;
            yenisatis.ShipVia = (int)cmbNakliye.SelectedValue;

            db.Orders.InsertOnSubmit(yenisatis);
            db.SubmitChanges();

            foreach (ListViewItem item in lsvUrunler.Items)
            {
                Order_Detail sd = new Order_Detail();
                sd.OrderID=yenisatis.OrderID;
                sd.ProductID=(int)item.Tag;
                sd.UnitPrice = decimal.Parse(item.SubItems[1].Text);
                sd.Quantity = short.Parse(item.SubItems[2].Text);
                sd.Discount = float.Parse(item.SubItems[3].Text) / 100;
                db.Order_Details.InsertOnSubmit(sd);
                db.SubmitChanges();
            }
            lsvUrunler.Items.Clear();
            cmbMusteri.SelectedIndex = cmbNakliye.SelectedIndex = -1;
        }
    }
}