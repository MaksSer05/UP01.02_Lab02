using OOO_Violet.Classes;
using OOO_Violet.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Violet
{
    public partial class Katalog : Form
    {
        
        private OOO_VioletEntities3 local;        
        public Katalog()
        {
            InitializeComponent();
            local = new OOO_VioletEntities3();
        }

        private void Katalog_Load(object sender, EventArgs e)
        {
            FlowerPanel.AutoScroll = true;           

            Category allCategory = new Category();
            allCategory.CategoryID = 0;
            allCategory.CategoryName = "Все категории";

            List<Category> category = local.Category.ToList();

            category.Insert(0, allCategory);
            cbCategories.DataSource = category;
            cbCategories.DisplayMember = "CategoryName";
            cbCategories.ValueMember = "CategoryID";
            cbCategories.SelectedIndex = 0;

            Manufacturer m = new Manufacturer();
            m.ManufacturerID = 0;
            m.ManufacturerName = "Все производители";

            List<Manufacturer> manufs = local.Manufacturer.ToList();
            manufs.Insert(0, m);

            cbManufacturers.DataSource = manufs;
            cbManufacturers.DisplayMember = "ManufacturerName";
            cbManufacturers.ValueMember = "ManufacturerID";
            cbManufacturers.SelectedIndex = 0;


            cbManufacturers.SelectedIndexChanged += CallInvalidation;
            cbCategories.SelectedIndexChanged += CallInvalidation;
            tbProductName.TextChanged += CallInvalidation;

            InvalidateProducts();
        }
        private void CallInvalidation(object sender, EventArgs e)
        {
            InvalidateProducts();
        }
        private void InvalidateProducts()
        {

            List<Product> products = new List<Product>();          

            string productName = tbProductName.Text;

            //Фильтрация по категории
            int categoryId = (int)cbCategories.SelectedValue;
            if (categoryId == 0)
            {
                products = local.Product.ToList();
            }
            else
            {
                products = local.Product.Where(p => p.ProductCategoryID == categoryId).ToList();
            }

            //Фильтрация по производителю
            int manufId = (int)cbManufacturers.SelectedValue;
            if (manufId != 0)
            {
                products = products.Where(p => p.ProductManufacturerID == manufId).ToList();
            }

            //Фильтрация по имени
            if (productName.Trim() != "")
            {
                products = products.Where(p => p.ProductName.Contains(productName)).ToList();
            }
            FlowerPanel.Controls.Clear();
            foreach (Product flower in products)
            {
                FlowerCard edit = new FlowerCard(flower);
                edit.pbFlower.DoubleClick += Edit_DoubleClick;
                FlowerPanel.Controls.Add(edit);
                edit.pbFlower.DoubleClick += Edit_DoubleClick;
            }
        }
        private void Edit_DoubleClick(object sender, EventArgs e)
        {
            string productId = (string)(sender as PictureBox).Tag;
            if (Helper.UserRole == "Администратор")
            {
                FlowerEditForm FEF = new FlowerEditForm(productId);
                this.Hide();
                FEF.ShowDialog();
                this.Close();
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            FAutores form = new FAutores();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }    
}