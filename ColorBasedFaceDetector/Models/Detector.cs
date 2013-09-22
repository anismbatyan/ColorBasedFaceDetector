using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColorBasedFaceDetector.Models
{
    public interface Detector
    {
        private Image m_image;

        public Shape detect();
    }
}
