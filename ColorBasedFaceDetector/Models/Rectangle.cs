using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ColorBasedFaceDetector.Models
{
    public class Rectangle : Shape
    {
        private Point m_topLeftPoint
        {
            get
            {
                return this.m_topLeftPoint;
            }
            set
            {
                this.m_topLeftPoint = value;
            }
        }

        private Point m_bottomRightPoint
        {
            get
            {
                return this.m_bottomRightPoint;
            }
            set
            {
                this.m_bottomRightPoint = value;
            }
        }

        public void draw()
        {
            //to be implemented
        }
    }
}
