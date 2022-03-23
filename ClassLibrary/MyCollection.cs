using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

   public class MyCollection<T> : IWorkWithContainer<T>
    {

        List<T> list = new List<T>();

        public void GetTypeToContainer(T name)
        {
            list.Add(name);

        }
        public T SearchToIndex(int indx)
        {
            return list[indx];
        }

        public int elements
        {
            get
            {
                return list.Count;

            }
        }




    }
}
