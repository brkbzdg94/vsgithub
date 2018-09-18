using System;

namespace vsgithub
{
    public class SonarTest
    {
       public void T_Goto()
        {
            for (int i = 0; i < 100; i++)
            {

                Console.WriteLine("gggggggggggggggg");
                if (i > 5)
                {
                    goto A;
                    }
            }

            A:
            Console.WriteLine("The number  is found.");
        }
    }
}
