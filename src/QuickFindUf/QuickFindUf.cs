using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFindUf
{
    public class QuickFindUf
    {
        private readonly int[] _id;

        /// <summary>
        /// Initialize Union-Find data structure with N objects(0 to N-1). Has N array accesses
        /// </summary>
        public QuickFindUf(int n)
        {
            _id = new int[n];

            for(int i = 0; i < n; i++)
            {
                _id[i] = i;
            }
        }

        /// <summary>
        /// Add connection between p and q. At most 2N+2 array accesses. 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        public void Union(int p, int q)
        {
            int pId = _id[p];
            int qId = _id[q];

            // Change all entries with id[p] to id[q]
            for (int i = 0; i < _id.Length; i++)
            {
                if(_id[i] == pId)
                {
                    _id[i] = qId;
                }
            }
        }

        /// <summary>
        /// Are p and q in the same component? Has 2 array accesses
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool Connected(int p, int q)
        {
            return _id[p] == _id[q];
        }
    }
}
