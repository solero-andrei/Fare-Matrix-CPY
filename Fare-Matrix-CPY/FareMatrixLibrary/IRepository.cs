using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareMatrixLibrary
{
    public interface IRepository
    {
        void Add(string NameOfTable, string attributes, string values);
        void Delete();
        void Update();
        void Get();
    }
}
