using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace gmsToGd
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter str = new StreamWriter(@"archivo.txt");
            string query = "";
            double divMin = 0;
            double divSeg = 0;
            //------
            double divMin1 = 0;
            double divSeg1 = 0;
            int latitud = 0;
            int longitud = 0;
            double minutos = 60;
            double segundos = 3600;

            //------------------------DATOS PARA EL CICLO FOR
            double m1 = 0;
            double m11 = 0;
            double m2 = 0;
            double m22 = 0;
            double m3 = 0;
            double m33 = 0;
            //-----------------------------------------------
            string digitos = "10000";
            for (int i = 1; i <=1; i++)

            {
                
                
                Console.WriteLine("Latitud " +i+":");
                latitud = int.Parse(Console.ReadLine());
                //------------------proceso para sacar GMS
                m1 = latitud / 10000; //Primeros 2 números
                
                
                int m4 = latitud % Convert.ToInt32(digitos);
                string result = m4.ToString();
                int ZeroConditional = int.Parse(result);
                string sub = "";

                if (ZeroConditional==0)
                {
                    try
                    {
                        divMin = 0;
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
                else
                { 
                    try
                    {
                        sub = result.Substring(0, result.Length - 2); // Segundos dos números de en medio
                    }
                    catch (Exception ex)
                    {

                        throw ex; 
                    }
                }
                
                m2 = (latitud % (10000));
                m3 = latitud % 100;
                //--------------------------------------------
                //Console.WriteLine(m1+" "+sub+" "+m3);
                if (ZeroConditional==0)
                {
                    divMin = 0;
                }
                else
                {
                    divMin = Convert.ToDouble(sub) / minutos; //Números de en medio entre minutos
                }
                
                divSeg = m3 / segundos;
                //--------------Asignar valor  a LATITUD Y LONGITUD
                
                //Console.WriteLine(m1 + " " + divMin + " " + divSeg);
                double suma = m1 + divMin + divSeg;

                //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

                Console.WriteLine("Longitud " + i + ":");
                longitud = int.Parse(Console.ReadLine());
                //------------------proceso para sacar GMS
                m11 = longitud/ 10000;


                int m44 = longitud % Convert.ToInt32(digitos);
                string result2 = m44.ToString();
                double conditional

                if (true)
                {

                }
                string sub1 = result2.Substring(0, result2.Length - 2);
                m22 = (longitud% (10000));
                m33 = longitud % 100;
                //--------------------------------------------
                //Console.WriteLine(m1+" "+sub+" "+m3);
                divMin1 = Convert.ToDouble(sub1) / minutos;
                divSeg1 = m33 / segundos;
                //--------------Asignar valor  a LATITUD Y LONGITUD

                //Console.WriteLine(m1 + " " + divMin + " " + divSeg);
                double suma2 = m11 + divMin1 + divSeg1;
                //..............escribe y guarda en txt
                Console.WriteLine("lat:{0}, lng: {1}",suma,suma2);
                 query = "INSERT INTO co_coordenadas(lat,lng,IdAreaContractual) VALUES ('" + suma+"','-"+suma2+ "',10014);";
                //query = "update CO_Instalacion SET utmX = '-" + suma2 + "' , utmy ='" + suma + "' WHERE idEstatus=";
               //  query = "insert into CO_Instalacion (NombreInstalacion,IdInstalacionPemex,EsBolsa,IdActividad,IdUsuario,FecMovto,NombreInstalacionAlterno,IdCatalogoSCIEP,IdAreaContractual,Activo,CUIP,WelIID,IdYacimiento,IdCampo,UTMX,UTMY,CreadoPor,IdEstatus) values('Topén  ', Null, 0, 5, 1, getdate(), 'Topén ', NUll, 10003, 1, NULL, NULL, NULL, 10006, '-" + suma2 + "','" + suma + "', NULL, NULL); ";
                str.WriteLine(query);
            }
            str.Close();
            Console.Read();
        }
      }
    }
          

                                