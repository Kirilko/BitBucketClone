using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTrainerAccount
{
    class Game
    {
        public int CntCorrect { get; protected set; }
        public int CntWrong { get; protected set; }
        public bool AnsCorrect { get; protected set; }
        public string CodeText { get; protected set; }

        public event EventHandler Change;

        public void Reset() {
            CntCorrect = 0;
            CntWrong = 0;
            Continue();
        }

        public void Continue() {
            Random rnd = new Random();
            int xValue1 = rnd.Next(20);
            int xValue2 = rnd.Next(20);
            int xResult = xValue1 + xValue2;
            int xResultNew, xSign;
            if (rnd.Next(2) == 1)
            {
                xResultNew = xResult;
            } else
            {
                if (rnd.Next(2) == 1)
                    xSign = 1;
                else
                    xSign = -1;
                xResultNew = xResult + (rnd.Next(7) * xSign);
            }
            AnsCorrect = (xResult == xResultNew);
            CodeText = String.Format("{0} + {1} = {2}", xValue1, xValue2, xResultNew);
            if (Change != null)
                Change(this, EventArgs.Empty);

        }

        public void Answer(bool v) {
            if (v == AnsCorrect)
                CntCorrect++;
            else
                CntWrong++;
            Continue();
        }
    }
}
