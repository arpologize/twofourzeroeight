using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace twozerofoureight
{
    public class Model
    {
        protected ArrayList oList;
        protected int score = 0;
        protected bool Gameover = false;
        public Model()
        {
            oList = new ArrayList();
        }
        public void NotifyAll()
        {
            foreach (View m in oList)
            {
                m.Notify(this);
            }
        }
        public int Showscore()
        {
            return score;
        }
        public bool checkgameover()
        {

            return Gameover;
            
        }
        public void AttachObserver(View m)
        {
            oList.Add(m);
        }

    }
}
