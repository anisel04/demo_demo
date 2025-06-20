using Microsoft.EntityFrameworkCore;

namespace demo_demo {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            using (var db = new Context()) {
                db.Database.EnsureCreated();
            }

            RefreshPartners();
        }

        public void RefreshPartners() {
            using (var db = new Context()) {
                var partners = db.Partners.Include(p => p.PartnerType).Include(p => p.PartnerProducts).ToList();
                dataGridViewPartners.Rows.Clear();
                foreach (var p in partners) {
                    dataGridViewPartners.Rows.Add(p.Id, $"{p.PartnerType.Type} | {p.Name}\n{p.Director}\n{p.Phone}\nРейтинг: {p.Rating}", $"{p.Discount}%");
                }
            }
        }

        public void RefreshHistory() {  
            using (var db = new Context()) {
                if (db.Partners.ToList().Count > 0) {
                    Partner? selected = (Partner?)comboBoxHistory.SelectedItem;
                    int selectedId = db.Partners.ToList()[0].Id;
                    if (selected != null) {
                        selectedId = selected.Id;
                    }
                    var history = db.PartnerProducts.Include(p => p.Partner).Include(p => p.Product).ToList();
                    dataGridViewHistory.Rows.Clear();
                    foreach (var p in history) {
                        if (p.Partner.Id == selectedId) {
                            dataGridViewHistory.Rows.Add(p.Id, p.Partner.Name, p.Product.Name, p.Quantity, p.SaleDate.ToString("dd.MM.yyyy"));
                        }
                    }
                }
            }
        }

        public void UpdatePartnerLoad() {
            if (comboBoxUpdatePartner.SelectedItem != null) {
                Partner selected = (Partner)comboBoxUpdatePartner.SelectedItem;
                if (selected != null) {
                    int selectedId = selected.Id;
                    using (var db = new Context()) {
                        selected = db.Partners.Include(p => p.PartnerType).ToList().FirstOrDefault(p => p.Id == selectedId);
                        textBoxUpdatePartnerName.Text = selected.Name;
                        textBoxUpdatePartnerType.Text = selected.PartnerType.Type;
                        textBoxUpdatePartnerDirector.Text = selected.Director;
                        textBoxUpdatePartnerEmail.Text = selected.Email;
                        textBoxUpdatePartnerAddress.Text = selected.Address;
                        textBoxUpdatePartnerINN.Text = selected.INN;
                        textBoxUpdatePartnerPhone.Text = selected.Phone;
                        textBoxUpdatePartnerRating.Text = selected.Rating.ToString();
                    }
                }
            }
        }

        private void buttonRefreshPartners_Click(object sender, EventArgs e) {
            RefreshPartners();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControlMain.SelectedIndex == 0) {
                RefreshPartners();
            }
            else if (tabControlMain.SelectedIndex == 1) {
                using (var db = new Context()) {
                    if (db.Partners.ToList().Count > 0) {
                        Partner? selected = (Partner?)comboBoxHistory.SelectedItem;
                        int selectedId = db.Partners.ToList()[0].Id;
                        if (selected != null) {
                            selectedId = selected.Id;
                        }
                        comboBoxHistory.DataSource = db.Partners.ToList();
                        comboBoxHistory.DisplayMember = "Name";
                        comboBoxHistory.ValueMember = "Id";
                        comboBoxHistory.SelectedValue = selectedId;
                        RefreshHistory();
                    }
                }
            }
            else if (tabControlMain.SelectedIndex == 3) {
                using (var db = new Context()) {
                    if (db.Partners.ToList().Count > 0) {
                        Partner? selected = (Partner?)comboBoxUpdatePartner.SelectedItem;
                        int selectedId = db.Partners.ToList()[0].Id;
                        if (selected != null) {
                            selectedId = selected.Id;
                        }
                        comboBoxUpdatePartner.DataSource = db.Partners.Include(p => p.PartnerType).ToList();
                        comboBoxUpdatePartner.DisplayMember = "Name";
                        comboBoxUpdatePartner.ValueMember = "Id";
                        comboBoxUpdatePartner.SelectedValue = selectedId;
                        UpdatePartnerLoad();
                    }
                }
            }
        }

        private void buttonAddPartner_Click(object sender, EventArgs e) {
            try {
                using var db = new Context();
                if (db.PartnerTypes.FirstOrDefault(p => p.Type == textBoxAddPartnerType.Text) is null) {
                    var partnerType = new PartnerType {
                        Type = textBoxAddPartnerType.Text
                    };
                    db.PartnerTypes.Add(partnerType);
                    db.SaveChanges();
                }
                var partnerTypeId = db.PartnerTypes.FirstOrDefault(p => p.Type == textBoxAddPartnerType.Text).Id;
                var partner = new Partner {
                    Name = textBoxAddPartnerName.Text,
                    Director = textBoxAddPartnerDirector.Text,
                    Email = textBoxAddPartnerEmail.Text,
                    Address = textBoxAddPartnerAddress.Text,
                    INN = textBoxAddPartnerINN.Text,
                    Phone = textBoxAddPartnerPhone.Text,
                    Rating = int.Parse(textBoxAddPartnerRating.Text),
                    PartnerTypeId = partnerTypeId
                };
                db.Partners.Add(partner);
                db.SaveChanges();
                MessageBox.Show("Партнер успешно добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show($"Произошла ошибка при добавлении партнера.\nВсе поля должны быть заполнены.\nПроверьте корректность введенных данных и попробуйте снова.\nПодробности: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGoToAddPartner_Click(object sender, EventArgs e) {
            tabControlMain.SelectedIndex = 2;
        }

        private void dataGridViewPartners_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int? id = (int?)dataGridViewPartners.SelectedRows[0].Cells["ID"].Value;
            if (id != null) {
                using (var db = new Context()) {
                    comboBoxUpdatePartner.SelectedValue = id;
                    tabControlMain.SelectedIndex = 3;
                }
            }
        }

        private void comboBoxUpdatePartner_SelectedValueChanged(object sender, EventArgs e) {
            UpdatePartnerLoad();
        }

        private void buttonUpdatePartner_Click(object sender, EventArgs e) {
            try {
                using (var db = new Context()) {
                    var selectedId = (int?)comboBoxUpdatePartner.SelectedValue;
                    if (selectedId != null) {
                        if (db.PartnerTypes.FirstOrDefault(p => p.Type == textBoxUpdatePartnerType.Text) is null) {
                            var partnerType = new PartnerType {
                                Type = textBoxUpdatePartnerType.Text
                            };
                            db.PartnerTypes.Add(partnerType);
                            db.SaveChanges();
                        }
                        var partnerTypeId = db.PartnerTypes.FirstOrDefault(p => p.Type == textBoxUpdatePartnerType.Text).Id;
                        var updated = db.Partners.FirstOrDefault(p => p.Id == selectedId);
                        updated.Name = textBoxUpdatePartnerName.Text;
                        updated.Director = textBoxUpdatePartnerDirector.Text;
                        updated.Email = textBoxUpdatePartnerEmail.Text;
                        updated.Address = textBoxUpdatePartnerAddress.Text;
                        updated.INN = textBoxUpdatePartnerINN.Text;
                        updated.Phone = textBoxUpdatePartnerPhone.Text;
                        updated.Rating = int.Parse(textBoxUpdatePartnerRating.Text);
                        updated.PartnerTypeId = partnerTypeId;
                        db.SaveChanges();
                        MessageBox.Show("Партнер успешно обновлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Partner? selected = (Partner?)comboBoxUpdatePartner.SelectedItem;
                        if (selected != null) {
                            selectedId = selected.Id;
                        }
                        comboBoxUpdatePartner.DataSource = db.Partners.Include(p => p.PartnerType).ToList();
                        comboBoxUpdatePartner.DisplayMember = "Name";
                        comboBoxUpdatePartner.ValueMember = "Id";
                        comboBoxUpdatePartner.SelectedValue = selectedId;
                        UpdatePartnerLoad();
                    }
                }

            }
            catch (Exception ex) {
                MessageBox.Show($"Произошла ошибка при обновлении партнера.\nВсе поля должны быть заполнены.\nПроверьте корректность введенных данных и попробуйте снова.\nПодробности: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void comboBoxHistory_SelectedValueChanged(object sender, EventArgs e) {
            RefreshHistory();
        }
    }}


    // ---------------
    // EntityFramework
    // ---------------
    public class Context : DbContext {
        public DbSet<Partner> Partners { get; set; }
        public DbSet<PartnerType> PartnerTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<PartnerProduct> PartnerProducts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseNpgsql("Host=localhost;Port=5432;Database=demo_2;Username=postgres;Password=drimik");
        }
    }

    public class Partner {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string INN { get; set; }
        public string Phone { get; set; }
        public int Rating { get; set; }
        public int PartnerTypeId { get; set; }
        public PartnerType PartnerType { get; set; }

        public virtual List<PartnerProduct> PartnerProducts { get; set; } = new();
        public virtual int Discount {
            get {
                int totalSold = PartnerProducts?.Sum(pp => pp.Quantity) ?? 0;

                if (totalSold < 10000) return 0;
                if (totalSold < 50000) return 5;
                if (totalSold < 300000) return 10;
                return 15;
            }
        }
    }

    public class PartnerType {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<Partner> Partners { get; set; } = new();
    }

    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Article { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public double Price { get; set; }
    }

    public class ProductType {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }
        public List<Product> Products { get; set; } = new();
    }

    public class PartnerProduct {
        public int Id { get; set; }
        public int PartnerId { get; set; }
        public Partner Partner { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateOnly SaleDate { get; set; }
    }