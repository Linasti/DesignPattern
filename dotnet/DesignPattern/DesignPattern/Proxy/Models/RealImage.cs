using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Proxy.Interfaces;

namespace DesignPattern.Proxy.Models
{
    public class RealImage : Image
    {
        private string _fileImage;

        public RealImage(string fileName)
        {
            _fileImage = fileName;
            loadFromDisk(fileName);
        }


        private void loadFromDisk(string fileImage)
        {
            // Loading real Image ...
        }

        public string Display()
        {
            return $"Displaying {_fileImage}";
        }
    }
}
