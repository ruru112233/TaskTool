using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    
    DateTime now, startTime, endTime;

    TimeSpan diff, diff1, diff2, diff3, diff4, diff5, diff6, diff7, diff8, diff9, diff10;

    private void Start()
    {
        int h = diff.Hours;
        int m = diff.Minutes;
        int s = diff.Seconds;

        if (h != 0)
        {
            GameManager.instance.resultTime.text = h.ToString("f0") + "時間" + m.ToString("f0") + "分" + s.ToString("f0") + "秒";
        }
        else if (m != 0)
        {
            GameManager.instance.resultTime.text = m.ToString("f0") + "分" + s.ToString("f0") + "秒";
        }
        else
        {
            GameManager.instance.resultTime.text = s.ToString("f0") + "秒";
        }
    }

    public void StartButton()
    {
        now = DateTime.Now;

        startTime = now;

        GameManager.instance.startFlag = true;
        GameManager.instance.keisokuchuuFlag = true;
        GameManager.instance.stopFlag = true;
        
    }

    public void StopButton()
    {
        now = DateTime.Now;

        endTime = now;

        if (diff != TimeSpan.Zero)
        {

            Debug.Log(GameManager.instance.taskNo);
            switch (GameManager.instance.taskNo)
            {
                case 1:
                    diff = endTime - startTime + diff1;
                    
                    break;
                case 2:
                    diff = endTime - startTime + diff2;
                    break;
                case 3:
                    diff = endTime - startTime + diff3;
                    break;
                case 4:
                    diff = endTime - startTime + diff4;
                    break;
                case 5:
                    diff = endTime - startTime + diff5;
                    break;
                case 6:
                    diff = endTime - startTime + diff6;
                    break;
                case 7:
                    diff = endTime - startTime + diff7;
                    break;
                case 8:
                    diff = endTime - startTime + diff8;
                    break;
                case 9:
                    diff = endTime - startTime + diff9;
                    break;
                case 10:
                    diff = endTime - startTime + diff10;
                    break;
            }
            
        }
        else
        {
            
            diff = endTime - startTime;

        }

        switch (GameManager.instance.taskNo)
        {
            case 1:
                diff1 = diff;
                break;
            case 2:
                diff2 = diff;
                break;
            case 3:
                diff3 = diff;
                break;
            case 4:
                diff4 = diff;
                break;
            case 5:
                diff5 = diff;
                break;
            case 6:
                diff6 = diff;
                break;
            case 7:
                diff7 = diff;
                break;
            case 8:
                diff8 = diff;
                break;
            case 9:
                diff9 = diff;
                break;
            case 10:
                diff10 = diff;
                break;

        }

        int h = diff.Hours;
        int m = diff.Minutes;
        int s = diff.Seconds;

        if (h != 0)
        {
            GameManager.instance.resultTime.text = h.ToString("f0") + "時間" + m.ToString("f0") + "分" + s.ToString("f0") + "秒";
        }
        else if (m != 0)
        {
            GameManager.instance.resultTime.text = m.ToString("f0") + "分" + s.ToString("f0") + "秒";
        }
        else
        {
            GameManager.instance.resultTime.text = s.ToString("f0") + "秒";
        }


        GameManager.instance.startFlag = false;
        GameManager.instance.keisokuchuuFlag = false;
        GameManager.instance.stopFlag = false;

    }

    public void TaskA()
    {
        if (!GameManager.instance.stopFlag)
        {
            if (diff1 == TimeSpan.Zero)
            {
                diff = TimeSpan.Zero;
            }

            int h = diff1.Hours;
            int m = diff1.Minutes;
            int s = diff1.Seconds;

            if (h != 0)
            {
                GameManager.instance.resultTime.text = h.ToString("f0") + "時間" + m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else if (m != 0)
            {
                GameManager.instance.resultTime.text = m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.resultTime.text = s.ToString("f0") + "秒";
            }

            GameManager.instance.taskNo = 1;
        }
        
    }

    public void TaskB()
    {
        if (!GameManager.instance.stopFlag)
        {
            if (diff2 == TimeSpan.Zero)
            {
                diff = TimeSpan.Zero;
            }

            int h = diff2.Hours;
            int m = diff2.Minutes;
            int s = diff2.Seconds;

            if (h != 0)
            {
                GameManager.instance.resultTime.text = h.ToString("f0") + "時間" + m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else if (m != 0)
            {
                GameManager.instance.resultTime.text = m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.resultTime.text = s.ToString("f0") + "秒";
            }

            GameManager.instance.taskNo = 2;
        }

        
    }
    public void TaskC()
    {
        if (!GameManager.instance.stopFlag)
        {
            if (diff3 == TimeSpan.Zero)
            {
                diff = TimeSpan.Zero;
            }

            int h = diff3.Hours;
            int m = diff3.Minutes;
            int s = diff3.Seconds;

            if (h != 0)
            {
                GameManager.instance.resultTime.text = h.ToString("f0") + "時間" + m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else if (m != 0)
            {
                GameManager.instance.resultTime.text = m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.resultTime.text = s.ToString("f0") + "秒";
            }

            GameManager.instance.taskNo = 3;
        }
        
    }
    public void TaskD()
    {
        if (!GameManager.instance.stopFlag)
        {
            if (diff4 == TimeSpan.Zero)
            {
                diff = TimeSpan.Zero;
            }

            int h = diff4.Hours;
            int m = diff4.Minutes;
            int s = diff4.Seconds;

            if (h != 0)
            {
                GameManager.instance.resultTime.text = h.ToString("f0") + "時間" + m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else if (m != 0)
            {
                GameManager.instance.resultTime.text = m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.resultTime.text = s.ToString("f0") + "秒";
            }

            GameManager.instance.taskNo = 4;
        }
        

    }
    public void TaskE()
    {
        if (!GameManager.instance.stopFlag)
        {
            if (diff5 == TimeSpan.Zero)
            {
                diff = TimeSpan.Zero;
            }

            int h = diff5.Hours;
            int m = diff5.Minutes;
            int s = diff5.Seconds;

            if (h != 0)
            {
                GameManager.instance.resultTime.text = h.ToString("f0") + "時間" + m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else if (m != 0)
            {
                GameManager.instance.resultTime.text = m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.resultTime.text = s.ToString("f0") + "秒";
            }

            GameManager.instance.taskNo = 5;
        }
        
    }
    public void TaskF()
    {
        if (!GameManager.instance.stopFlag)
        {
            if (diff6 == TimeSpan.Zero)
            {
                diff = TimeSpan.Zero;
            }

            int h = diff6.Hours;
            int m = diff6.Minutes;
            int s = diff6.Seconds;

            if (h != 0)
            {
                GameManager.instance.resultTime.text = h.ToString("f0") + "時間" + m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else if (m != 0)
            {
                GameManager.instance.resultTime.text = m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.resultTime.text = s.ToString("f0") + "秒";
            }

            GameManager.instance.taskNo = 6;
        }
        
    }
    public void TaskG()
    {
        if (!GameManager.instance.stopFlag)
        {
            if (diff7 == TimeSpan.Zero)
            {
                diff = TimeSpan.Zero;
            }

            int h = diff7.Hours;
            int m = diff7.Minutes;
            int s = diff7.Seconds;

            if (h != 0)
            {
                GameManager.instance.resultTime.text = h.ToString("f0") + "時間" + m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else if (m != 0)
            {
                GameManager.instance.resultTime.text = m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.resultTime.text = s.ToString("f0") + "秒";
            }

            GameManager.instance.taskNo = 7;
        }
        
    }
    public void TaskH()
    {
        if (!GameManager.instance.stopFlag)
        {
            if (diff8 == TimeSpan.Zero)
            {
                diff = TimeSpan.Zero;
            }

            int h = diff8.Hours;
            int m = diff8.Minutes;
            int s = diff8.Seconds;

            if (h != 0)
            {
                GameManager.instance.resultTime.text = h.ToString("f0") + "時間" + m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else if (m != 0)
            {
                GameManager.instance.resultTime.text = m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.resultTime.text = s.ToString("f0") + "秒";
            }

            GameManager.instance.taskNo = 8;
        }
        
    }
    public void TaskI()
    {
        if (!GameManager.instance.stopFlag)
        {
            if (diff9 == TimeSpan.Zero)
            {
                diff = TimeSpan.Zero;
            }

            int h = diff9.Hours;
            int m = diff9.Minutes;
            int s = diff9.Seconds;

            if (h != 0)
            {
                GameManager.instance.resultTime.text = h.ToString("f0") + "時間" + m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else if (m != 0)
            {
                GameManager.instance.resultTime.text = m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.resultTime.text = s.ToString("f0") + "秒";
            }

            GameManager.instance.taskNo = 9;
        }
        
    }
    public void TaskJ()
    {
        if (!GameManager.instance.stopFlag)
        {
            if (diff10 == TimeSpan.Zero)
            {
                diff = TimeSpan.Zero;
            }

            int h = diff10.Hours;
            int m = diff10.Minutes;
            int s = diff10.Seconds;

            if (h != 0)
            {
                GameManager.instance.resultTime.text = h.ToString("f0") + "時間" + m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else if (m != 0)
            {
                GameManager.instance.resultTime.text = m.ToString("f0") + "分" + s.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.resultTime.text = s.ToString("f0") + "秒";
            }

            GameManager.instance.taskNo = 10;
        }
        

    }

    public void TimeListButton()
    {
        if (!GameManager.instance.stopFlag)
        {
            GameManager.instance.timeListFlag = true;

            int h1 = diff1.Hours;
            int m1 = diff1.Minutes;
            int s1 = diff1.Seconds;

            if (h1 != 0)
            {
                GameManager.instance.timeA.text = h1.ToString("f0") + "時間" + m1.ToString("f0") + "分" + s1.ToString("f0") + "秒";
            }
            else if (m1 != 0)
            {
                GameManager.instance.timeA.text = m1.ToString("f0") + "分" + s1.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.timeA.text = s1.ToString("f0") + "秒";
            }

            int h2 = diff2.Hours;
            int m2 = diff2.Minutes;
            int s2 = diff2.Seconds;

            if (h2 != 0)
            {
                GameManager.instance.timeB.text = h2.ToString("f0") + "時間" + m2.ToString("f0") + "分" + s2.ToString("f0") + "秒";
            }
            else if (m2 != 0)
            {
                GameManager.instance.timeB.text = m2.ToString("f0") + "分" + s2.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.timeB.text = s2.ToString("f0") + "秒";
            }

            int h3 = diff3.Hours;
            int m3 = diff3.Minutes;
            int s3 = diff3.Seconds;

            if (h3 != 0)
            {
                GameManager.instance.timeC.text = h3.ToString("f0") + "時間" + m3.ToString("f0") + "分" + s3.ToString("f0") + "秒";
            }
            else if (m3 != 0)
            {
                GameManager.instance.timeC.text = m3.ToString("f0") + "分" + s3.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.timeC.text = s3.ToString("f0") + "秒";
            }

            int h4 = diff4.Hours;
            int m4 = diff4.Minutes;
            int s4 = diff4.Seconds;
            if (h4 != 0)
            {
                GameManager.instance.timeD.text = h4.ToString("f0") + "時間" + m4.ToString("f0") + "分" + s4.ToString("f0") + "秒";
            }
            else if (m4 != 0)
            {
                GameManager.instance.timeD.text = m4.ToString("f0") + "分" + s4.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.timeD.text = s4.ToString("f0") + "秒";
            }

            int h5 = diff5.Hours;
            int m5 = diff5.Minutes;
            int s5 = diff5.Seconds;
            if (h5 != 0)
            {
                GameManager.instance.timeE.text = h5.ToString("f0") + "時間" + m5.ToString("f0") + "分" + s5.ToString("f0") + "秒";
            }
            else if (m5 != 0)
            {
                GameManager.instance.timeE.text = m5.ToString("f0") + "分" + s5.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.timeE.text = s5.ToString("f0") + "秒";
            }
            int h6 = diff6.Hours;
            int m6 = diff6.Minutes;
            int s6 = diff6.Seconds;

            if (h6 != 0)
            {
                GameManager.instance.timeF.text = h6.ToString("f0") + "時間" + m6.ToString("f0") + "分" + s6.ToString("f0") + "秒";
            }
            else if (m6 != 0)
            {
                GameManager.instance.timeF.text = m6.ToString("f0") + "分" + s6.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.timeF.text = s6.ToString("f0") + "秒";
            }

            int h7 = diff7.Hours;
            int m7 = diff7.Minutes;
            int s7 = diff7.Seconds;

            if (h7 != 0)
            {
                GameManager.instance.timeG.text = h7.ToString("f0") + "時間" + m7.ToString("f0") + "分" + s7.ToString("f0") + "秒";
            }
            else if (m7 != 0)
            {
                GameManager.instance.timeG.text = m7.ToString("f0") + "分" + s7.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.timeG.text = s7.ToString("f0") + "秒";
            }

            int h8 = diff8.Hours;
            int m8 = diff8.Minutes;
            int s8 = diff8.Seconds;

            if (h8 != 0)
            {
                GameManager.instance.timeH.text = h8.ToString("f0") + "時間" + m8.ToString("f0") + "分" + s8.ToString("f0") + "秒";
            }
            else if (m8 != 0)
            {
                GameManager.instance.timeH.text = m8.ToString("f0") + "分" + s8.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.timeH.text = s8.ToString("f0") + "秒";
            }

            int h9 = diff9.Hours;
            int m9 = diff9.Minutes;
            int s9 = diff9.Seconds;

            if (h9 != 0)
            {
                GameManager.instance.timeI.text = h9.ToString("f0") + "時間" + m9.ToString("f0") + "分" + s9.ToString("f0") + "秒";
            }
            else if (m9 != 0)
            {
                GameManager.instance.timeI.text = m9.ToString("f0") + "分" + s9.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.timeI.text = s9.ToString("f0") + "秒";
            }

            int h10 = diff10.Hours;
            int m10 = diff10.Minutes;
            int s10 = diff10.Seconds;

            if (h10 != 0)
            {
                GameManager.instance.timeJ.text = h10.ToString("f0") + "時間" + m10.ToString("f0") + "分" + s10.ToString("f0") + "秒";
            }
            else if (m10 != 0)
            {
                GameManager.instance.timeJ.text = m10.ToString("f0") + "分" + s10.ToString("f0") + "秒";
            }
            else
            {
                GameManager.instance.timeJ.text = s10.ToString("f0") + "秒";
            }
        }
        

    }

    public void MishouButton()
    {
        if (!GameManager.instance.stopFlag)
        {
            GameManager.instance.meishouFlag = true;

            GameManager.instance.taskNo = 1;
        }
        
    }

    public void ClearPanelButton()
    {
        if (!GameManager.instance.stopFlag)
        {
            GameManager.instance.clearFlag = true;
        }
        

    }

    public void ClearYesButton()
    {
        if (!GameManager.instance.stopFlag)
        {
            diff1 = TimeSpan.Zero;
            diff2 = TimeSpan.Zero;
            diff3 = TimeSpan.Zero;
            diff4 = TimeSpan.Zero;
            diff5 = TimeSpan.Zero;
            diff6 = TimeSpan.Zero;
            diff7 = TimeSpan.Zero;
            diff8 = TimeSpan.Zero;
            diff9 = TimeSpan.Zero;
            diff10 = TimeSpan.Zero;

            GameManager.instance.clearFlag = false;
        }
       
    }


    public void CloseButton()
    {
        if (!GameManager.instance.stopFlag)
        {
            GameManager.instance.timeListFlag = false;
            GameManager.instance.meishouFlag = false;
            GameManager.instance.clearFlag = false;

            //GameManager.instance.taskNo = 1;
        }

    }

}
