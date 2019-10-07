using DataGenerator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.BL.Tests
{
    public class RepositoryMock : IRepository
    {
        public string GetRandomEmailDomain()
        {
            return "gmail.com";
        }

        public string GetRandomName()
        {
            return "Иван";
        }

        public string GetRandomPatronymic()
        {
            return "Иванович";
        }

        public string GetRandomSurname()
        {
            return "Иванов";
        }

        public string GetRandomUniqLogin()
        {
            return "Ivan";
        }

        public void Init()
        {
            throw new NotImplementedException();
        }
    }
}
