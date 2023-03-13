using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OOO_Violet.Classes;
using static System.Net.Mime.MediaTypeNames;
using OOO_Violet;

namespace UnitTestPractice
{
    [TestClass]
    public class UnitTest1
    {
        private OOO_VioletEntities3 local;
        [TestMethod]        
            public void Authorization_ReturnsRoleName_WhenLoginAndPasswordCorrect()
            {
            // Arrange
            string expectedRoleName = "Администратор";
            string login = "jfi354kf83kits@gmail.com";
            string password = "Dfkf34F";

            // Act
            string actualRoleName = local.FAutores(login, password);

            // Assert
            Assert.AreEqual(expectedRoleName, actualRoleName);
        }

            [TestMethod]
            public void Authorization_ReturnsEmptyString_WhenLoginOrPasswordIncorrect()
            {
            // Arrange
            string expectedRoleName = "";
            string login = "jfi354kf83kits@gmail.com";
            string password = "Dfkf34F";

            // Act
            string actualRoleName = local.FAutores(login, password);

            // Assert
            Assert.AreEqual(expectedRoleName, actualRoleName);
        }

            [TestMethod]
            public void FormProduct_Load_Should_Fill_DataGridView_WithData()
            {
            // Arrange
            var katalog = new Katalog("Администратор");

            // Act
            katalog.FormProduct_Load(this, EventArgs.Empty);

            // Assert
            Assert.IsTrue(katalog.dataproducttable.Rows.Count > 0);
        }

            [TestMethod]
            public void FormProduct_Load_Should_Disable_AddProductButton_For_User_Role_Client()
            {
            // Arrange
            var katalog = new Katalog("Клиент");

            // Act
            katalog.FormProduct_Load(this, EventArgs.Empty);

            // Assert
            Assert.IsFalse(katalog.buttonaddproduct.Enabled);
            Assert.IsFalse(katalog.buttonaddproduct.Visible);
        }
            [TestMethod]
            public void TestFormAuto()
            {
            // Arrange
            var formAuto = new FAutores();
            var loginTextBox = formAuto.Controls["tbLogin"] as tblogin;
            var passwordTextBox = formAuto.Controls["tbPassword"] as tbpassword;
            loginTextBox.Text = "admin";
            passwordTextBox.Text = "admin";

            // Act
            formAuto.buttonVHOD.PerformClick();

            // Assert
            var katalog = Application.OpenForms.OfType<Katalog>().FirstOrDefault();
            Assert.IsNull(katalog);
        }
       
    }
}
