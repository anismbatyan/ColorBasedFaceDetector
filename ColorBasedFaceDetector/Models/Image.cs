using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace ColorBasedFaceDetector.Models
{
    public class Image
    {
        private Bitmap m_image = null;

        public Image(string path)
        {
            m_image = new Bitmap(path);
        }

        void set(string path)
        {
            m_image = new Bitmap(path);
        }

    }
}
