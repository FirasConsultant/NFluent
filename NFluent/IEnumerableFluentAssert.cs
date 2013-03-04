﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IEnumerableFluentAssert.cs" company="">
// //   Copyright 2013 Thomas PIERRAIN
// //   Licensed under the Apache License, Version 2.0 (the "License");
// //   you may not use this file except in compliance with the License.
// //   You may obtain a copy of the License at
// //       http://www.apache.org/licenses/LICENSE-2.0
// //   Unless required by applicable law or agreed to in writing, software
// //   distributed under the License is distributed on an "AS IS" BASIS,
// //   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// //   See the License for the specific language governing permissions and
// //   limitations under the License.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------
namespace NFluent
{
    using System.Collections;
    using System.Collections.Generic;

    public interface IEnumerableFluentAssert : IEqualityFluentAssert
    {
        void Contains<T>(params T[] expectedValues);
        
        void Contains<T>(IEnumerable<T> otherEnumerable);
       
        void Contains(IEnumerable otherEnumerable);


        void ContainsOnly<T>(params T[] expectedValues);

        //void ContainsOnly<T>(IEnumerable<T> expectedValues);
        
        //void ContainsOnly<T>(List<T> expectedValues);

        //void ContainsOnly(ArrayList expectedValues);
        
        void ContainsOnly(IEnumerable expectedValues);


        void ContainsExactly<T>(params T[] expectedValues);

        void ContainsExactly<T>(IEnumerable<T> otherEnumerable);

        void ContainsExactly(IEnumerable otherEnumerable);


        void HasSize(long expectedSize);

        void IsEmpty();
    }
}