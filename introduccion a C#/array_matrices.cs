 /// array
            int[] a1 = new int[3];
            int A = 3;
            for (int w = 0; w < A; w++)
            {
                a1[w] = w;
            }

          /// inspeccionar el array  
            foreach (int s in a1) {
                Console.Write(s);
            }

/// matris

    int[,] a2 = new int[3, 2];


    for (int c = 0; c < 3; c++)
    {
        for (int t = 0; t < 2; t++)
        {
            a2[c, t] = t+c;
        }
            
    }
    
    ///inspeccionar la matris
            
    foreach (int i in a2)
    {
        System.Console.Write("{0} ", i + "\n");
    }
    
    Console.ReadKey();