using System;
#if(__MonoCS__)
using Mono.Unix.Native;
#endif

namespace UsingMonoPosix {
    class MainClass {
        public static void Main (string[] args) {
            #if(__MonoCS__)
            Console.WriteLine("Built on mono, here is a signal: {0}", Signum.SIGKILL);
            #else
            Console.WriteLine ("Built on .net, no idea what a signal is.");
            #endif
        }
    }
}
