using OOO_Violet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Violet.Forms
{
	public partial class FlowerEditForm : Form
	{
		private Product _local;
		private OOO_VioletEntities3 local;
		public FlowerEditForm(string productId)
		{
			local = new OOO_VioletEntities3();
			InitializeComponent();
			List<Category> category = local.Category.ToList();
			cbCategories.DataSource = category;
			cbCategories.DisplayMember = "CategoryName";
			cbCategories.ValueMember = "CategoryID";

			List<Manufacturer> manufs = local.Manufacturer.ToList();
			cbManufacturers.DataSource = manufs;
			cbManufacturers.DisplayMember = "ManufacturerName";
			cbManufacturers.ValueMember = "ManufacturerID";

			List<Provide> provider = local.Provide.ToList();
			cbVendors.DataSource = provider;
			cbVendors.DisplayMember = "ProvideName";
			cbVendors.ValueMember = "ProvideID";



			_local = local.Product.Find(productId);
			tbProductName.Text = _local.ProductName;
			cbCategories.SelectedValue = _local.ProductCategoryID;
			numQuantity.Value = _local.ProductQuantityInStock;
			cbVendors.SelectedValue = _local.ProductProvideID;
			cbManufacturers.SelectedValue = _local.ProductManufacturerID;
			numCost.Value = _local.ProductCost;
			rtbDescription.Text = _local.ProductDescription;

			if (_local.ProductPhoto == "")
			{
				pbImage.Image = Image.FromFile(@"C:\Users\young\Downloads\Flower Shop\OOO_Violet\OOO_Violet\bin\Debug\Picture\noproduct.png");
				pbImage.Tag = "";
			}
			else
			{
				pbImage.Image = Image.FromFile($@"C:\Users\young\Downloads\Flower Shop\OOO_Violet\OOO_Violet\bin\Debug\Picture\{_local.ProductPhoto}");
				pbImage.Tag = _local.ProductPhoto;
			}
		}

		private void bBack_Click(object sender, EventArgs e)
		{
			Katalog form = new Katalog();
			this.Hide();
			form.ShowDialog();
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			_local.ProductName = tbProductName.Text;
			_local.ProductCategoryID = (int)cbCategories.SelectedValue;
			_local.ProductQuantityInStock = (int)numQuantity.Value;

			Unit mu = local.Unit.Where(m => m.UnitName == tbUnit.Text).FirstOrDefault();
			if (mu == null)
			{
				Unit newUnit = new Unit();
				int maxId = local.Unit.Max(m => m.UnitID);
				newUnit.UnitID = maxId + 1;
				newUnit.UnitName = tbUnit.Text;
				local.Unit.Add(newUnit);
			}
			else
			{
				_local.ProductUnitID = mu.UnitID;
			}
			_local.ProductProvideID = (int)cbVendors.SelectedValue;
			_local.ProductManufacturerID = (int)cbManufacturers.SelectedValue;
			_local.ProductCost = numCost.Value;
			_local.ProductDescription = rtbDescription.Text;
			_local.ProductPhoto = pbImage.Tag.ToString();

			try
			{
				local.SaveChanges();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при изменении товара проверьте правильность ввода", "Ошибка");
				return;
			}
			MessageBox.Show("Успешно изменение товара");
		}

		private void buttonAddPic_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Files|*.jpg;*.jpeg;*.png;*.webp";
			if (ofd.ShowDialog() == DialogResult.OK)
			{

				string path = ofd.FileName;
				Image img = Image.FromFile(path);
				img.Save(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Picture", Path.GetFileName(path)));
				pbImage.Image = img;
				pbImage.Tag = Path.GetFileName(path);
			}
		}
	}
}
