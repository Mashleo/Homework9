using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
    public interface IWorkWithContainer<T>
   
    {
        void GetTypeToContainer(T name);
        T SearchToIndex(int indx);
        int elements { get; }
    }
}
