using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SemiCircleLab
{
    public class Circle
    {
        private double Radius { get; set; }
        public double area { get; set;}
        public double diameter { get; set; }
        public double circumference { get; set; }
       

        //Create a constructor
        public Circle(double _radius)
        {
            Radius = _radius;
           
        }

       

        
        

        public double CalculateDiameter(double Radius) 
        {
            double diameter = 2 * Radius; 
            return diameter; 
        
        }

        public double CalculateCircumference(double Radius)
        { 
           double circumference = 2 * (Math.PI*Radius);
           return circumference;
        }

        public double CalculateArea(double Radius)
        { 
           double area = Math.PI * ( Radius * Radius);
           return area;
        }

      

        public static implicit operator double(Circle v)
        {
            throw new NotImplementedException();
        }

        public void Grow(double Radius)
        {

            Radius = Radius * 2;


        }

        //public double GetRadius()
        //{ 

        //    return input; 

        //}










    }

}
