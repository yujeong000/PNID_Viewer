﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNID_Viewer.Model
{
    public class XmlNameAndPathModel : INotifyPropertyChanged
    {
        private string xmlName;

        public string XmlName
        {
            get { return xmlName; }
            set { xmlName = value; OnPropertyChanged(nameof(XmlName)); }
        }

        private string xmlPath;

        public string XmlPath
        {
            get { return xmlPath; }
            set { xmlPath = value; OnPropertyChanged(nameof(XmlPath)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
