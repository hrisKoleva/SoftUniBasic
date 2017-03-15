using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADrawingFox
{
    class Fox
    {
        static void Main(string[] args)
        {
            /**\-------------/*
            //**\-----------/**
            //***\---------/***
            //****\-------/****
            //*****\-----/*****
            //******\---/******
            //*******\-/******* */


            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <=n; i++)
            {
                Console.Write(new string('*', i));
                Console.Write("\\");
                Console.Write(new string('-',2*n-2*i+1));
                Console.Write("/");
                Console.Write(new string('*', i));
                Console.WriteLine();
            }

            for (int i = 1; i <=3 ; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', (2 * n - 1) / 2));
            }
            



            for (int i = 0; i < n; i++)
            {

            }
        }
    }
}
