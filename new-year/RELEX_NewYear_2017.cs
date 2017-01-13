using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Application
{
    class Program
    {
        static void Main()
        {
			Console.Title = "";
            var p = new Program();
            var mi = ct(p.GetType());
            var mi1 = mi.ReflectedType.GetMethods().FirstOrDefault(mt => mt.Name == mi.Name && mt.GetParameters().Length != mi.GetParameters().Length);
            var en = Val().GetEnumerator();
            try
            {
                while (true)
                {
                    mi1.Invoke(null, BindingFlags.Static, null, en.Val(), CultureInfo.CurrentCulture);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Console.ReadKey();
            }
        }
        public static int V;
        static IEnumerable<object[]> Val()
        {
            Random rr = new Random();
            
            var i = 8;
            var k = 4;
            var j = 0;
            var r = new object[i+1];
            var next = false;
                foreach (var l in _l)
                {
                try
                {
                    r[r.Length - i-1] = i * l / i;
                    i--;
                    if ((i+1)/2 < 3)
                    {
                        r[r.Length - i-1] = i*rr.Next(21, 25)/i;
                        i--;
                        r[r.Length - i-1] = i*rr.Next(0, 10)/i;
                        i--;
                        r[r.Length - i-1] = (char)(i * rr.Next(320, 329) / 10 / i);
                        i--;
                        r[r.Length - i-1] = i * rr.Next(0, 100) / 10 / i;
                        i--;
                        r[r.Length - i-1] = (char)(i * rr.Next(54, 118) / 10 / i);
                    }
                    
                }
                catch (Exception)
                {
                    r[r.Length - i-1] = 10;

                    next = true;
                }
                if (next)
                {
                    next = false;
                    yield return r;
                    i = 8;
                    r = new object[i+1];
                }
            }
            cc("Stop");
        }
        static MethodInfo ct(Type t)
        {
            var a = t.GetMethods()
                .FirstOrDefault(m => m.GetParameters().Length > 5 && m.GetParameters()
                .All(s => s.ParameterType.Name == t.GetProperties().OrderBy(p1 => p1.Name)
                .ToArray()[1].PropertyType.Name));
            if (a != null)
            {
                V = (int)(t.GetProperties().OrderBy(p1 => p1.Name).ToArray()[2].GetValue(null,null))/2-10;
                return a;
            }
            var nt = t.GetNestedTypes(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (var n in nt)
                return ct(n);
            var m1 = t.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach(var m11 in m1)
            {
                return ct(m11.ReturnType);
            }
            var fl = t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (var f in fl)
                return ct(f.GetType());
            
            var p = t.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (var pl in p)
                return ct(pl.GetType());
            return null;
        }
        delegate Console c(string str);
        static c cc;
        static List<int> _l = new List<int>(){
            0x00,0x01,0x01,0x05,0x01,0x03,0x02,0x01,0x03,0x01,0x01,0x05,0x05,0x02,0x01,0x04,0x08,
            0x02,0x01,0x04,0x06,0x01,0x02,0x01,0x06,0x03,0x02,0x01,0x0a,0x01,0x01,0x05,0x0c,0x01,
            0x01,0x03,0x0b,0x01,0x01,0x01,0x0b,0x03,0x01,0x01,0x0e,0x01,0x01,0x05,0x10,0x01,0x01,
            0x03,0x0f,0x01,0x01,0x01,0x0f,0x03,0x01,0x01,0x12,0x01,0x01,0x03,0x14,0x01,0x01,0x03,
            0x13,0x03,0x01,0x03,0x04,0x07,0x01,0x05,0x07,0x07,0x01,0x05,0x05,0x09,0x01,0x01,0x06,
            0x0a,0x01,0x01,0x09,0x07,0x01,0x05,0x0a,0x07,0x02,0x01,0x0a,0x09,0x02,0x01,0x0a,0x0b,
            0x02,0x01,0x0d,0x07,0x01,0x04,0x0f,0x09,0x01,0x02,0x11,0x07,0x01,0x04,0x0e,0x0b,0x01,
            0x01,0x10,0x0b,0x01,0x01,0x03,0x0d,0x01,0x03,0x05,0x0d,0x01,0x03,0x04,0x0f,0x01,0x03,
            0x07,0x0d,0x01,0x05,0x08,0x0d,0x02,0x01,0x08,0x0f,0x02,0x01,0x08,0x11,0x02,0x01,0x0b,
            0x0e,0x01,0x04,0x0e,0x0e,0x01,0x04,0x0c,0x0d,0x02,0x01,0x0c,0x0f,0x02,0x01,0x10,0x0d,
            0x01,0x05,0x11,0x0d,0x02,0x01,0x11,0x0f,0x02,0x01,0x12,0x10,0x01,0x01,0x13,0x0e,0x01,
            0x01,0x13,0x11,0x01,0x01,0x04,0x13,0x03,0x01,0x04,0x015,0x03,0x01,0x04,0x17,0x03,0x01,
            0x06,0x14,0x01,0x01,0x04,0x16,0x01,0x01,0x08,0x13,0x01,0x05,0x0a,0x13,0x01,0x05,0x09,
            0x13,0x01,0x01,0x09,0x17,0x01,0x01,0x0d,0x13,0x01,0x05,0x0c,0x14,0x01,0x01,0x0f,0x13,
            0x02,0x01,0x11,0x13,0x01,0x05};
    }

    static class Ext
    {
        public static object[] Val(this IEnumerator enumerator)
        {
            if (enumerator.MoveNext())
            {
                var o = (object[])enumerator.Current;
                o[0] = Program.V + (int)o[0];
                return o;
            }
            throw new FieldAccessException();
        }
    }
}
