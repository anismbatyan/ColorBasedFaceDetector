using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ColorBasedFaceDetector.Models
{
    public class Line : Shape
    {
        private Point m_startPoint
        {
            get
            {
                return this.m_startPoint;
            }
            set
            {
                this.m_startPoint = value;
            }
        }

        private Point m_endPoint
        {
            get
            {
                return this.m_endPoint;
            }
            set
            {
                this.m_endPoint = value;
            }
        }

        public void draw()
        {
            //to be implemented
        }
    }
}