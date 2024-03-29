﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingLab
{
    internal class Circle
    {
        public double Radius { get; set; }


        public double Area
        {
            get
            {
                return Math.PI*Radius*Radius;
            }
        }

        /// <summary>
        /// constructors
        /// </summary>
        public Circle() 
        { 
        }

        public Circle(double radius)
        {
            //radius can't be negative, nor 0
            // want to stop radius to be an invalid value
            // throw an exception
           if(radius < 0)
            {
                //throw new InvalidRadiusException("Invalid number,",radius);
                throw new InvalidRadiusException(radius);
            }
           else if(radius == 0)
            {
                throw new InvalidRadiusException("Radius 0 would return a 0 area of a circle. Enter a value > 0.");
            }
           else if (radius>0)
            {
                Radius = radius;
            }
           else
            {
                throw new InvalidRadiusException();
            }

            
        }


        public override string ToString()
        {
            return $"A circle's area with a radius of {Convert.ToString(Radius)} is: {Convert.ToString(Area)}.";
        }
    }
}
