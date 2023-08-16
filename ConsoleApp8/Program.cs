using System;
using System.Linq;

using ConsoleApp8.Model;

namespace ConsoleApp8 {
    internal class Program {
        static void Main(string[] args) {

            try {
                using (var ctx = new AdventureWorksEntities()) {
                    Console.WriteLine($"{ctx.Address.Count()} adresses");
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}