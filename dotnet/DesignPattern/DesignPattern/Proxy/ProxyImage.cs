using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Proxy.Interfaces;
using DesignPattern.Proxy.Models;

namespace DesignPattern.Proxy
{
    public class ProxyImage : Image
    {
        private RealImage realImage;
        private string _fileImage;

        public ProxyImage(string fileImage)
        {
            _fileImage = fileImage;
        }

        public string Display()
        {
            if (realImage == null)
                realImage = new RealImage(_fileImage);

            return realImage.Display();
        }
    }
}
