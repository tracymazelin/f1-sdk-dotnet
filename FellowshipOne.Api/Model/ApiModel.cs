﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FellowshipOne.Api.Model {
    [Serializable]
    public class APIModel {
        [XmlIgnore]
        public int? ID {
            get {
                int id = int.MinValue;

                if (int.TryParse(this.APIModelID, out id)) {
                    return id;
                }

                return null;
            }
            set {
                if (value.HasValue) {
                    this.APIModelID = value.Value.ToString();
                }
            }
        }

        private string _apiModelID = string.Empty;
        [XmlAttribute("id")]
        public string APIModelID {
            get { return _apiModelID; }
            set { _apiModelID = value; }
        }

        private string _uri = string.Empty;
        [XmlAttribute("uri")]
        public string uri {
            get { return _uri; }
            set { _uri = value; }
        }
    }
}