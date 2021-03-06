﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constantes

            //string url = @"http://www.google.com.ar";
            const string URL = @"http://www.desarrollaconmsdn.com/";

            #endregion

            #region Leer el contenido de una página en un StreamReader
            
            Console.WriteLine("Leer el contenido de una página en un StreamReader");
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            Console.WriteLine(reader.ReadToEnd());
            Console.ReadLine();
            Console.WriteLine("---------");
            Console.WriteLine(response.Headers);
            reader.Close();
            response.Close();
            Console.ReadLine();

            #endregion

            #region Escribir el contenido de una página en un archivo

            Console.WriteLine("Escribir el contenido de una página en un archivo");
            string archivo = @"c:\archivo.html";
            //Borra el archivo si existe
            if (File.Exists(archivo))
                File.Delete(archivo);
            //Creamos un archivo para guardar el contenido de la página
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fs);
            HttpWebRequest requestWriter = (HttpWebRequest)HttpWebRequest.Create(URL);
            HttpWebResponse responseWriter = (HttpWebResponse)requestWriter.GetResponse();
            StreamReader streamReader = new StreamReader(responseWriter.GetResponseStream());

            streamWriter.Write(streamReader.ReadToEnd());

            streamReader.Close();
            responseWriter.Close();
            Console.WriteLine("Archivo escrito exitosamente");
            Console.ReadLine();

            #endregion
        }
    }
}
