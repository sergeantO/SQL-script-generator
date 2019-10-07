using DataGenerator.Data;
using DataGenerator.BL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.BL.Tests
{
    [TestFixture]
    public class ScriptGeneratorTest
    {
        private IScriptGenerator _generator;

        [SetUp]
        public void Init()
        {
            // Arrange
            _generator = null;
        }

        [Test]
        public void GenerateUser_NameRequired()
        {
            // Act
            UserEntity entity = _generator.GenerateUser();
            string name = entity.Name;

            // Assert
            Assert.That(name, Is.Not.Empty);
        }

        [Test]
        public void GenerateUser_SurnameRequired()
        {
            // Act
            UserEntity entity = _generator.GenerateUser();
            string surname = entity.Surname;

            // Assert
            Assert.That(surname, Is.Not.Empty);
        }

        [Test]
        public void GenerateUser_LoginRequired()
        {
            // Act
            UserEntity entity = _generator.GenerateUser();
            string login = entity.Login;

            // Assert
            Assert.That(login, Is.Not.Empty);
        }

        [Test]
        public void GenerateUser_PasswordRequired()
        {
            // Act
            UserEntity entity = _generator.GenerateUser();
            string password = entity.Login;

            // Assert
            Assert.That(password, Is.Not.Empty);
        }

        [Test]
        public void GenerateUser_EmailRequired()
        {
            // Act
            UserEntity entity = _generator.GenerateUser();
            string email = entity.Login;

            // Assert
            Assert.That(email, Is.Not.Empty);
        }

        [Test]
        public void GenerateUser_RegistrationDatePeriod()
        {
            // Act
            UserEntity entity = _generator.GenerateUser();
            DateTime registrationDate = entity.RegistrationDate;

            // Assert
            Assert.That(registrationDate, Is.InRange(new DateTime(2010, 1, 1), new DateTime(2016, 2, 29)));
        }

        [Test]
        public void GenerateUser_GetValueLine()
        {
            // Arrange
            UserEntity user = new UserEntity()
            {
                Name = "Петр",
                Surname = "Петров",
                Patronymic = "Петрович",
                Email = "petr@gmail.com",
                Login = "petr",
                Password = "12345",
                RegistrationDate = new DateTime(2016, 1, 1)
            };
            const string EXPECTED_RESULT = @"VALUES ('Петр', 'Петров', 'Петрович', 'petr@gmail.com', 'petr', '12345', '20160101')";

            // Act
            string result = _generator.GetValueLine(user);

            // Assert
            Assert.That(result, Is.EqualTo(EXPECTED_RESULT));
        }

        [Test]
        public void GenerateUser_GetInsertLine()
        {
            // Arrange
            const string EXPECTED_RESULT = @"INSERT INTO BlogUser (Name, Surname, Patronymic, Email, UserLogin, Password, RegistrationDate)";

            // Act
            string result = _generator.GetInsertLine();

            // Assert
            Assert.That(result, Is.EqualTo(EXPECTED_RESULT));
        }

    }
}
