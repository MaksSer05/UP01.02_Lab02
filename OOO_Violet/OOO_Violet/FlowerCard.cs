using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOO_Violet.Classes;

namespace OOO_Violet
{
    public partial class FlowerCard : UserControl
    {
		public Product _product;
		public FlowerCard(Product flower)
        {
			this._product = flower;
            InitializeComponent();
            this.Dock = DockStyle.Top;
            this.BorderStyle = BorderStyle.FixedSingle;
            if (flower.ProductPhoto == "")
			{
				pbFlower.Image = Image.FromFile(@"C:\Users\young\Downloads\Flower Shop\OOO_Violet\OOO_Violet\bin\Debug\Picture\Picturenoproduct.png");
			}
			else
			{			
				pbFlower.Image = Image.FromFile($@"C:\Users\young\Downloads\Flower Shop\OOO_Violet\OOO_Violet\bin\Debug\Picture\{flower.ProductPhoto}");
			}

			gbname.Text = flower.ProductName;
			if (flower.ProductDescription.Length > 51)
			{
				rtbOpisanie.Text = flower.ProductDescription.Substring(0, 50) + "...";
			}
			else
			{
				rtbOpisanie.Text = flower.ProductDescription;
			}
			pbFlower.Tag = _product.ProductArticleNumber;
			tbquantity.Text = flower.ProductQuantityInStock.ToString();
			tbprovide.Text = flower.Manufacturer.ManufacturerName;
			tbcost.Text = flower.ProductCost.ToString();
			tbcategory.Text = flower.Category.CategoryName.ToString();
		}

        private void FlowerCard_Load(object sender, EventArgs e)
        {

        }

        private void bbuy_Click(object sender, EventArgs e)
        {

        }
    }
}
