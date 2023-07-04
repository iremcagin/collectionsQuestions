using System;
using System.Collections;

namespace collections1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nums = new ArrayList();
            ArrayList prime = new ArrayList();
            ArrayList notPrime = new ArrayList();
            int totalEnt = 0;

            try{
                while(totalEnt < 20){
                    Console.Write((totalEnt+1)+": ");
                    int x = int.Parse(Console.ReadLine());

                    if (x < 0)
                        throw new InvalidDataException("Invalid number.");
                    else 
                        nums.Add(x);
                        totalEnt++;
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message.ToString());
            }



            foreach(var i in nums){
                if(isPrime(Convert.ToInt32(i))){
                    prime.Add(Convert.ToInt32(i));
                }else{
                    notPrime.Add(Convert.ToInt32(i));
                }
            }


            prime.Sort();
            notPrime.Sort();
            double avg = 0;

            Console.Write("Prime numbers ("+prime.Count+"): ");
            for(int i=0; i<prime.Count; ++i){
                Console.Write(Convert.ToInt32(prime[i])+" ");
                avg += Convert.ToInt32(prime[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Average of primes: "+avg/prime.Count);

            avg = 0;
            Console.Write("Not prime numbers ("+notPrime.Count+"): ");
            for(int i=0; i<notPrime.Count; ++i){
                Console.Write(Convert.ToInt32(notPrime[i])+" ");
                avg += Convert.ToInt32(notPrime[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Average of not primes: "+avg/notPrime.Count);

        }


        static bool isPrime(int n)
        {
            if (n <= 1) return false;
            // Check from 2 to sqrt(n)
            for (int i = 2; i < Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}