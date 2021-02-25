﻿using System.Text;
using System.Xml;
using Digipost.Api.Client.Shared.Resources.Resource;

namespace Difi.Oppslagstjeneste.Klient.Resources.Xml
{
    internal class XmlResource
    {
        private static readonly ResourceUtility ResourceUtility = new ResourceUtility(
            typeof(XmlResource).Assembly
            , "Difi.Oppslagstjeneste.Klient.Resources.Xml.Data");

        private static XmlDocument GetResource(params string[] path)
        {
            var bytes = ResourceUtility.ReadAllBytes(path);
            return XmlUtility.ToXmlDocument(Encoding.UTF8.GetString(bytes));
        }

        internal class Request
        {
            public static XmlDocument GetPerson()
            {
                return GetResource("Request", "HentPersoner.xml");
            }
        }

        internal class Response
        {
            public static XmlDocument GetPerson()
            {
                return GetResource("Response", "HentPersoner.xml");
            }

            public static XmlDocument GetPersonResponseEncrypted()
            {
                return GetResource("Response", "HentPersonerEncrypted.xml");
            }

            public static XmlDocument GetSoapFault()
            {
                return GetResource("Response", "SoapFault.xml");
            }

            public static XmlDocument GetPrintCertificate()
            {
                return GetResource("Response", "HentPrintSertifikat.xml");
            }

            public static XmlDocument GetEndringer()
            {
                return GetResource("Response", "HentEndringer.xml");
            }
        }
    }
}
