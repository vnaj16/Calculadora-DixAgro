using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDixAgro_App.Model
{
    public class ArrozPilado
    {
        private decimal cmp;

        public decimal CMP
        {
            get { return cmp; }
            set { cmp = value; }
        }

        private decimal flete;

        public decimal Flete
        {
            get { return flete; }
            set { flete = value; }
        }

        private decimal maquila;

        public decimal Maquila
        {
            get { return maquila; }
            set { maquila = value; }
        }


        private decimal envases;

        public decimal Envases
        {
            get { return envases; }
            set { envases = value; }
        }

        private decimal otros;

        public decimal Otros
        {
            get { return otros; }
            set { otros = value; }
        }

        private decimal descarte;

        public decimal Descarte
        {
            get { return descarte; }
            set { descarte = value; }
        }

        private decimal arrocillo;

        public decimal Arrocillo
        {
            get { return arrocillo; }
            set { arrocillo = value; }
        }

        private decimal polvillo;

        public decimal Polvillo
        {
            get { return polvillo; }
            set { polvillo = value; }
        }

        private decimal pap;

        public decimal PAP
        {
            get { return pap; }
            set { pap = value; }
        }


        private decimal cap;

        public decimal CAP
        {
            get
            {
                if(!CMP.Equals(0) && !Flete.Equals(0) && !Maquila.Equals(0) && !Descarte.Equals(0) && !Arrocillo.Equals(0)
                    && !Polvillo.Equals(0) && !PAP.Equals(0))
                {
                    return ((CMP + Flete + Maquila + Envases + Otros) - (Descarte + Arrocillo + Polvillo)) / PAP;
                }
                else
                {
                    throw new Exception("Complete los campos obligatorios (CMP, Flete, Maquila, Descarte, Arrocillo, Polvillo, PAP)");
                }
                //ACA HACER LAS VALIDACIONES Y LANZAR UNA EXCEPCION

            }
        }

    }
}
