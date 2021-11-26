﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DocTools.Dtos;

namespace DocTools.DBDoc
{
    public class XmlDoc : Doc
    {
        public XmlDoc(DBDto dto, string filter = "xml files (.xml)|*.xml") : base(dto, filter)
        {
        }

        public override void Build(string filePath)
        {
            string xmlContent = this.Dto.Tables.SerializeXml();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlContent);

            var root = xmlDoc.DocumentElement;
            root.SetAttribute("databaseName", this.Dto.DBName);
            root.SetAttribute("tableNum", this.Dto.Tables.Count + "");
            xmlDoc.Save(filePath);
        }
    }
}
