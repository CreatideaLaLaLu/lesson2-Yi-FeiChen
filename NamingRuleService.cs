using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taichung.Twport.Video.Service
{
    public class NamingRuleService
    {
        /// <summary>
        /// Test 
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public int TestFunction(int index)
        {
            // bad
            switch (index)
            {
                case 1: break;
                default: break;
            }

            // good 
            switch (index)
            {
                case 1:
                    //...
                    break;

                default:
                    //...
                    break;
            }

            // bad
            if (index == 0) DoTrue();
            else
                DoFalse();

            // good  陳述區塊內僅有一行程式，使用大括號圈住
            if (index == 0)
            {
                DoTrue();
            }
            else
            {
                DoFalse();
            }

            // bad
            if (DoTrue() == true) { DoTrue(); }

            // good 條件陳述式中，不將布林變數與true/false作比較
            if (DoTrue())
            {
                DoTrue();
            }

            // bad
            return (index * (index + 1) / 2);

            // good 回傳值本身不再使用括號
            return index * (index + 1) / 2; 
        }

        /// <summary>
        /// Do True
        /// </summary>
        /// <returns></returns>
        private bool DoTrue()
        {
            return true;
        }

        /// <summary>
        /// Do False
        /// </summary>
        /// <returns></returns>
        private bool DoFalse()
        {
            return false;
        }

        /// <summary>
        /// Test String 
        /// </summary>
        /// <param name="value"></param>
        public void TestStringFunction(string value)
        {
            // bad
            string NewString = "ABCDEFG"; //新字串

            if (value != null | value != "") value = NewString.Replace("A", ",").Replace("B", "_").Replace("C", " ");

            // good 使用 camelCasting 命名法
            string newString = "ABCDEFG"; //新字串

            value = new StringBuilder(newString).Replace("A", ",").Replace("B", "_").Replace("C", " ").ToString();
        }

    }
}
