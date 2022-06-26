using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._1.Magazin_Laborator8_
{
    class TV
    {
        /*• Fiecare televizor va costa 1000 de ron.
          • Va avea un model și producător
          • Va avea o metodă care va porni televizorul pe un program cu muzica și va confirma acest lucru
          în consolă, menționând modelul și producătorul.
          • Va avea o metodă care va opri televizorul și va confirma acest lucru în consolă*/

        private int pret = 1000;
        private ModelTV model;
        private ProducatorTV producator;
        private bool pornit = false;
        private PosturiTV post;


        enum PosturiTV
        {
            Stiri, Muzica, Cultural, Cartoon
        }
        /// <summary>
        /// Creaza televizor.
        /// </summary>
        /// <param name="producator"></param>
        /// <param name="model"></param>
        public TV(ProducatorTV producator, ModelTV model)
        {
            this.producator = producator;
            this.model = model;
        }



        /// <summary>
        /// Porneste TV.
        /// </summary>
        public void Porneste()
        {
            pornit = true;
            this.post = PosturiTV.Muzica;
            Console.WriteLine($"{this.producator} {this.model} este pornit pe canalul {this.post}.");
        }
        /// <summary>
        /// Opreste TV.
        /// </summary>
        public void Opreste()
        {
            pornit = false;
            Console.WriteLine($"{this.producator} {this.model} este oprit.");
        }
        /// <summary>
        /// Returneaza pretul unui televizor.
        /// </summary>
        /// <returns></returns>
        public int GetPret()
        {
            return this.pret;
        }
        /// <summary>
        /// Returneaza numele producatorului unui TV.
        /// </summary>
        /// <returns></returns>
        public ProducatorTV GetProducator()
        {
            return this.producator;
        }
        /// <summary>
        /// Returneaza modelul unui TV.
        /// </summary>
        /// <returns></returns>
        public ModelTV GetModel()
        {
            return this.model;
        }
        /// <summary>
        /// Schimba un TV pe canalul Muzica.
        /// </summary>
        public void SetPostTVMuzica()
        {
            this.post = PosturiTV.Muzica;
        }
    }
    enum ProducatorTV
    {
        Samsung, LG, Nei, Philips, empty
    }
    enum ModelTV
    {
        SA55, LG30, N45, PH35, empty
    }

}
