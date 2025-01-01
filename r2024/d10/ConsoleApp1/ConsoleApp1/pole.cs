using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class pole
    {
        public int x;
        public int y;
        public int score;
    public List<int> gX;
    public List<int> gY;
        public pole(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.score = 0;
        this.gX = new List<int>();
        this.gY = new List<int>();
        }

    public bool czyLiczyc(int x, int y)
    {
        bool wynik = true;
        for (int i = 0; i<gX.Count();i++)
        {
            if (gX[i]==x && gY[i]==y) wynik = false;
        }
        return wynik;
    }
    }

