using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DienTruong_Ver5
{
    public class Caculator
    {
        int intXB, intYB;
        int intXV, intYV;
        
        public Caculator(int x1, int y1, int x2, int y2)
        {
            intXB = x1; intYB = y1;
            intXV = x2; intYV = y2;
        }
        
        public float Distance()
        {
            
            float distance;
            int a = intXV - intXB; int b = intYV - intYB;
            distance = (float) Math.Sqrt(a * a + b * b);
            return distance;
            
        }
        
        public float ElectricX()
        {
            float dis = Distance();
            float EX = (intXV - intXB) / (dis * dis * dis);
            return EX;
        }
        public float ElectricY()
        {
            float dis = Distance() ;
            float EY = (intYV - intYB) / (dis * dis * dis);
            return EY;
        }



    }
}