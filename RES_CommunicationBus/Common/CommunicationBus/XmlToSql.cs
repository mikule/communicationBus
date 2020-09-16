using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Common.CommunicationBus
{
    public class XmlToSql
    {
        public XmlToSql()
        {

        }

        public string Convert(XNode xml)
        {
            XElement request = xml.Document.Element("Request");
            string method = request.Element("Verb").Value.ToString();
            if(method == "GET")
            {
                return GenerateGetSQL(request);
            }
            else if(method == "PATCH")
            {
                return GeneratePatchSQL(request);
            }
            else if(method == "POST")
            {
                return GeneratePostSQL(request);
            }
            else if(method == "DELETE")
            {
                return GenerateDeleteSQL(request);
            }

            return "";
        }

        private string GenerateGetSQL(XElement request)
        {
            string sqlQuery = "";
            string noun = request.Element("Noun").Value;
            string query = request.Element("Query").Value;
            string fields = request.Element("Fields").Value;
            string[] nounParts = noun.Split('/');
            sqlQuery = "SELECT ";
            if (String.IsNullOrEmpty(fields))
            {
                sqlQuery = sqlQuery + " * ";
            }
            else
            {
                sqlQuery = sqlQuery + fields;
            }
            sqlQuery += " FROM " + nounParts[0];

            if (nounParts.Length >= 2 && !String.IsNullOrEmpty(nounParts[1]))
            {
                sqlQuery += " WHERE Id = " + nounParts[1];
            }

            query.Replace("&", " and ");
            if (!String.IsNullOrEmpty(query))
            {
                if (nounParts.Length >= 2 && !String.IsNullOrEmpty(nounParts[1]))
                {
                    sqlQuery += " AND ";
                }
                else
                {
                    sqlQuery += " WHERE ";
                }
                sqlQuery += query;
            }

            sqlQuery += ";";
            return sqlQuery;
        }

        private string GeneratePostSQL(XElement request)
        {
            string noun = request.Element("Noun").Value;
            noun = noun.Substring(1);
            string columns = "";
            string values = "";
            int i = 0;
            string query = request.Element("Query").Value;
            string[] queryParts = query.Split(';');
            string[] columnParts;

            foreach (string part in queryParts)
            {
                if (columns != "")
                {
                    columns = columns + ",";
                    values = columns + ",";
                }
                columnParts = part.Split('=');
                columns = columns + columnParts[0];
                values = values + columnParts[1];
                i++;
            }

            return $"INSERT INTO {noun} ({columns}) VALUES ({values});";
        }
        
        private string GeneratePatchSQL(XElement request)
        { 
            string noun = request.Element("Noun").Value.Substring(1);
            string query = request.Element("Query").Value;
            string fields = request.Element("Fields").Value.Replace(";", ",");
            string[] nounSplited = noun.Split('/');

            string sqlRequest = "";
            sqlRequest = "UPDATE " + nounSplited[0] + " SET " + fields + " WHERE Id=" + nounSplited[1] + " ";
            if (query != null)
            {
                query = query.Replace("&", " AND ");
                sqlRequest += " AND " + query;
            }
            sqlRequest = sqlRequest + ";";
            return sqlRequest;
        }

        private string GenerateDeleteSQL(XElement request)
        {
            string sqlRequest = "";
            string noun = request.Element("Noun").Value;

            noun = noun.Substring(1);
            string[] NounSplited = noun.Split('/');
            sqlRequest = "DELETE FROM " + NounSplited[0] + " WHERE Id=" + NounSplited[1] + ";";

            return sqlRequest;
        }
    }
}