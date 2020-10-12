using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System.Linq;

using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuantumEncryptionSeed
{
    class Driver
    {
        static string bitgenerator(){
             using (var sim = new QuantumSimulator())
            {                
                var output = RandomQuantumBitGenerator.Run(sim).Result == Result.One ? "1" : "0";
                
                return output;  // Return the result          
            }
        }

        static string bitstring() {
            string bits = "";
            for (int i=0; i<=128; i++){
                bits += bitgenerator();
            }
            Console.WriteLine(bits);
            return bits;
        }


        private static byte[] GetBytes(string bitString)
        {
             byte[] result = Enumerable.Range(0, bitString.Length / 8).
                 Select(pos => Convert.ToByte(
                   bitString.Substring(pos * 8, 8), 2)).ToArray();

                  List<byte> myByteArray = new List<byte>();
                      for (int i = result.Length - 1; i >= 0; i--)
                      {
                       myByteArray.Add(result[i]);
                      }

            return myByteArray.ToArray();
        }
      
        static void Main(string[] args)
        {
           Console.WriteLine(Convert.ToBase64String(GetBytes(bitstring())));
           
         }
      }
    }