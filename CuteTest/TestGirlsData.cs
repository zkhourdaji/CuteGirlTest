using System;
using System.Collections;
using System.Collections.Generic;
using CuteNamespace;

namespace CuteTest
{
    public class CuteGirlsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]{
                new Girl
                {
                    Weight = 140,
                    Languages = new List<string>{"Spanish"},
                    Height = 160,
                    Hips = 34,
                    Waist = 27,
                    IQ = 90
                    
                }

            };
            yield return new object[]
            {
                new Girl
                {
                    Weight = 110,
                    Languages = new List<string>{"English"},
                    Waist = 10,
                    Hips = 25,
                    Height = 165,
                    IQ = 89

                }
            };
            yield return new object[]
            {
                new Girl
                {
                    Weight = 115,
                    Languages = new List<string>{"Russian"},
                    Waist = 23,
                    Hips = 33,
                    Height = 167

                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class NotCuteGirlsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]{
                new Girl
                {
                    Weight = 110,
                    Languages = new List<string>{"Arabic"},
                    Waist = 21,
                    Hips = 31,
                    IQ = 79,
                    Height = 180

                }
            };
            yield return new object[]
            {
                new Girl
                {
                    Weight = 150,
                    Languages = new List<string>{"French"},
                    Waist = 23,
                    Hips = 34,
                    IQ = 80

                }
            };
            yield return new object[]
            {
                new Girl
                {
                    Weight = 149,
                    Languages = new List<string> {"Ukrainian"},
                    Waist = 23,
                    Hips = 22,
                    IQ = 110

                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
