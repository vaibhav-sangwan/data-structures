using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class UnionFind
    {
        int[] id = null;
        int[] sz = null;
        public int numOfComponents = 0;

        public UnionFind(int size)
        {
            int[] idArr = new int[size];
            int[] szArr = new int[size];
            numOfComponents = size;
            for(int i = 0; i < size; i++)
            {
                idArr[i] = i;
                szArr[i] = 1;
            }
            id = idArr;
            sz = szArr;
        }

        public int Find(int x)
        {
            int root = x;
            while(id[root] != root)
            {
                root = id[root];
            }

            //Path Compression
            int temp = x;
            int next;
            while(temp != root)
            {
                next = id[temp];
                id[x] = root;
                temp = next;
            }

            return root;
        }

        public bool Unified(int x, int y)
        {
            return (Find(x) == Find(y));
        }

        public void Unify(int x, int y)
        {
            int rootX = Find(x), rootY = Find(y);
            if (rootX != rootY)
            {
                if(sz[rootX] <= sz[rootY])
                {
                    id[rootX] = rootY;
                    sz[rootY] += sz[rootX];
                }
                else
                {
                    id[rootY] = rootX;
                    sz[rootX] += sz[rootY];
                }
                numOfComponents--;
            }
        }
    }
}
