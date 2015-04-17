﻿using System.Diagnostics;
using System.Xml;
using Difi.Oppslagstjeneste.Klient.Felles.Envelope;

namespace Difi.Oppslagstjenesten.Domene
{
    /// <summary>
    /// Adresse informasjon om Person sin Sikker DigitalPostKasse.
    /// </summary>
    [DebuggerDisplay("Postkasseadresse = {Postkasseadresse} PostkasseleverandoerAdresse = {PostkasseleverandoerAdresse}")]
    public class Sikkerdigitalpostadresse
    { 
        /// <summary>
        /// Adresse til en Innbygger sin Postkasse hos en Postkasseleverandør
        /// </summary>
        /// <remarks>
        /// Dette er en unik adresse for en Person sin Postkasseadresse hos en Postkasseleverandør. Enten digipost eller eboks. 
        /// For definisjon av postkasseadressen hos Digipost se: https://www.digipost.no/plattform/felles/digipostadresser
        /// </remarks>
        public string Postkasseadresse { get; set; }

        /// <summary>
        /// Adresse til en leverandør av Postkassetjeneste
        /// </summary>
        /// <remarks>
        /// Dette er en unik adresse for en leverandør, enten en Postkasseleverandør eller Utskrifts og forsendelsestjeneeste leverandør. 
        /// Adressen brukt for adressering er Organisasjonsnummeret for leverandører
        /// </remarks>
        public string PostkasseleverandoerAdresse { get; set; }

        public Sikkerdigitalpostadresse(XmlElement element)
        {
            this.Postkasseadresse = element["postkasseadresse", Navnerom.difi].InnerText;
            this.PostkasseleverandoerAdresse = element["postkasseleverandoerAdresse", Navnerom.difi].InnerText;
        }
    }
}