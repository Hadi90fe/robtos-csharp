using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Alchemy
{
    public class Robot
    {
        public int id;
        public string nom;
        public string poids;
        public string pays;
        public Robot(int id, string nom, string poids, string pays)
        {

            this.id = id;
            this.nom = nom;
            this.poids = poids;
            this.pays = pays;
        }

        public string Link()
        {
            return "https://robohash.org/" + nom;
        }
    }
}