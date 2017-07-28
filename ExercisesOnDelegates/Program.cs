using ExercisesOnDelegates.PingPong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOnDelegates
{
    class Program
    {
        //define delegate type
        public delegate void WriteMessage();
        //declare a memeber variable of this delegate
        private static WriteMessage listOfMessages;

        //add registration function for the caller
        public static void registerMessage(WriteMessage methodToCall)
        {
            listOfMessages += methodToCall;
        }

        private static void Play()
        {
            Ping ping = new Ping();
            Pong pong = new Pong();
            registerMessage(new WriteMessage(ping.Write));
            registerMessage(new WriteMessage(pong.Write));
            for (int i = 0; i < 5; i++)
            {
                listOfMessages();
            }
        }
        static void Main(string[] args)
        {
            Play();
        }
    }
}
