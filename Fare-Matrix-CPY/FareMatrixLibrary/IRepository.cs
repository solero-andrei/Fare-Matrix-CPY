using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareMatrixLibrary
{
    public interface IRepository
    {
        void Add(string tableName, string attributes, string values);
        bool Get(string query);
        void Delete();
        void Update();
        
    }
}
