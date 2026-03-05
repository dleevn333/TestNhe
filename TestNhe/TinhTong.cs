using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNhe
{
    public class TinhTong
    {
        public int TinhTongCacSo(int[] arr)
        {
            if(arr == null || arr.Length == 0)
            
                return 0;
            int sum = 0;
            foreach(var i in arr)
            {
                sum += i;
            }
return sum;
        }
    }
}
