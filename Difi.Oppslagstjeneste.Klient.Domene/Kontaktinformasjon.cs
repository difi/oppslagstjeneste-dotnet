﻿using System.Xml;
using Difi.Oppslagstjeneste.Klient.Felles.Envelope;

namespace Difi.Oppslagstjenesten.Domene
{
    /// <summary>
    /// Kontaktinformasjon er Adresse informasjon knyttet til en Person for å kommunisere med person
    /// </summary>
    public class Kontaktinformasjon
    {
        /// <summary>
        /// Informasjon om en Person sitt Mobiltelefonnummer registrert i kontakt og reservasjonsregisteret.
        /// </summary>
        public Mobiltelefonnummer Mobiltelefonnummer { get; set; }

        /// <summary>
        /// Informasjon om en Person sitt Epostadresse registrert i kontakt og reservasjonsregisteret.
        /// </summary>
        public Epostadresse Epostadresse { get; set; }

        public Kontaktinformasjon(XmlElement element)
        {            
            var epost = element["Epostadresse", Navnerom.difi];
            if (epost != null)
                this.Epostadresse = new Epostadresse(epost);

            var mobiltelefonnummer = element["Mobiltelefonnummer", Navnerom.difi];
            if (mobiltelefonnummer != null)
                this.Mobiltelefonnummer = new Mobiltelefonnummer(mobiltelefonnummer);
        }
    }
}