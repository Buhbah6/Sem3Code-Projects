using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugeIntegerAttempt2
{
    class HugeInteger
    {
        protected ArrayList values; 

        public HugeInteger()
        {
            values = new ArrayList(40);
        }

        public void Input(String bigNum)
        {
            foreach (char c in bigNum)
            {
                values.Add(c - '0');
            }
        }

        public override String ToString()
        {
            String str = "";
            foreach(int it in values)
            {
                str += it;
            }
            return str;
        }

        public HugeInteger Add(HugeInteger other)
        {
            int num1 = 83;
            int num2 = 17;
            int num3 = num1 + num2;
            HugeInteger newInt = new HugeInteger();
            ArrayList iterations;
            newInt.values = new ArrayList(values.Count);
            values.Reverse();
            other.values.Reverse();

            if (values.Count >= other.values.Count)
                iterations = values;
            else
            {
                iterations = other.values;
                other.values = values;
            }  

            for (int i = 0; i < iterations.Count; i++)
            {
                int v1 = (int) iterations[i];
                int v2; 
                if (i >= other.values.Count)
                {
                    v2 = 0;
                }
                else
                {
                    v2 = (int) other.values[i];
                }
                
                if (v1 + v2 >= 10 && i + 1 < values.Count)
                {
                    values[i + 1] = (int)values[i + 1] + 1;
                    newInt.values.Add(v1 + v2 - 10);
                }
                else if (v1 + v2 >= 10 && i + 1 >= values.Count)
                {
                    values.Add(0);
                    values[i + 1] = (int)values[i + 1] + 1;
                    newInt.values.Add(v1 + v2 - 10);
                }
                else
                {
                    newInt.values.Add(v1 + v2);
                }
            }
            other.values.Reverse();
            newInt.values.Reverse();
            return newInt;
        }

        public HugeInteger Subtract(HugeInteger other)
        {
            HugeInteger newInt = new HugeInteger();
            ArrayList iterations;
            newInt.values = new ArrayList(values.Count);
            values.Reverse();
            other.values.Reverse();

            if (values.Count >= other.values.Count)
                iterations = values;
            else
            {
                iterations = other.values;
                other.values = values;
            }

            for (int i = 0; i < iterations.Count; i++)
            {
                int v1 = (int)iterations[i];
                int v2;
                if(i >= other.values.Count)
                {
                    v2 = 0;
                }
                else
                {
                    v2 = (int)other.values[i];
                }

                if (v1 - v2 < 0 && i + 1 < values.Count)
                {
                    values[i + 1] = (int)values[i + 1] - 1;
                    newInt.values.Add(v1 - v2 + 10);
                }
                else if (v1 + v2 < 0 && i + 1 >= values.Count)
                {
                    values.Remove(i);
                    newInt.values.Add(v1 - v2 + 10);
                }
                else
                {
                    newInt.values.Add(v1 - v2);
                }
            }
            while ((int)newInt.values[newInt.values.Count - 1] == 0 && newInt.values.Count - 1 != 0)
            {
                newInt.values.RemoveAt(newInt.values.Count - 1);
            }
            other.values.Reverse();
            newInt.values.Reverse();
            return newInt;
        }

        public HugeInteger Multiply(HugeInteger other)
        {
            
            HugeInteger hgi2 = new HugeInteger();
            String str1 = "";
            String str2 = "";
            hgi2.Input("0");
            for (int i = values.Count - 1; i >= 0; i--)
            {
                str1 = "";
                for (int o = other.values.Count - 1; o >= 0; o--)
                {
                    HugeInteger hgi1 = new HugeInteger();
                    hgi1.Input((((int) values[i]) * ((int)other.values[o])) + str1 + str2);
                    hgi2 = hgi2.Add(hgi1);
                    str1 += "0";
                }
                str2 += "0";
            }
            return hgi2;
        }

        public HugeInteger Divide(HugeInteger other)
        {
            HugeInteger hgi1 = new HugeInteger();
            HugeInteger count = new HugeInteger();
            HugeInteger add = new HugeInteger();
            add.Input("1");
            count.Input("0");
            hgi1.values = values;
            if (hgi1.isLessThan(other))
                return count;
            while (hgi1.isGreaterThanOrEqualTo(other))
            {
                hgi1 = hgi1.Subtract(other);
                count = count.Add(add);
            }
            return count;
        }

        public HugeInteger Remainder(HugeInteger other)
        {
            HugeInteger hgi1 = new HugeInteger();
            hgi1.values = values;
            while (hgi1.isGreaterThanOrEqualTo(other))
            {
                hgi1 = hgi1.Subtract(other);
            }
            return hgi1;
        }

        public Boolean isZero()
        {
            foreach (int i in values)
            {
                if (i != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public Boolean isEqualTo(HugeInteger other)
        {
            if (values.Count == other.values.Count)
            {
                for (int i = 0; i < values.Count; i++)
                {
                    if ((int) values[i] != (int) other.values[i])
                        return false;
                }
                return true;
            }
            return false;
        }

        public Boolean isNotEqualTo(HugeInteger other)
        {
            return !isEqualTo(other);
        }

        public Boolean isGreaterThan(HugeInteger other)
        {
            if (values.Count > other.values.Count)
                return true;
            else if (values.Count == other.values.Count)
            {
                for (int i = values.Count - 1; i >= 0; i--)
                {
                    if ((int) values[i] == (int) other.values[i])
                        continue;
                    else if ((int) values[i] > (int) other.values[i])
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public Boolean isLessThan(HugeInteger other)
        {
            if (values.Count < other.values.Count)
                return true;
            else if (values.Count == other.values.Count)
            {
                for (int i = 0; i < values.Count; i++)
                {
                    if (values[i] == other.values[i])
                        continue;
                    else if ((int) values[i] < (int) other.values[i])
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public Boolean isGreaterThanOrEqualTo(HugeInteger other)
        {
            if (isGreaterThan(other) || isEqualTo(other))
                return true;
            return false;
        }

        public Boolean isLessThanOrEqualTo(HugeInteger other)
        {
            if (isLessThan(other) || isEqualTo(other))
                return true;
            return false;
        }


    }
}
